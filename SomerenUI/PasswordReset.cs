using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenLogic;
using SomerenModel;

namespace SomerenUI
{
    public partial class PasswordReset : Form
    {
        public PasswordReset()
        {
            InitializeComponent();          
        }

        User user = new User();

        private void btnConfirmUser_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            try
            {
                user = service.GetRecorveryPasswordUser(txtUsername.Text);
            }
            catch (Exception) { MessageBox.Show("Incorrect username"); }
            


            if (user.email != null)
            {
                gbUser.Enabled = false;
                gbSec.Visible = true;
            }
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            if(btnCheckAnswer.Name == "btnCheckAnswer")
            {
                if (CorrectSecAnswer(cbQuestion.SelectedIndex, txtAnswer.Text))
                    gbSec.Enabled = false;
                gbPassword.Visible = true;
            }

            if(btnCheckAnswer.Name == "btnNewQnA")
            {
                UserService service = new UserService();
                int index = cbQuestion.SelectedIndex + 1;
                service.UpdateUserQnA(index, txtAnswer.Text, txtUsername.Text);
                MessageBox.Show("Security question and answer have been succesfully updated");
                ActiveForm.Close();
                ActiveForm.Close();
            }
            
        }

        private bool CorrectSecAnswer(int questionIndex, string answer)
        {
            if (questionIndex++ == user.SecretQuestionId && answer == user.SecretQuestionAnswer) return true; gbSec.Enabled = false;
            return false;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword1.Text == txtPassword2.Text)
            {
                try
                {
                    if (User.CorrectPasswordFormat(txtPassword1.Text))
                    {
                        UserService service = new UserService();
                        service.UpdateUserPassword(User.PasswordTosha256(txtPassword1.Text), txtUsername.Text);
                        gbPassword.Enabled = false;
                        

                        //Change Security question
                        string message = "Password has been modified.\nWould you like to change your security question?";
                        string title = "Change security question";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            gbPassword.Visible = false;
                            gbUser.Visible = false;
                            gbSec.Enabled = true;
                            gbSec.Text = "New security question";
                            lblAnswer.Text = "New answer:";
                            btnCheckAnswer.Text = "Confirm new question and answer";
                            btnCheckAnswer.Name = "btnNewQnA";
                        }
                        if (result == DialogResult.No) ActiveForm.Close();
                    }
                }
                catch (Exception) { MessageBox.Show("Password was not in correct format"); }                 
            }

            if (txtPassword1.Text != txtPassword2.Text) MessageBox.Show("Passwords do not match.");
        }

        
    }
}
