using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

using HousingManagementSystemForAIUBStudents.Models;
using HousingManagementSystemForAIUBStudents.Controllers;

namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    public partial class TenantForm : Form
    {
        private TenantForm()
        {
            InitializeComponent();
        }

        private Tenant tenant = null;
        public TenantForm(Tenant tenant)
        {
            this.tenant = tenant;
            InitializeComponent();
        }

        override protected void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason != CloseReason.WindowsShutDown)
            {
                Application.Exit();
            }
        }


        /**
         * Set the Enable properties of Login Button
         * depending on the validation
         * if the all the inputs are
         * valid then Enable properties set to True
         * otherwise False
         * 
         * @return void
         */

        private void _SetButtonEnableProperties(Button btn, Inputs inputs)
        {
            switch (inputs)
            {
                case Inputs.TenantEditButton:

                    btn.Enabled = (this._IsTenantEditNameValid() && this._IsEmailValid(tbTenantEditEmail) && this._IsTenantEditPhoneValid());

                    break;
                case Inputs.TenantSearchButton:

                    btn.Enabled = (this._IsHouseIdValid(tbTenantViewHouseId));

                    break;
                case Inputs.TenantRentButton:

                    btn.Enabled = (this._IsHouseIdValid(tbTenantRentHouseId));

                    break;
            }
        }


        /**
         * Show the Error message on inputs
         * bellow if any error message have
         * 
         * @return void
         */

        private void _ShowErrorMessage(Inputs input, ref Label errLable, ref string errorMessage)
        {
            switch (input)
            {
                case Inputs.TenantEditName:

                    if (this._IsTenantEditNameValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.TenantEditEmail:

                    if (this._IsEmailValid(tbTenantEditEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.TenantEditPhone:

                    if (this._IsTenantEditPhoneValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.TenantViewHouseId:

                    if (this._IsHouseIdValid(tbTenantViewHouseId))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.TenantRentHouseId:

                    if (this._IsHouseIdValid(tbTenantRentHouseId))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
            }

        }


        /**
         * Check the Email if it's valid or not
         * Tried on
         * @link https://regexr.com/5r0tf
         * 
         * @return boolean
         */

        private bool _IsEmailValid(TextBox tb)
        {
            string email = tb.Text.Trim();
            return (email.Length != 0 && Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$"));
        }


        /**
         * Is House ID valid or not
         * Condition -> not empty, numeric
         * Tried on
         * @link https://regexr.com/5s15f
         * 
         * @return boolean
         */

        private bool _IsHouseIdValid(TextBox tb)
        {
            string houseId = tb.Text.Trim();
            return (houseId.Length != 0 && Regex.IsMatch(houseId, @"^[0-9]+$"));
        }


        #region Edit Profile

        ///////////////////////////////////////////
        ////        Edit Profile Form          ////
        ///////////////////////////////////////////


        /**
         * Is Name valid or not
         * Condition -> not empty, larger than 2 char, alphanumeric with -, _
         * Tried on
         * @link https://regexr.com/5rvjm
         * 
         * @return boolean
         */

        private bool _IsTenantEditNameValid()
        {
            string name = tbTenantEditName.Text.Trim();
            return (name.Length > 2 && Regex.IsMatch(name, @"^[a-zA-Z0-9\s-_]+$"));
        }


        /**
         * Is Phone valid or not
         * Condition -> not empty, valid bd phone
         * Tried on
         * @link https://regexr.com/5rvf6
         * 
         * @return boolean
         */

        private bool _IsTenantEditPhoneValid()
        {
            string phone = tbTenantEditPhone.Text.Trim();
            return (phone.Length != 0 && Regex.IsMatch(phone,@"^(\+8801[2-9]\d{1}[0-9]\d{6})$"));
        }


        /**
         * Check the Name
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckTenantEditNameValidation()
        {
            string errorMessage = "";
            string name = tbTenantEditName.Text.Trim();

            if (name.Length == 0)
            {
                errorMessage += "Name can't be empty\n";
            }

            if (name.Length < 3 && name.Length != 0)
            {
                errorMessage += "Name must be larger than 2 character\n";
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z0-9\s-_]+$") && name.Length != 0)
            {
                errorMessage += "Name must be alphaneumeric, dash(-) and underscore(_) \n";
            }

            this._ShowErrorMessage(Inputs.TenantEditName, ref errMsgTenantEditName, ref errorMessage);

            this._SetButtonEnableProperties(btnTenantEditProfile, Inputs.TenantEditButton);
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckTenantEditEmailValidation()
        {
            string errorMessage = "";
            string email = tbTenantEditEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid e.g admin@admin.com\n";
            }

            this._ShowErrorMessage(Inputs.TenantEditEmail, ref errMsgTenantEditEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnTenantEditProfile, Inputs.TenantEditButton);
        }


        /**
         * Check the Phone
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckTenantEditPhoneValidation()
        {
            string errorMessage = "";
            string phone = tbTenantEditPhone.Text.Trim();

            if (phone.Length == 0)
            {
                errorMessage += "Phone Number can't be empty\n";
            }

            if (!Regex.IsMatch(phone, @"^(\+8801[2-9]\d{1}[0-9]\d{6})$") && phone.Length != 0)
            {
                errorMessage += "Phone Number is not valid e.g +8801628769304\n";
            }

            this._ShowErrorMessage(Inputs.TenantEditPhone, ref errMsgTenantEditPhone, ref errorMessage);

            this._SetButtonEnableProperties(btnTenantEditProfile, Inputs.TenantEditButton);
        }

        private void _LoadTenantEditInfromation()
        {
            tbTenantEditName.Text = this.tenant.Name.Trim();
            tbTenantEditEmail.Text = this.tenant.Email.Trim();
            tbTenantEditPhone.Text = this.tenant.Phone.Trim();
        }

        private void tbEditName_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckTenantEditNameValidation();
        }

        private void tbEditEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckTenantEditEmailValidation();
        }

        private void tbEditPhone_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckTenantEditPhoneValidation();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if (!this._IsTenantEditNameValid() || !this._IsEmailValid(tbTenantEditEmail) || !this._IsTenantEditPhoneValid())
            {
                this._CheckTenantEditNameValidation();
                this._CheckTenantEditEmailValidation();
                this._CheckTenantEditPhoneValidation();

                return;
            }

            // Start Database Editing process

            string name = tbTenantEditName.Text.Trim();
            string oldEmail = this.tenant.Email.Trim();
            string newEmail = tbTenantEditEmail.Text.Trim();
            string phone = tbTenantEditPhone.Text.Trim();

            // new tenant
            Tenant newTenant = new Tenant();
                newTenant.Name = name;
                newTenant.Email = newEmail;
                newTenant.Phone = phone;
                newTenant.Password = tenant.Password.Trim();

            // update the tenant
            Tenant updateTenant = TenantController.EditProfile(newTenant, oldEmail);

            if (updateTenant != null)
            {
                // update the auth
                this.tenant.Name = updateTenant.Name.Trim();
                this.tenant.Email = updateTenant.Email.Trim();
                this.tenant.Phone = updateTenant.Phone.Trim();

                // Displays the MessageBox.
                MessageBox.Show(
                    "Successfully Updated your profile",
                    "Susscess | Update Profile",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                //update the form
                tbTenantEditName.Text = updateTenant.Name.Trim();
                tbTenantEditEmail.Text = updateTenant.Email.Trim();
                tbTenantEditPhone.Text = updateTenant.Phone.Trim();

                // disable the submit (Edit) button
                btnTenantEditProfile.Enabled = false;
            }
            else
            {
                this._LoadTenantEditInfromation();
                // Displays the MessageBox.
                MessageBox.Show(
                    "Updating profile Unsuccessfull",
                    "Unsuccessfull | Profile not update",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion


        #region View House

        /////////////////////////////////////////
        ////        View House Form          ////
        /////////////////////////////////////////


        /**
         * Check the View House ID
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckTenantViewHouseIdValidation()
        {
            string errorMessage = "";
            string houseId = tbTenantViewHouseId.Text.Trim();

            if (houseId.Length == 0)
            {
                errorMessage += "House ID can't be empty\n";
            }

            if (!Regex.IsMatch(houseId, @"^[0-9]+$") && houseId.Length != 0)
            {
                errorMessage += "House ID must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.TenantViewHouseId, ref errMsgTenantViewHouseId, ref errorMessage);

            this._SetButtonEnableProperties(btnTenantViewHouse, Inputs.TenantSearchButton);
        }

        private void _LoadTenantViewHouseInformation()
        {
            dgvTenantViewHouse.DataSource = TenantController.GetAllHouse();
        }

        private void tbViewHouseId_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckTenantViewHouseIdValidation();
        }

        private void btnViewHouse_Click(object sender, EventArgs e)
        {
            if (!this._IsHouseIdValid(tbTenantViewHouseId))
            {
                this._CheckTenantViewHouseIdValidation();

                return;
            }

            string houseId = tbTenantViewHouseId.Text.Trim();

            House house = TenantController.GetHouse(houseId);

            if (house != null)
            {
                ArrayList houses = new ArrayList();
                houses.Add(house);
                dgvTenantViewHouse.DataSource = houses;
                tbTenantViewHouseId.Text = "";
            }
            else
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "House not found",
                    "Error | House not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this._LoadTenantViewHouseInformation();
            }
        }


        private void btnTenantViewHouseShowAll_Click(object sender, EventArgs e)
        {
            this._LoadTenantViewHouseInformation();
        }

        #endregion


        #region Rent House

        /////////////////////////////////////////
        ////        Rent House Form          ////
        /////////////////////////////////////////


        /**
         * Check the Rent House ID
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckTenantRentHouseIdValidation()
        {
            string errorMessage = "";
            string houseId = tbTenantRentHouseId.Text.Trim();

            if (houseId.Length == 0)
            {
                errorMessage += "House ID can't be empty\n";
            }

            if (!Regex.IsMatch(houseId, @"^[0-9]+$") && houseId.Length != 0)
            {
                errorMessage += "House ID must be Numeric\n";
            }

            this._ShowErrorMessage(Inputs.TenantRentHouseId, ref errMsgTenantRentHouseId, ref errorMessage);

            this._SetButtonEnableProperties(btnTenantRentHouse, Inputs.TenantRentButton);
        }

        private void _LoadTenantRentHouseInformation()
        {
            dgvTenantRentHouse.DataSource = TenantController.GetAllRentHouse(this.tenant.Id);
        }

        private void tbRentHouseId_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckTenantRentHouseIdValidation();
        }

        private void btnRentHouse_Click(object sender, EventArgs e)
        {
            if (!this._IsHouseIdValid(tbTenantRentHouseId))
            {
                this._CheckTenantRentHouseIdValidation();

                return;
            }

            // Start Database Renting process

            string houseId = tbTenantRentHouseId.Text.Trim();
            bool isRented = TenantController.RentHouse(houseId, this.tenant.Id);

            if (isRented)
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "House Rent Successfully",
                    "Success | House Rent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                tbTenantRentHouseId.Text = "";
                btnTenantRentHouse.Enabled = false;
                this._LoadTenantRentHouseInformation();
            }
            else
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "House Rent Unuccessfully",
                    "Error | House not Rent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion

        private void TenantForm_Load(object sender, EventArgs e)
        {
            this._LoadTenantEditInfromation();
            this._LoadTenantViewHouseInformation();
            this._LoadTenantRentHouseInformation();
        }
    }
}
