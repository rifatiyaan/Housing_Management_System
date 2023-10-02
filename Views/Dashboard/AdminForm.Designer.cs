namespace HousingManagementSystemForAIUBStudents.Views.Dashboard
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabAdminSearchUser = new System.Windows.Forms.TabPage();
            this.errMsgAdminSearchUserEmail = new System.Windows.Forms.Label();
            this.tbAdminSearchUserEmail = new System.Windows.Forms.TextBox();
            this.lbAdminSearchUserEmail = new System.Windows.Forms.Label();
            this.lbAdminSearchUserType = new System.Windows.Forms.Label();
            this.btnAdminSearchUser = new System.Windows.Forms.Button();
            this.gbAdminSearchUserType = new System.Windows.Forms.GroupBox();
            this.rbAdminSearchUserRenter = new System.Windows.Forms.RadioButton();
            this.rbAdminSearchUserTenant = new System.Windows.Forms.RadioButton();
            this.tabAdminDeleteUser = new System.Windows.Forms.TabPage();
            this.actionMsgAdminDeleteUser = new System.Windows.Forms.Label();
            this.errMsgAdminDeleteUserEmail = new System.Windows.Forms.Label();
            this.tbAdminDeleteUserEmail = new System.Windows.Forms.TextBox();
            this.lbAdminDeleteUserEmail = new System.Windows.Forms.Label();
            this.lbAdminDeleteUserType = new System.Windows.Forms.Label();
            this.btnAdminDeleteUser = new System.Windows.Forms.Button();
            this.gbAdminDeleteUserType = new System.Windows.Forms.GroupBox();
            this.rbAdminDeleteUserRenter = new System.Windows.Forms.RadioButton();
            this.rbAdminDeleteUserTenant = new System.Windows.Forms.RadioButton();
            this.rtbAdminSearchUser = new System.Windows.Forms.RichTextBox();
            this.tabControlAdmin.SuspendLayout();
            this.tabAdminSearchUser.SuspendLayout();
            this.gbAdminSearchUserType.SuspendLayout();
            this.tabAdminDeleteUser.SuspendLayout();
            this.gbAdminDeleteUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabAdminSearchUser);
            this.tabControlAdmin.Controls.Add(this.tabAdminDeleteUser);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Location = new System.Drawing.Point(4, 4);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(776, 553);
            this.tabControlAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlAdmin.TabIndex = 0;
            this.tabControlAdmin.TabStop = false;
            // 
            // tabAdminSearchUser
            // 
            this.tabAdminSearchUser.Controls.Add(this.rtbAdminSearchUser);
            this.tabAdminSearchUser.Controls.Add(this.errMsgAdminSearchUserEmail);
            this.tabAdminSearchUser.Controls.Add(this.tbAdminSearchUserEmail);
            this.tabAdminSearchUser.Controls.Add(this.lbAdminSearchUserEmail);
            this.tabAdminSearchUser.Controls.Add(this.lbAdminSearchUserType);
            this.tabAdminSearchUser.Controls.Add(this.btnAdminSearchUser);
            this.tabAdminSearchUser.Controls.Add(this.gbAdminSearchUserType);
            this.tabAdminSearchUser.Location = new System.Drawing.Point(4, 26);
            this.tabAdminSearchUser.Name = "tabAdminSearchUser";
            this.tabAdminSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminSearchUser.Size = new System.Drawing.Size(768, 523);
            this.tabAdminSearchUser.TabIndex = 0;
            this.tabAdminSearchUser.Text = "Search User";
            this.tabAdminSearchUser.UseVisualStyleBackColor = true;
            // 
            // errMsgAdminSearchUserEmail
            // 
            this.errMsgAdminSearchUserEmail.AutoSize = true;
            this.errMsgAdminSearchUserEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAdminSearchUserEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgAdminSearchUserEmail.Location = new System.Drawing.Point(155, 70);
            this.errMsgAdminSearchUserEmail.Name = "errMsgAdminSearchUserEmail";
            this.errMsgAdminSearchUserEmail.Size = new System.Drawing.Size(0, 15);
            this.errMsgAdminSearchUserEmail.TabIndex = 15;
            // 
            // tbAdminSearchUserEmail
            // 
            this.tbAdminSearchUserEmail.Location = new System.Drawing.Point(159, 39);
            this.tbAdminSearchUserEmail.Name = "tbAdminSearchUserEmail";
            this.tbAdminSearchUserEmail.Size = new System.Drawing.Size(293, 24);
            this.tbAdminSearchUserEmail.TabIndex = 1;
            this.tbAdminSearchUserEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchUserEmail_KeyUp);
            // 
            // lbAdminSearchUserEmail
            // 
            this.lbAdminSearchUserEmail.AutoSize = true;
            this.lbAdminSearchUserEmail.Location = new System.Drawing.Point(28, 46);
            this.lbAdminSearchUserEmail.Name = "lbAdminSearchUserEmail";
            this.lbAdminSearchUserEmail.Size = new System.Drawing.Size(39, 17);
            this.lbAdminSearchUserEmail.TabIndex = 13;
            this.lbAdminSearchUserEmail.Text = "Email";
            // 
            // lbAdminSearchUserType
            // 
            this.lbAdminSearchUserType.AutoSize = true;
            this.lbAdminSearchUserType.Location = new System.Drawing.Point(28, 137);
            this.lbAdminSearchUserType.Name = "lbAdminSearchUserType";
            this.lbAdminSearchUserType.Size = new System.Drawing.Size(63, 17);
            this.lbAdminSearchUserType.TabIndex = 12;
            this.lbAdminSearchUserType.Text = "User Type";
            // 
            // btnAdminSearchUser
            // 
            this.btnAdminSearchUser.Enabled = false;
            this.btnAdminSearchUser.Location = new System.Drawing.Point(544, 32);
            this.btnAdminSearchUser.Name = "btnAdminSearchUser";
            this.btnAdminSearchUser.Size = new System.Drawing.Size(150, 35);
            this.btnAdminSearchUser.TabIndex = 5;
            this.btnAdminSearchUser.Text = "Search";
            this.btnAdminSearchUser.UseVisualStyleBackColor = true;
            this.btnAdminSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // gbAdminSearchUserType
            // 
            this.gbAdminSearchUserType.Controls.Add(this.rbAdminSearchUserRenter);
            this.gbAdminSearchUserType.Controls.Add(this.rbAdminSearchUserTenant);
            this.gbAdminSearchUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbAdminSearchUserType.Location = new System.Drawing.Point(159, 113);
            this.gbAdminSearchUserType.Name = "gbAdminSearchUserType";
            this.gbAdminSearchUserType.Size = new System.Drawing.Size(269, 58);
            this.gbAdminSearchUserType.TabIndex = 2;
            this.gbAdminSearchUserType.TabStop = false;
            // 
            // rbAdminSearchUserRenter
            // 
            this.rbAdminSearchUserRenter.AutoSize = true;
            this.rbAdminSearchUserRenter.Location = new System.Drawing.Point(179, 20);
            this.rbAdminSearchUserRenter.Name = "rbAdminSearchUserRenter";
            this.rbAdminSearchUserRenter.Size = new System.Drawing.Size(65, 21);
            this.rbAdminSearchUserRenter.TabIndex = 4;
            this.rbAdminSearchUserRenter.Text = "Renter";
            this.rbAdminSearchUserRenter.UseVisualStyleBackColor = true;
            // 
            // rbAdminSearchUserTenant
            // 
            this.rbAdminSearchUserTenant.AutoSize = true;
            this.rbAdminSearchUserTenant.Checked = true;
            this.rbAdminSearchUserTenant.Location = new System.Drawing.Point(7, 20);
            this.rbAdminSearchUserTenant.Name = "rbAdminSearchUserTenant";
            this.rbAdminSearchUserTenant.Size = new System.Drawing.Size(70, 21);
            this.rbAdminSearchUserTenant.TabIndex = 3;
            this.rbAdminSearchUserTenant.TabStop = true;
            this.rbAdminSearchUserTenant.Text = "Student";
            this.rbAdminSearchUserTenant.UseVisualStyleBackColor = true;
            // 
            // tabAdminDeleteUser
            // 
            this.tabAdminDeleteUser.Controls.Add(this.actionMsgAdminDeleteUser);
            this.tabAdminDeleteUser.Controls.Add(this.errMsgAdminDeleteUserEmail);
            this.tabAdminDeleteUser.Controls.Add(this.tbAdminDeleteUserEmail);
            this.tabAdminDeleteUser.Controls.Add(this.lbAdminDeleteUserEmail);
            this.tabAdminDeleteUser.Controls.Add(this.lbAdminDeleteUserType);
            this.tabAdminDeleteUser.Controls.Add(this.btnAdminDeleteUser);
            this.tabAdminDeleteUser.Controls.Add(this.gbAdminDeleteUserType);
            this.tabAdminDeleteUser.Location = new System.Drawing.Point(4, 26);
            this.tabAdminDeleteUser.Name = "tabAdminDeleteUser";
            this.tabAdminDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminDeleteUser.Size = new System.Drawing.Size(766, 515);
            this.tabAdminDeleteUser.TabIndex = 1;
            this.tabAdminDeleteUser.Text = "Delete User";
            this.tabAdminDeleteUser.UseVisualStyleBackColor = true;
            // 
            // actionMsgAdminDeleteUser
            // 
            this.actionMsgAdminDeleteUser.AutoSize = true;
            this.actionMsgAdminDeleteUser.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionMsgAdminDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.actionMsgAdminDeleteUser.Location = new System.Drawing.Point(215, 211);
            this.actionMsgAdminDeleteUser.Name = "actionMsgAdminDeleteUser";
            this.actionMsgAdminDeleteUser.Size = new System.Drawing.Size(149, 23);
            this.actionMsgAdminDeleteUser.TabIndex = 22;
            this.actionMsgAdminDeleteUser.Text = "User Not Found!!!";
            this.actionMsgAdminDeleteUser.Visible = false;
            // 
            // errMsgAdminDeleteUserEmail
            // 
            this.errMsgAdminDeleteUserEmail.AutoSize = true;
            this.errMsgAdminDeleteUserEmail.Font = new System.Drawing.Font("Calibri", 9.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errMsgAdminDeleteUserEmail.ForeColor = System.Drawing.Color.Red;
            this.errMsgAdminDeleteUserEmail.Location = new System.Drawing.Point(155, 70);
            this.errMsgAdminDeleteUserEmail.Name = "errMsgAdminDeleteUserEmail";
            this.errMsgAdminDeleteUserEmail.Size = new System.Drawing.Size(0, 15);
            this.errMsgAdminDeleteUserEmail.TabIndex = 21;
            // 
            // tbAdminDeleteUserEmail
            // 
            this.tbAdminDeleteUserEmail.Location = new System.Drawing.Point(159, 39);
            this.tbAdminDeleteUserEmail.Name = "tbAdminDeleteUserEmail";
            this.tbAdminDeleteUserEmail.Size = new System.Drawing.Size(293, 24);
            this.tbAdminDeleteUserEmail.TabIndex = 16;
            this.tbAdminDeleteUserEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDeleteUserEmail_KeyUp);
            // 
            // lbAdminDeleteUserEmail
            // 
            this.lbAdminDeleteUserEmail.AutoSize = true;
            this.lbAdminDeleteUserEmail.Location = new System.Drawing.Point(28, 46);
            this.lbAdminDeleteUserEmail.Name = "lbAdminDeleteUserEmail";
            this.lbAdminDeleteUserEmail.Size = new System.Drawing.Size(39, 17);
            this.lbAdminDeleteUserEmail.TabIndex = 20;
            this.lbAdminDeleteUserEmail.Text = "Email";
            // 
            // lbAdminDeleteUserType
            // 
            this.lbAdminDeleteUserType.AutoSize = true;
            this.lbAdminDeleteUserType.Location = new System.Drawing.Point(28, 137);
            this.lbAdminDeleteUserType.Name = "lbAdminDeleteUserType";
            this.lbAdminDeleteUserType.Size = new System.Drawing.Size(63, 17);
            this.lbAdminDeleteUserType.TabIndex = 19;
            this.lbAdminDeleteUserType.Text = "User Type";
            // 
            // btnAdminDeleteUser
            // 
            this.btnAdminDeleteUser.Enabled = false;
            this.btnAdminDeleteUser.Location = new System.Drawing.Point(544, 32);
            this.btnAdminDeleteUser.Name = "btnAdminDeleteUser";
            this.btnAdminDeleteUser.Size = new System.Drawing.Size(150, 35);
            this.btnAdminDeleteUser.TabIndex = 18;
            this.btnAdminDeleteUser.Text = "Delete";
            this.btnAdminDeleteUser.UseVisualStyleBackColor = true;
            this.btnAdminDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // gbAdminDeleteUserType
            // 
            this.gbAdminDeleteUserType.Controls.Add(this.rbAdminDeleteUserRenter);
            this.gbAdminDeleteUserType.Controls.Add(this.rbAdminDeleteUserTenant);
            this.gbAdminDeleteUserType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbAdminDeleteUserType.Location = new System.Drawing.Point(159, 113);
            this.gbAdminDeleteUserType.Name = "gbAdminDeleteUserType";
            this.gbAdminDeleteUserType.Size = new System.Drawing.Size(269, 58);
            this.gbAdminDeleteUserType.TabIndex = 17;
            this.gbAdminDeleteUserType.TabStop = false;
            // 
            // rbAdminDeleteUserRenter
            // 
            this.rbAdminDeleteUserRenter.AutoSize = true;
            this.rbAdminDeleteUserRenter.Location = new System.Drawing.Point(179, 20);
            this.rbAdminDeleteUserRenter.Name = "rbAdminDeleteUserRenter";
            this.rbAdminDeleteUserRenter.Size = new System.Drawing.Size(65, 21);
            this.rbAdminDeleteUserRenter.TabIndex = 4;
            this.rbAdminDeleteUserRenter.Text = "Renter";
            this.rbAdminDeleteUserRenter.UseVisualStyleBackColor = true;
            // 
            // rbAdminDeleteUserTenant
            // 
            this.rbAdminDeleteUserTenant.AutoSize = true;
            this.rbAdminDeleteUserTenant.Checked = true;
            this.rbAdminDeleteUserTenant.Location = new System.Drawing.Point(7, 20);
            this.rbAdminDeleteUserTenant.Name = "rbAdminDeleteUserTenant";
            this.rbAdminDeleteUserTenant.Size = new System.Drawing.Size(70, 21);
            this.rbAdminDeleteUserTenant.TabIndex = 3;
            this.rbAdminDeleteUserTenant.TabStop = true;
            this.rbAdminDeleteUserTenant.Text = "Student";
            this.rbAdminDeleteUserTenant.UseVisualStyleBackColor = true;
            // 
            // rtbAdminSearchUser
            // 
            this.rtbAdminSearchUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbAdminSearchUser.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAdminSearchUser.Location = new System.Drawing.Point(3, 193);
            this.rtbAdminSearchUser.Name = "rtbAdminSearchUser";
            this.rtbAdminSearchUser.Size = new System.Drawing.Size(762, 327);
            this.rtbAdminSearchUser.TabIndex = 16;
            this.rtbAdminSearchUser.Text = "";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControlAdmin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashbord | House Management System For AIUB Students";
            this.tabControlAdmin.ResumeLayout(false);
            this.tabAdminSearchUser.ResumeLayout(false);
            this.tabAdminSearchUser.PerformLayout();
            this.gbAdminSearchUserType.ResumeLayout(false);
            this.gbAdminSearchUserType.PerformLayout();
            this.tabAdminDeleteUser.ResumeLayout(false);
            this.tabAdminDeleteUser.PerformLayout();
            this.gbAdminDeleteUserType.ResumeLayout(false);
            this.gbAdminDeleteUserType.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabAdminSearchUser;
        private System.Windows.Forms.TabPage tabAdminDeleteUser;
        private System.Windows.Forms.Label lbAdminSearchUserType;
        private System.Windows.Forms.Button btnAdminSearchUser;
        private System.Windows.Forms.GroupBox gbAdminSearchUserType;
        private System.Windows.Forms.RadioButton rbAdminSearchUserRenter;
        private System.Windows.Forms.RadioButton rbAdminSearchUserTenant;
        private System.Windows.Forms.Label errMsgAdminSearchUserEmail;
        private System.Windows.Forms.TextBox tbAdminSearchUserEmail;
        private System.Windows.Forms.Label lbAdminSearchUserEmail;
        private System.Windows.Forms.Label errMsgAdminDeleteUserEmail;
        private System.Windows.Forms.TextBox tbAdminDeleteUserEmail;
        private System.Windows.Forms.Label lbAdminDeleteUserEmail;
        private System.Windows.Forms.Label lbAdminDeleteUserType;
        private System.Windows.Forms.Button btnAdminDeleteUser;
        private System.Windows.Forms.GroupBox gbAdminDeleteUserType;
        private System.Windows.Forms.RadioButton rbAdminDeleteUserRenter;
        private System.Windows.Forms.RadioButton rbAdminDeleteUserTenant;
        private System.Windows.Forms.Label actionMsgAdminDeleteUser;
        private System.Windows.Forms.RichTextBox rtbAdminSearchUser;
    }
}