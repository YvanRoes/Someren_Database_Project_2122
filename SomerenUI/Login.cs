using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;
namespace SomerenUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();

        }

        private void lnkLblPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordReset passwordReset = new PasswordReset();
            passwordReset.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            User credentials = new User()
            {
                email = txtLoginUsername.Text,
                password = txtLoginPW.Text
            };

            //3 main outcomes:
            //succesful login
            //wrong PW
            //Invalid Account
            try
            {
                if (userService.LogUserIn(credentials))
                {
                    //Show UI
                    SomerenUI somerenUI = new SomerenUI();
                    somerenUI.Show();
                    Login login = new Login();
                    login.Close();
                }
                else throw new Exception("Invalid Username or Password!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
}



