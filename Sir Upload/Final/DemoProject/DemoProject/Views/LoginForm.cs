using DemoProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = tBUsername.Text;
            string password = tBPassword.Text;
            var result = UserController.AuthenticateUser(username,password);
            if (result != null) {
                new DashboardForm().Show();
            }
            else
                MessageBox.Show("User Not Valid");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
