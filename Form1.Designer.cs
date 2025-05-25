namespace Salon_Appointment_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(1039, 221);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(255, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1039, 294);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Client",
            "Stylist",
            "Receptionist"});
            this.cmbUserType.Location = new System.Drawing.Point(1039, 360);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(255, 24);
            this.cmbUserType.TabIndex = 2;
            this.cmbUserType.Text = "*Please select the type of user you are*";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(908, 221);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(914, 300);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(942, 363);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(1219, 475);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Location = new System.Drawing.Point(934, 422);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(50, 16);
            this.lblStaffId.TabIndex = 8;
            this.lblStaffId.Text = "Staff Id:";
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(1039, 422);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.Size = new System.Drawing.Size(255, 22);
            this.txtStaffId.TabIndex = 9;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1348, 739);
            this.Controls.Add(this.txtStaffId);
            this.Controls.Add(this.lblStaffId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.TextBox txtStaffId;
    }
}

