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


namespace HousingManagementSystemForAIUBStudents.Views
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
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
         * Reset all the inputs to blank
         */

        private void _ResetIndexLoginInputs()
        {
            tbIndexLoginEmail.Text = "";
            errMsgIndexLoginEmail.Text = "";

            tbIndexLoginPassword.Text = "";
            errMsgIndexLoginPassword.Text = "";

            btnIndexLogin.Enabled = false;
        }


        /**
         * Reset all the inputs to blank
         */

        private void _ResetIndexRegInputs()
        {
            tbIndexRegName.Text = "";
            errMsgIndexRegName.Text = "";

            tbIndexRegEmail.Text = "";
            errMsgIndexRegEmail.Text = "";

            tbIndexRegPhone.Text = "";
            errMsgIndexRegPhone.Text = "";

            tbIndexRegPassword.Text = "";
            errMsgIndexRegPassword.Text = "";

            tbIndexRegConfirmPassword.Text = "";
            errMsgIndexRegConfirmPassword.Text = "";

            btnIndexRegistration.Enabled = false;
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
            switch(inputs) {
                case Inputs.IndexLoginButton:

                    btn.Enabled = (this._IsEmailValid(tbIndexLoginEmail) && this._IsIndexLoginPasswordValid());

                    break;
                case Inputs.IndexRegButton:

                    btn.Enabled = (this._IsRegistrationNameValid() && this._IsEmailValid(tbIndexRegEmail) && this._IsRegistrationPhoneValid() && this._IsRegistrationPasswordValid() && this._IsRegistrationConfirmPasswordValid());

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
                case Inputs.IndexRegName:

                    if (this._IsRegistrationNameValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.IndexLoginEmail:

                    if (this._IsEmailValid(tbIndexLoginEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.IndexRegEmail:

                    if (this._IsEmailValid(tbIndexRegEmail))
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.IndexLoginPassword:

                    if (this._IsIndexLoginPasswordValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;

                case Inputs.IndexRegPhone:

                    if (this._IsRegistrationPhoneValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                case Inputs.IndexRegPassword:

                    if (this._IsRegistrationPasswordValid())
                    {
                        errorMessage = "";
                        errLable.Text = errorMessage;
                    }
                    else
                    {
                        errLable.Text = errorMessage;
                    }

                    break;
                    
                case Inputs.IndexRegConfirmPassword:

                    if (this._IsRegistrationConfirmPasswordValid())
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


        #region Login Form

        ////////////////////////////////////
        ////        Login Form          ////
        ////////////////////////////////////


        /**
         * Check the Passwrod if it's valid or not
         * Condition -> not empty
         * 
         * @return boolean
         */

        private bool _IsIndexLoginPasswordValid()
        {
            string password = tbIndexLoginPassword.Text.Trim();
            return (password.Length != 0);
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckIndexLoginEmailValidation()
        {
            string errorMessage = "";
            string email = tbIndexLoginEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid\n";
            }

            this._ShowErrorMessage(Inputs.IndexLoginEmail, ref errMsgIndexLoginEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexLogin, Inputs.IndexLoginButton);
        }


        /**
         * Check the Passwrod
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckIndexLoginPasswordValidation()
        {
            string errorMessage = "";
            string password = tbIndexLoginPassword.Text.Trim();

            if (password.Length == 0)
            {
                errorMessage += "Password can't be empty\n";
            }

            this._ShowErrorMessage(Inputs.IndexLoginPassword, ref errMsgIndexLoginPassword, ref errorMessage);


            this._SetButtonEnableProperties(btnIndexLogin, Inputs.IndexLoginButton);
        }

        private void tbLoginEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckIndexLoginEmailValidation();
        }

        private void tbLoginPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckIndexLoginPasswordValidation();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this._IsEmailValid(tbIndexLoginEmail) || !this._IsIndexLoginPasswordValid())
            {
                this._CheckIndexLoginEmailValidation();
                this._CheckIndexLoginPasswordValidation();

                return;
            }

            // Start Database Login process
            string email = tbIndexLoginEmail.Text.Trim();
            string password = tbIndexLoginPassword.Text.Trim();
            string type = gbIndexLoginUserType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text.Trim();

            dynamic user = null;

            if (type.Equals("Student"))
            {
                user = new Tenant();
            }
            else if (type.Equals("Renter"))
            {
                user = new Renter();
            }
            else if (type.Equals("Admin"))
            {
                user = new Admin();
            }

            user.Email = email;
            user.Password = password;

            user = IndexController.AuthenticateUser(user, this);

            this._ResetIndexLoginInputs();

            if (user == null)
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "Login Credential is not correct",
                    "Error Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion

        #region Registration Form

        ///////////////////////////////////////////
        ////        Registration Form          ////
        ///////////////////////////////////////////


        /**
         * Is Name valid or not
         * Condition -> not empty, larger than 2 char, alphanumeric with -, _
         * Tried on
         * @link https://regexr.com/5rvjm
         * 
         * @return boolean
         */

        private bool _IsRegistrationNameValid()
        {
            string name = tbIndexRegName.Text.Trim();
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

        private bool _IsRegistrationPhoneValid()
        {
            string phone = tbIndexRegPhone.Text.Trim();
            return (phone.Length != 0 && Regex.IsMatch(phone,@"^(\+8801[2-9]\d{1}[0-9]\d{6})$"));
        }


        /**
         * Is Password valid or not
         * Condition -> not empty, larger than 7 char,
         * include at least one char !, @, #, $, % 
         * Tried on
         * @link https://regexr.com/5rvj1
         * 
         * @return boolean
         */

        private bool _IsRegistrationPasswordValid()
        {
            string password = tbIndexRegPassword.Text.Trim();
            return (password.Length != 0 && password.Length > 7 && Regex.IsMatch(password, @"[!@#$%]+") && this._IsRegistrationConfirmPasswordValid());
        }


        /**
         * Is Confirm Password valid or not
         * Condition -> not empty, equal to Password
         * 
         * @return boolean
         */

        private bool _IsRegistrationConfirmPasswordValid()
        {
            string password = tbIndexRegPassword.Text.Trim();
            string confirmPassword = tbIndexRegConfirmPassword.Text.Trim();
            return (confirmPassword.Length != 0 && confirmPassword.Equals(password));
        }


        /**
         * Check the Name
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationNameValidation()
        {
            string errorMessage = "";
            string name = tbIndexRegName.Text.Trim();

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

            this._ShowErrorMessage(Inputs.IndexRegName, ref errMsgIndexRegName, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexRegistration, Inputs.IndexRegButton);
        }


        /**
         * Check the Email
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationEmailValidation()
        {
            string errorMessage = "";
            string email = tbIndexRegEmail.Text.Trim();

            if (email.Length == 0)
            {
                errorMessage += "Email can't be empty\n";
            }

            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)+(?:\.[a-zA-Z0-9-]+)*$") && email.Length != 0)
            {
                errorMessage += "Email is not valid e.g admin@admin.com\n";
            }

            this._ShowErrorMessage(Inputs.IndexRegEmail, ref errMsgIndexRegEmail, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexRegistration, Inputs.IndexRegButton);
        }


        /**
         * Check the Phone
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationPhoneValidation()
        {
            string errorMessage = "";
            string phone = tbIndexRegPhone.Text.Trim();

            if (phone.Length == 0)
            {
                errorMessage += "Phone Number can't be empty\n";
            }

            if (!Regex.IsMatch(phone, @"^(\+8801[2-9]\d{1}[0-9]\d{6})$") && phone.Length != 0)
            {
                errorMessage += "Phone Number is not valid e.g +8801628769304\n";
            }

            this._ShowErrorMessage(Inputs.IndexRegPhone, ref errMsgIndexRegPhone, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexRegistration, Inputs.IndexRegButton);
        }


        /**
         * Check the Password
         * and show the Error message
         * in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationPasswordValidation()
        {
            string errorMessage = "";
            string password = tbIndexRegPassword.Text.Trim();

            if (password.Length == 0)
            {
                errorMessage += "Password can't be empty\n";
            }
            if (password.Length < 8 && password.Length != 0)
            {
                errorMessage += "Password must be larger then 8 characters\n";
            }

            if (!Regex.IsMatch(password, @"[!@#$%]+") && password.Length != 0)
            {
                errorMessage += "Password must include at least one special characters (!, @, #, $, %)\n";
            }

            this._ShowErrorMessage(Inputs.IndexRegPassword, ref errMsgIndexRegPassword, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexRegistration, Inputs.IndexRegButton);

            this._CheckRegistrationConfirmPasswordValidation();
        }


        /**
         * Check the Confirm Password
         * and show the Error message
         * also check Password and Confirm Password equal or not
         * show error message in the Form page
         * if any Error message have
         * 
         * @return void
         */

        private void _CheckRegistrationConfirmPasswordValidation()
        {
            
            string errorMessage = "";
            string password = tbIndexRegPassword.Text.Trim();
            string confirmPassword = tbIndexRegConfirmPassword.Text.Trim();

            if (confirmPassword.Length == 0)
            {
                errorMessage += "Confirm Password can't be empty\n";
            }

            if (!confirmPassword.Equals(password))
            {
                errorMessage += "Confirm Password must match Password\n";
            }

            this._ShowErrorMessage(Inputs.IndexRegConfirmPassword, ref errMsgIndexRegConfirmPassword, ref errorMessage);

            this._SetButtonEnableProperties(btnIndexRegistration, Inputs.IndexRegButton);
        }

        private void tbRegName_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationNameValidation();
        }

        private void tbRegEmail_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationEmailValidation();
        }

        private void tbRegPhone_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationPhoneValidation();
        }

        private void tbRegPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationPasswordValidation();
        }

        private void tbRegConfirmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            this._CheckRegistrationConfirmPasswordValidation();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (!this._IsRegistrationNameValid() || !this._IsEmailValid(tbIndexRegEmail) || !this._IsRegistrationPhoneValid() || !this._IsRegistrationPasswordValid() || !this._IsRegistrationConfirmPasswordValid())
            {
                this._CheckRegistrationNameValidation();
                this._CheckRegistrationEmailValidation();
                this._CheckRegistrationPhoneValidation();
                this._CheckRegistrationPasswordValidation();
                this._CheckRegistrationConfirmPasswordValidation();

                return;
            }

            // Start Database Registration process

            string name = tbIndexRegName.Text.Trim();
            string email = tbIndexRegEmail.Text.Trim();
            string phone = tbIndexRegPhone.Text.Trim();
            string password = tbIndexRegPassword.Text.Trim();
            string type = gbIndexRegUserType.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked).Text.Trim();

            dynamic user = null;

            if (type.Equals("Student"))
            {
                user = new Tenant();
            }
            else if (type.Equals("Renter"))
            {
                user = new Renter();
            }

            user.Name = name;
            user.Email = email;
            user.Phone = phone;
            user.Password = password;

            bool isCreated = IndexController.Registration(user);

            this._ResetIndexRegInputs();

            if (isCreated)
            {
                // Displays the MessageBox.
                MessageBox.Show(
                    "Added Successfull!",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        #endregion
    }
}