
namespace SomerenUI
{
    partial class Login
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
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.lnkLblPassword = new System.Windows.Forms.LinkLabel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPW = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblLoginPW = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.AutoSize = true;
            this.linkLabelRegister.Location = new System.Drawing.Point(335, 289);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(89, 13);
            this.linkLabelRegister.TabIndex = 16;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register Account";
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_LinkClicked);
            // 
            // lnkLblPassword
            // 
            this.lnkLblPassword.AutoSize = true;
            this.lnkLblPassword.Location = new System.Drawing.Point(335, 173);
            this.lnkLblPassword.Name = "lnkLblPassword";
            this.lnkLblPassword.Size = new System.Drawing.Size(92, 13);
            this.lnkLblPassword.TabIndex = 15;
            this.lnkLblPassword.TabStop = true;
            this.lnkLblPassword.Text = "Forgot Password?";
            this.lnkLblPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblPassword_LinkClicked);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(196, 67);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(40, 13);
            this.lblLogin.TabIndex = 14;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 263);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(415, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPW
            // 
            this.txtLoginPW.Location = new System.Drawing.Point(84, 150);
            this.txtLoginPW.Name = "txtLoginPW";
            this.txtLoginPW.PasswordChar = '*';
            this.txtLoginPW.Size = new System.Drawing.Size(343, 20);
            this.txtLoginPW.TabIndex = 12;
            this.txtLoginPW.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(81, 94);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(343, 20);
            this.txtLoginUsername.TabIndex = 11;
            // 
            // lblLoginPW
            // 
            this.lblLoginPW.AutoSize = true;
            this.lblLoginPW.Location = new System.Drawing.Point(12, 153);
            this.lblLoginPW.Name = "lblLoginPW";
            this.lblLoginPW.Size = new System.Drawing.Size(53, 13);
            this.lblLoginPW.TabIndex = 10;
            this.lblLoginPW.Text = "Password";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(12, 97);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(55, 13);
            this.lblLoginUsername.TabIndex = 9;
            this.lblLoginUsername.Text = "Username";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(146, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 33);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "SOMEREN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 311);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.lnkLblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtLoginPW);
            this.Controls.Add(this.txtLoginUsername);
            this.Controls.Add(this.lblLoginPW);
            this.Controls.Add(this.lblLoginUsername);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelRegister;
        private System.Windows.Forms.LinkLabel lnkLblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPW;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblLoginPW;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblTitle;
    }
}