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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            Register_user.Dock = DockStyle.Fill;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserService service = new UserService();

            if (user.licenseKey == txt_licensekey.Text)
            {
                user.Name = txt_name.Text;
                user.email = txt_username.Text;
                user.password = txt_password.Text;

                if (User.CorrectPasswordFormat(user.password))
                    service.AddUser(user);
                else
                    MessageBox.Show("Password is not in correct format");
            }
            else
                MessageBox.Show("Incorrect license key!");
        }
    }
}
