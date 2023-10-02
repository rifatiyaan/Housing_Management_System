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

using HousingManagementSystemForAIUBStudents.Models;
using HousingManagementSystemForAIUBStudents.Controllers;

namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    public partial class AdminForm : Form
    {
        private AdminForm()
        {
            InitializeComponent();
        }

        private Admin admin = null;
        public AdminForm(Admin admin)
        {
            this.admin = admin;
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

        private void _SetButtonEnableProperties(Button btn, Inputs input)
        {
            switch(input)
            {
                case Inputs.AdminSarchUserButton:

                    btn.Enabled = (this._IsEmailValid(tbAdminSearchUserEmail));

                    break;
                case Inputs.AdminDeleteUserButton:

                    btn.Enabled = (this._IsEmailValid(tbAdminDeleteUserEmail));

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
                case Inputs.AdminSearchUserEmail:

                    if (this._IsEmailValid(tbAdminSearchUserEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.AdminDeleteUserEmail:

                    if (this._IsEmailValid(tbAdminDeleteUserEmail))
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


        #region Search User

        //////////////////////////////////////////
        ////        Search User Form          ////
        //////////////////////////////////////////


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckAdminSearchUserEmailValidation()
        {
            string errorMessage = "";
            string email = tbAdminSearchUserEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.AdminSearchUserEmail, ref errMsgAdminSearchUserEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnAdminSearchUser, Inputs.AdminSarchUserButton);
        }


        private void tbSearchUserEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckAdminSearchUserEmailValidation();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            if (!this._IsEmailValid(tbAdminSearchUserEmail))
            {
                this._CheckAdminSearchUserEmailValidation();

                return;
            }

            // Start Database Searching process

            string email = tbAdminSearchUserEmail.Text.Trim();
            string type = gbAdminSearchUserType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text.Trim();

            rtbAdminSearchUser.Text = "";
            dynamic user = AdminController.SearchUser(email, type);

            if (user != null)
            {
                rtbAdminSearchUser.Text = "";
                rtbAdminSearchUser.Text = String.Format("Name: {0}\nEmail: {1}\nPhone: {2}", user.Name, user.Email, user.Phone);
                tbAdminSearchUserEmail.Text = "";
            }
            else
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "User not found",
                    "Error | User not found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion

        #region Delete User

        //////////////////////////////////////////
        ////        Delete User Form          ////
        //////////////////////////////////////////


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckAdminDeleteUserEmailValidation()
        {
            string errorMessage = "";
            string email = tbAdminDeleteUserEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.AdminDeleteUserEmail, ref errMsgAdminDeleteUserEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnAdminDeleteUser, Inputs.AdminDeleteUserButton);
        }

        private void tbDeleteUserEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckAdminDeleteUserEmailValidation();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (!this._IsEmailValid(tbAdminDeleteUserEmail))
            {
                this._CheckAdminDeleteUserEmailValidation();

                return;
            }

            // Start Database Deleting process

            DialogResult confirm = MessageBox.Show(
                this,
                "Are you sure you want to Delete the user?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                string email = tbAdminDeleteUserEmail.Text.Trim();
                string type = gbAdminDeleteUserType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text.Trim();

                bool isUserDelete = AdminController.DeleteUser(email, type);

                if (isUserDelete)
                {
                    // Displays the MessageBox.
                    MessageBox.Show(
                        "User Deleted Successfully",
                        "Success | User Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    tbAdminDeleteUserEmail.Text = "";
                }
                else
                {
                    // Displays the MessageBox.
                    MessageBox.Show(
                        "User not found",
                        "Error | User not found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        #endregion

    }
}
