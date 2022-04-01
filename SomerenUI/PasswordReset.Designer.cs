
namespace SomerenUI
{
    partial class PasswordReset
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.btnConfirmUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.gbSec = new System.Windows.Forms.GroupBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbUser.SuspendLayout();
            this.gbSec.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(20, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(157, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // cbQuestion
            // 
            this.cbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Items.AddRange(new object[] {
            "What is the first country you visited?",
            "What was/is the name of your first pet?",
            "What is the name of the first school you went to?"});
            this.cbQuestion.Location = new System.Drawing.Point(20, 30);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(297, 21);
            this.cbQuestion.TabIndex = 1;
            // 
            // btnConfirmUser
            // 
            this.btnConfirmUser.Location = new System.Drawing.Point(194, 47);
            this.btnConfirmUser.Name = "btnConfirmUser";
            this.btnConfirmUser.Size = new System.Drawing.Size(123, 23);
            this.btnConfirmUser.TabIndex = 2;
            this.btnConfirmUser.Text = "confirm";
            this.btnConfirmUser.UseVisualStyleBackColor = true;
            this.btnConfirmUser.Click += new System.EventHandler(this.btnConfirmUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your username:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(20, 68);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(23, 85);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(154, 20);
            this.txtAnswer.TabIndex = 6;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.label1);
            this.gbUser.Controls.Add(this.txtUsername);
            this.gbUser.Controls.Add(this.btnConfirmUser);
            this.gbUser.Location = new System.Drawing.Point(119, 54);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(341, 100);
            this.gbUser.TabIndex = 7;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // gbSec
            // 
            this.gbSec.Controls.Add(this.btnCheckAnswer);
            this.gbSec.Controls.Add(this.cbQuestion);
            this.gbSec.Controls.Add(this.txtAnswer);
            this.gbSec.Controls.Add(this.lblAnswer);
            this.gbSec.Location = new System.Drawing.Point(119, 160);
            this.gbSec.Name = "gbSec";
            this.gbSec.Size = new System.Drawing.Size(341, 131);
            this.gbSec.TabIndex = 8;
            this.gbSec.TabStop = false;
            this.gbSec.Text = "Security Question";
            this.gbSec.Visible = false;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(194, 83);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(123, 23);
            this.btnCheckAnswer.TabIndex = 7;
            this.btnCheckAnswer.Text = "Check answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.label4);
            this.gbPassword.Controls.Add(this.txtPassword2);
            this.gbPassword.Controls.Add(this.btnPassword);
            this.gbPassword.Controls.Add(this.txtPassword1);
            this.gbPassword.Controls.Add(this.label2);
            this.gbPassword.Location = new System.Drawing.Point(119, 297);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(341, 127);
            this.gbPassword.TabIndex = 9;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            this.gbPassword.Visible = false;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(194, 98);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(123, 23);
            this.btnPassword.TabIndex = 7;
            this.btnPassword.Text = "Validate password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(23, 57);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(154, 20);
            this.txtPassword1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "New password: ";
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(20, 101);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(157, 20);
            this.txtPassword2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Re-enter password:";
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 555);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbSec);
            this.Controls.Add(this.gbUser);
            this.Name = "PasswordReset";
            this.Text = "Password Reset";
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.gbSec.ResumeLayout(false);
            this.gbSec.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.Button btnConfirmUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.GroupBox gbSec;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label2;
    }
}