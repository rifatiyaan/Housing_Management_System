namespace HousingManagementSystemForAIUBStudents.Views
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.tabControlIndex = new System.Windows.Forms.TabControl();
            this.tabIndexLogin = new System.Windows.Forms.TabPage();
            this.lbIndexLoginUserType = new System.Windows.Forms.Label();
            this.errMsgIndexLoginPassword = new System.Windows.Forms.Label();
            this.errMsgIndexLoginEmail = new System.Windows.Forms.Label();
            this.btnIndexLogin = new System.Windows.Forms.Button();
            this.gbIndexLoginUserType = new System.Windows.Forms.GroupBox();
            this.rbIndexLoginAdmin = new System.Windows.Forms.RadioButton();
            this.rbIndexLoginRenter = new System.Windows.Forms.RadioButton();
            this.rbIndexLoginTenant = new System.Windows.Forms.RadioButton();
            this.tbIndexLoginPassword = new System.Windows.Forms.TextBox();
            this.lbIndexLoginPassword = new System.Windows.Forms.Label();
            this.tbIndexLoginEmail = new System.Windows.Forms.TextBox();
            this.lbIndexLoginEmail = new System.Windows.Forms.Label();
            this.tabIndexRegistration = new System.Windows.Forms.TabPage();
            this.btnIndexRegistration = new System.Windows.Forms.Button();
            this.errMsgIndexRegPhone = new System.Windows.Forms.Label();
            this.tbIndexRegPhone = new System.Windows.Forms.TextBox();
            this.lbIndexRegPhone = new System.Windows.Forms.Label();
            this.errMsgIndexRegConfirmPassword = new System.Windows.Forms.Label();
            this.tbIndexRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbIndexRegConfirmPassword = new System.Windows.Forms.Label();
            this.errMsgIndexRegName = new System.Windows.Forms.Label();
            this.tbIndexRegName = new System.Windows.Forms.TextBox();
            this.lbIndexRegName = new System.Windows.Forms.Label();
            this.lbIndexRegUserType = new System.Windows.Forms.Label();
            this.errMsgIndexRegPassword = new System.Windows.Forms.Label();
            this.errMsgIndexRegEmail = new System.Windows.Forms.Label();
            this.gbIndexRegUserType = new System.Windows.Forms.GroupBox();
            this.rbIndexRegRenter = new System.Windows.Forms.RadioButton();
            this.rbIndexRegTenant = new System.Windows.Forms.RadioButton();
            this.tbIndexRegPassword = new System.Windows.Forms.TextBox();
            this.lbIndexRegPassword = new System.Windows.Forms.Label();
            this.tbIndexRegEmail = new System.Windows.Forms.TextBox();
            this.lbIndexRegEmail = new System.Windows.Forms.Label();
            this.tabControlIndex.SuspendLayout();
            this.tabIndexLogin.SuspendLayout();
            this.gbIndexLoginUserType.SuspendLayout();
            this.tabIndexRegistration.SuspendLayout();
            this.gbIndexRegUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlIndex
            // 
            this.tabControlIndex.Controls.Add(this.tabIndexLogin);
            this.tabControlIndex.Controls.Add(this.tabIndexRegistration);
            this.tabControlIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlIndex.Location = new System.Drawing.Point(4, 4);
            this.tabControlIndex.Name = "tabControlIndex";
            this.tabControlIndex.SelectedIndex = 0;
            this.tabControlIndex.Size = new System.Drawing.Size(774, 545);
            this.tabControlIndex.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlIndex.TabIndex = 0;
            this.tabControlIndex.TabStop = false;
            // 
            // tabIndexLogin
            // 
            this.tabIndexLogin.Controls.Add(this.lbIndexLoginUserType);
            this.tabIndexLogin.Controls.Add(this.errMsgIndexLoginPassword);
            this.tabIndexLogin.Controls.Add(this.errMsgIndexLoginEmail);
            this.tabIndexLogin.Controls.Add(this.btnIndexLogin);
            this.tabIndexLogin.Controls.Add(this.gbIndexLoginUserType);
            this.tabIndexLogin.Controls.Add(this.tbIndexLoginPassword);
            this.tabIndexLogin.Controls.Add(this.lbIndexLoginPassword);
            this.tabIndexLogin.Controls.Add(this.tbIndexLoginEmail);
            this.tabIndexLogin.Controls.Add(this.lbIndexLoginEmail);
            this.tabIndexLogin.Location = new System.Drawing.Point(4, 30);
            this.tabIndexLogin.Name = "tabIndexLogin";
            this.tabIndexLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndexLogin.Size = new System.Drawing.Size(766, 511);
            this.tabIndexLogin.TabIndex = 0;
            this.tabIndexLogin.Text = "Login";
            this.tabIndexLogin.UseVisualStyleBackColor = true;
            // 
            // lbIndexLoginUserType
            // 
            this.lbIndexLoginUserType.AutoSize = true;
            this.lbIndexLoginUserType.Location = new System.Drawing.Point(65, 241);
            this.lbIndexLoginUserType.Name = "lbIndexLoginUserType";
            this.lbIndexLoginUserType.Size = new System.Drawing.Size(78, 21);
            this.lbIndexLoginUserType.TabIndex = 9;
            this.lbIndexLoginUserType.Text = "User Type";
            // 
            // errMsgIndexLoginPassword
            // 
            this.errMsgIndexLoginPassword.AutoSize = true;
            this.errMsgIndexLoginPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexLoginPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexLoginPassword.Location = new System.Drawing.Point(192, 173);
            this.errMsgIndexLoginPassword.Name = "errMsgIndexLoginPassword";
            this.errMsgIndexLoginPassword.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexLoginPassword.TabIndex = 8;
            // 
            // errMsgIndexLoginEmail
            // 
            this.errMsgIndexLoginEmail.AutoSize = true;
            this.errMsgIndexLoginEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexLoginEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexLoginEmail.Location = new System.Drawing.Point(192, 93);
            this.errMsgIndexLoginEmail.Name = "errMsgIndexLoginEmail";
            this.errMsgIndexLoginEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexLoginEmail.TabIndex = 7;
            // 
            // btnIndexLogin
            // 
            this.btnIndexLogin.Enabled = false;
            this.btnIndexLogin.Location = new System.Drawing.Point(196, 328);
            this.btnIndexLogin.Name = "btnIndexLogin";
            this.btnIndexLogin.Size = new System.Drawing.Size(150, 35);
            this.btnIndexLogin.TabIndex = 6;
            this.btnIndexLogin.Text = "Login";
            this.btnIndexLogin.UseVisualStyleBackColor = true;
            this.btnIndexLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbIndexLoginUserType
            // 
            this.gbIndexLoginUserType.Controls.Add(this.rbIndexLoginAdmin);
            this.gbIndexLoginUserType.Controls.Add(this.rbIndexLoginRenter);
            this.gbIndexLoginUserType.Controls.Add(this.rbIndexLoginTenant);
            this.gbIndexLoginUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbIndexLoginUserType.Location = new System.Drawing.Point(196, 217);
            this.gbIndexLoginUserType.Name = "gbIndexLoginUserType";
            this.gbIndexLoginUserType.Size = new System.Drawing.Size(445, 58);
            this.gbIndexLoginUserType.TabIndex = 3;
            this.gbIndexLoginUserType.TabStop = false;
            // 
            // rbIndexLoginAdmin
            // 
            this.rbIndexLoginAdmin.AutoSize = true;
            this.rbIndexLoginAdmin.Location = new System.Drawing.Point(353, 20);
            this.rbIndexLoginAdmin.Name = "rbIndexLoginAdmin";
            this.rbIndexLoginAdmin.Size = new System.Drawing.Size(77, 25);
            this.rbIndexLoginAdmin.TabIndex = 5;
            this.rbIndexLoginAdmin.Text = "Admin";
            this.rbIndexLoginAdmin.UseVisualStyleBackColor = true;
            // 
            // rbIndexLoginRenter
            // 
            this.rbIndexLoginRenter.AutoSize = true;
            this.rbIndexLoginRenter.Location = new System.Drawing.Point(179, 20);
            this.rbIndexLoginRenter.Name = "rbIndexLoginRenter";
            this.rbIndexLoginRenter.Size = new System.Drawing.Size(77, 25);
            this.rbIndexLoginRenter.TabIndex = 4;
            this.rbIndexLoginRenter.Text = "Renter";
            this.rbIndexLoginRenter.UseVisualStyleBackColor = true;
            // 
            // rbIndexLoginTenant
            // 
            this.rbIndexLoginTenant.AutoSize = true;
            this.rbIndexLoginTenant.Checked = true;
            this.rbIndexLoginTenant.Location = new System.Drawing.Point(7, 20);
            this.rbIndexLoginTenant.Name = "rbIndexLoginTenant";
            this.rbIndexLoginTenant.Size = new System.Drawing.Size(86, 25);
            this.rbIndexLoginTenant.TabIndex = 3;
            this.rbIndexLoginTenant.TabStop = true;
            this.rbIndexLoginTenant.Text = "Student";
            this.rbIndexLoginTenant.UseVisualStyleBackColor = true;
            // 
            // tbIndexLoginPassword
            // 
            this.tbIndexLoginPassword.Location = new System.Drawing.Point(196, 142);
            this.tbIndexLoginPassword.Name = "tbIndexLoginPassword";
            this.tbIndexLoginPassword.Size = new System.Drawing.Size(293, 28);
            this.tbIndexLoginPassword.TabIndex = 2;
            this.tbIndexLoginPassword.UseSystemPasswordChar = true;
            this.tbIndexLoginPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLoginPassword_KeyUp);
            // 
            // lbIndexLoginPassword
            // 
            this.lbIndexLoginPassword.AutoSize = true;
            this.lbIndexLoginPassword.Location = new System.Drawing.Point(65, 149);
            this.lbIndexLoginPassword.Name = "lbIndexLoginPassword";
            this.lbIndexLoginPassword.Size = new System.Drawing.Size(77, 21);
            this.lbIndexLoginPassword.TabIndex = 2;
            this.lbIndexLoginPassword.Text = "Password";
            // 
            // tbIndexLoginEmail
            // 
            this.tbIndexLoginEmail.Location = new System.Drawing.Point(196, 62);
            this.tbIndexLoginEmail.Name = "tbIndexLoginEmail";
            this.tbIndexLoginEmail.Size = new System.Drawing.Size(293, 28);
            this.tbIndexLoginEmail.TabIndex = 1;
            this.tbIndexLoginEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbLoginEmail_KeyUp);
            // 
            // lbIndexLoginEmail
            // 
            this.lbIndexLoginEmail.AutoSize = true;
            this.lbIndexLoginEmail.Location = new System.Drawing.Point(65, 69);
            this.lbIndexLoginEmail.Name = "lbIndexLoginEmail";
            this.lbIndexLoginEmail.Size = new System.Drawing.Size(48, 21);
            this.lbIndexLoginEmail.TabIndex = 0;
            this.lbIndexLoginEmail.Text = "Email";
            // 
            // tabIndexRegistration
            // 
            this.tabIndexRegistration.Controls.Add(this.btnIndexRegistration);
            this.tabIndexRegistration.Controls.Add(this.errMsgIndexRegPhone);
            this.tabIndexRegistration.Controls.Add(this.tbIndexRegPhone);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegPhone);
            this.tabIndexRegistration.Controls.Add(this.errMsgIndexRegConfirmPassword);
            this.tabIndexRegistration.Controls.Add(this.tbIndexRegConfirmPassword);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegConfirmPassword);
            this.tabIndexRegistration.Controls.Add(this.errMsgIndexRegName);
            this.tabIndexRegistration.Controls.Add(this.tbIndexRegName);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegName);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegUserType);
            this.tabIndexRegistration.Controls.Add(this.errMsgIndexRegPassword);
            this.tabIndexRegistration.Controls.Add(this.errMsgIndexRegEmail);
            this.tabIndexRegistration.Controls.Add(this.gbIndexRegUserType);
            this.tabIndexRegistration.Controls.Add(this.tbIndexRegPassword);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegPassword);
            this.tabIndexRegistration.Controls.Add(this.tbIndexRegEmail);
            this.tabIndexRegistration.Controls.Add(this.lbIndexRegEmail);
            this.tabIndexRegistration.Location = new System.Drawing.Point(4, 30);
            this.tabIndexRegistration.Name = "tabIndexRegistration";
            this.tabIndexRegistration.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndexRegistration.Size = new System.Drawing.Size(766, 511);
            this.tabIndexRegistration.TabIndex = 1;
            this.tabIndexRegistration.Text = "Registration";
            this.tabIndexRegistration.UseVisualStyleBackColor = true;
            // 
            // btnIndexRegistration
            // 
            this.btnIndexRegistration.Enabled = false;
            this.btnIndexRegistration.Location = new System.Drawing.Point(214, 452);
            this.btnIndexRegistration.Name = "btnIndexRegistration";
            this.btnIndexRegistration.Size = new System.Drawing.Size(150, 35);
            this.btnIndexRegistration.TabIndex = 27;
            this.btnIndexRegistration.Text = "Register";
            this.btnIndexRegistration.UseVisualStyleBackColor = true;
            this.btnIndexRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // errMsgIndexRegPhone
            // 
            this.errMsgIndexRegPhone.AutoSize = true;
            this.errMsgIndexRegPhone.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexRegPhone.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexRegPhone.Location = new System.Drawing.Point(210, 188);
            this.errMsgIndexRegPhone.Name = "errMsgIndexRegPhone";
            this.errMsgIndexRegPhone.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexRegPhone.TabIndex = 26;
            // 
            // tbIndexRegPhone
            // 
            this.tbIndexRegPhone.Location = new System.Drawing.Point(214, 157);
            this.tbIndexRegPhone.Name = "tbIndexRegPhone";
            this.tbIndexRegPhone.Size = new System.Drawing.Size(293, 28);
            this.tbIndexRegPhone.TabIndex = 3;
            this.tbIndexRegPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegPhone_KeyUp);
            // 
            // lbIndexRegPhone
            // 
            this.lbIndexRegPhone.AutoSize = true;
            this.lbIndexRegPhone.Location = new System.Drawing.Point(36, 164);
            this.lbIndexRegPhone.Name = "lbIndexRegPhone";
            this.lbIndexRegPhone.Size = new System.Drawing.Size(54, 21);
            this.lbIndexRegPhone.TabIndex = 24;
            this.lbIndexRegPhone.Text = "Phone";
            // 
            // errMsgIndexRegConfirmPassword
            // 
            this.errMsgIndexRegConfirmPassword.AutoSize = true;
            this.errMsgIndexRegConfirmPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexRegConfirmPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexRegConfirmPassword.Location = new System.Drawing.Point(210, 331);
            this.errMsgIndexRegConfirmPassword.Name = "errMsgIndexRegConfirmPassword";
            this.errMsgIndexRegConfirmPassword.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexRegConfirmPassword.TabIndex = 23;
            // 
            // tbIndexRegConfirmPassword
            // 
            this.tbIndexRegConfirmPassword.Location = new System.Drawing.Point(214, 300);
            this.tbIndexRegConfirmPassword.Name = "tbIndexRegConfirmPassword";
            this.tbIndexRegConfirmPassword.Size = new System.Drawing.Size(293, 28);
            this.tbIndexRegConfirmPassword.TabIndex = 5;
            this.tbIndexRegConfirmPassword.UseSystemPasswordChar = true;
            this.tbIndexRegConfirmPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegConfirmPassword_KeyUp);
            // 
            // lbIndexRegConfirmPassword
            // 
            this.lbIndexRegConfirmPassword.AutoSize = true;
            this.lbIndexRegConfirmPassword.Location = new System.Drawing.Point(36, 307);
            this.lbIndexRegConfirmPassword.Name = "lbIndexRegConfirmPassword";
            this.lbIndexRegConfirmPassword.Size = new System.Drawing.Size(137, 21);
            this.lbIndexRegConfirmPassword.TabIndex = 22;
            this.lbIndexRegConfirmPassword.Text = "Confirm Password";
            // 
            // errMsgIndexRegName
            // 
            this.errMsgIndexRegName.AutoSize = true;
            this.errMsgIndexRegName.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexRegName.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexRegName.Location = new System.Drawing.Point(210, 48);
            this.errMsgIndexRegName.Name = "errMsgIndexRegName";
            this.errMsgIndexRegName.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexRegName.TabIndex = 20;
            // 
            // tbIndexRegName
            // 
            this.tbIndexRegName.Location = new System.Drawing.Point(214, 17);
            this.tbIndexRegName.Name = "tbIndexRegName";
            this.tbIndexRegName.Size = new System.Drawing.Size(293, 28);
            this.tbIndexRegName.TabIndex = 1;
            this.tbIndexRegName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegName_KeyUp);
            // 
            // lbIndexRegName
            // 
            this.lbIndexRegName.AutoSize = true;
            this.lbIndexRegName.Location = new System.Drawing.Point(36, 24);
            this.lbIndexRegName.Name = "lbIndexRegName";
            this.lbIndexRegName.Size = new System.Drawing.Size(51, 21);
            this.lbIndexRegName.TabIndex = 18;
            this.lbIndexRegName.Text = "Name";
            // 
            // lbIndexRegUserType
            // 
            this.lbIndexRegUserType.AutoSize = true;
            this.lbIndexRegUserType.Location = new System.Drawing.Point(35, 395);
            this.lbIndexRegUserType.Name = "lbIndexRegUserType";
            this.lbIndexRegUserType.Size = new System.Drawing.Size(78, 21);
            this.lbIndexRegUserType.TabIndex = 17;
            this.lbIndexRegUserType.Text = "User Type";
            // 
            // errMsgIndexRegPassword
            // 
            this.errMsgIndexRegPassword.AutoSize = true;
            this.errMsgIndexRegPassword.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexRegPassword.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexRegPassword.Location = new System.Drawing.Point(210, 260);
            this.errMsgIndexRegPassword.Name = "errMsgIndexRegPassword";
            this.errMsgIndexRegPassword.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexRegPassword.TabIndex = 16;
            // 
            // errMsgIndexRegEmail
            // 
            this.errMsgIndexRegEmail.AutoSize = true;
            this.errMsgIndexRegEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgIndexRegEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgIndexRegEmail.Location = new System.Drawing.Point(210, 118);
            this.errMsgIndexRegEmail.Name = "errMsgIndexRegEmail";
            this.errMsgIndexRegEmail.Size = new System.Drawing.Size(0, 19);
            this.errMsgIndexRegEmail.TabIndex = 15;
            // 
            // gbIndexRegUserType
            // 
            this.gbIndexRegUserType.Controls.Add(this.rbIndexRegRenter);
            this.gbIndexRegUserType.Controls.Add(this.rbIndexRegTenant);
            this.gbIndexRegUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbIndexRegUserType.Location = new System.Drawing.Point(214, 371);
            this.gbIndexRegUserType.Name = "gbIndexRegUserType";
            this.gbIndexRegUserType.Size = new System.Drawing.Size(293, 58);
            this.gbIndexRegUserType.TabIndex = 14;
            this.gbIndexRegUserType.TabStop = false;
            // 
            // rbIndexRegRenter
            // 
            this.rbIndexRegRenter.AutoSize = true;
            this.rbIndexRegRenter.Location = new System.Drawing.Point(179, 20);
            this.rbIndexRegRenter.Name = "rbIndexRegRenter";
            this.rbIndexRegRenter.Size = new System.Drawing.Size(77, 25);
            this.rbIndexRegRenter.TabIndex = 7;
            this.rbIndexRegRenter.Text = "Renter";
            this.rbIndexRegRenter.UseVisualStyleBackColor = true;
            // 
            // rbIndexRegTenant
            // 
            this.rbIndexRegTenant.AutoSize = true;
            this.rbIndexRegTenant.Checked = true;
            this.rbIndexRegTenant.Location = new System.Drawing.Point(7, 20);
            this.rbIndexRegTenant.Name = "rbIndexRegTenant";
            this.rbIndexRegTenant.Size = new System.Drawing.Size(86, 25);
            this.rbIndexRegTenant.TabIndex = 6;
            this.rbIndexRegTenant.TabStop = true;
            this.rbIndexRegTenant.Text = "Student";
            this.rbIndexRegTenant.UseVisualStyleBackColor = true;
            // 
            // tbIndexRegPassword
            // 
            this.tbIndexRegPassword.Location = new System.Drawing.Point(214, 229);
            this.tbIndexRegPassword.Name = "tbIndexRegPassword";
            this.tbIndexRegPassword.Size = new System.Drawing.Size(293, 28);
            this.tbIndexRegPassword.TabIndex = 4;
            this.tbIndexRegPassword.UseSystemPasswordChar = true;
            this.tbIndexRegPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegPassword_KeyUp);
            // 
            // lbIndexRegPassword
            // 
            this.lbIndexRegPassword.AutoSize = true;
            this.lbIndexRegPassword.Location = new System.Drawing.Point(36, 236);
            this.lbIndexRegPassword.Name = "lbIndexRegPassword";
            this.lbIndexRegPassword.Size = new System.Drawing.Size(77, 21);
            this.lbIndexRegPassword.TabIndex = 13;
            this.lbIndexRegPassword.Text = "Password";
            // 
            // tbIndexRegEmail
            // 
            this.tbIndexRegEmail.Location = new System.Drawing.Point(214, 87);
            this.tbIndexRegEmail.Name = "tbIndexRegEmail";
            this.tbIndexRegEmail.Size = new System.Drawing.Size(293, 28);
            this.tbIndexRegEmail.TabIndex = 2;
            this.tbIndexRegEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRegEmail_KeyUp);
            // 
            // lbIndexRegEmail
            // 
            this.lbIndexRegEmail.AutoSize = true;
            this.lbIndexRegEmail.Location = new System.Drawing.Point(36, 94);
            this.lbIndexRegEmail.Name = "lbIndexRegEmail";
            this.lbIndexRegEmail.Size = new System.Drawing.Size(48, 21);
            this.lbIndexRegEmail.TabIndex = 10;
            this.lbIndexRegEmail.Text = "Email";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControlIndex);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "IndexForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Management System For AIUB Students";
            this.tabControlIndex.ResumeLayout(false);
            this.tabIndexLogin.ResumeLayout(false);
            this.tabIndexLogin.PerformLayout();
            this.gbIndexLoginUserType.ResumeLayout(false);
            this.gbIndexLoginUserType.PerformLayout();
            this.tabIndexRegistration.ResumeLayout(false);
            this.tabIndexRegistration.PerformLayout();
            this.gbIndexRegUserType.ResumeLayout(false);
            this.gbIndexRegUserType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlIndex;
        private System.Windows.Forms.TabPage tabIndexLogin;
        private System.Windows.Forms.TabPage tabIndexRegistration;
        private System.Windows.Forms.Label lbIndexLoginEmail;
        private System.Windows.Forms.TextBox tbIndexLoginPassword;
        private System.Windows.Forms.Label lbIndexLoginPassword;
        private System.Windows.Forms.TextBox tbIndexLoginEmail;
        private System.Windows.Forms.Button btnIndexLogin;
        private System.Windows.Forms.GroupBox gbIndexLoginUserType;
        private System.Windows.Forms.RadioButton rbIndexLoginRenter;
        private System.Windows.Forms.RadioButton rbIndexLoginTenant;
        private System.Windows.Forms.Label errMsgIndexLoginEmail;
        private System.Windows.Forms.Label errMsgIndexLoginPassword;
        private System.Windows.Forms.Label lbIndexLoginUserType;
        private System.Windows.Forms.Label errMsgIndexRegConfirmPassword;
        private System.Windows.Forms.TextBox tbIndexRegConfirmPassword;
        private System.Windows.Forms.Label lbIndexRegConfirmPassword;
        private System.Windows.Forms.Label errMsgIndexRegName;
        private System.Windows.Forms.TextBox tbIndexRegName;
        private System.Windows.Forms.Label lbIndexRegName;
        private System.Windows.Forms.Label lbIndexRegUserType;
        private System.Windows.Forms.Label errMsgIndexRegPassword;
        private System.Windows.Forms.Label errMsgIndexRegEmail;
        private System.Windows.Forms.GroupBox gbIndexRegUserType;
        private System.Windows.Forms.RadioButton rbIndexRegRenter;
        private System.Windows.Forms.RadioButton rbIndexRegTenant;
        private System.Windows.Forms.TextBox tbIndexRegPassword;
        private System.Windows.Forms.Label lbIndexRegPassword;
        private System.Windows.Forms.TextBox tbIndexRegEmail;
        private System.Windows.Forms.Label lbIndexRegEmail;
        private System.Windows.Forms.Label errMsgIndexRegPhone;
        private System.Windows.Forms.TextBox tbIndexRegPhone;
        private System.Windows.Forms.Label lbIndexRegPhone;
        private System.Windows.Forms.RadioButton rbIndexLoginAdmin;
        private System.Windows.Forms.Button btnIndexRegistration;
    }
}