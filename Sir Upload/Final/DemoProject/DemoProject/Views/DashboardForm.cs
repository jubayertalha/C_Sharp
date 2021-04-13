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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            var ds = UserController.GetAllUsers();
            dGrid.DataSource = ds;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string username = tBSearch.Text;
            dynamic user = UserController.GetUser(username);
            if (user != null)
            {
                tBName.Text = user.Name;
                tBUsername.Text = user.Username;
                
            }
            else {
                tBName.Text = "";
                tBUsername.Text = "";
                MessageBox.Show("No user found");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var user = new
            {
                Name = tBName.Text,
                Username = tBUsername.Text,
            };
            bool result = UserController.UpdateUser(user);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else {
                MessageBox.Show("Could not Update");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var r = UserController.DeleteUser(tBUsername.Text);
            if (r) {
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
        }
    }
}
