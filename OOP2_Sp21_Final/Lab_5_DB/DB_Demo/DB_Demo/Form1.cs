using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string userName = textBox_UserName.Text.Trim();
            string userType = comboBox_userType.Text.Trim();
            User newUser = new User(userName, userType);
            bool isAdded = newUser.add();
            if (isAdded) MessageBox.Show("User Added");
            else MessageBox.Show("User is not Added");
            dataGridView_users.DataSource = User.load();
            textBox_UserName.Text = "";
            comboBox_userType.Text = "SELECT TYPE";
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            dataGridView_users.DataSource = User.load();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView_users.DataSource = User.load();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(textBox_userID.Text.Trim());
            User user = User.search(id);
            if (user.userName != null)
            {
                textBox_UserName.Text = user.userName.Trim();
                comboBox_userType.SelectedIndex = comboBox_userType.FindStringExact(user.userType.ToUpper().Trim());
            }
            else
            {
                MessageBox.Show("Couldn't find the User.");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(textBox_userID.Text.Trim());
            if (User.delete(id)) MessageBox.Show("User Deleted");
            else MessageBox.Show("User is not Deleted");
            dataGridView_users.DataSource = User.load();
            textBox_UserName.Text = "";
            comboBox_userType.Text = "SELECT TYPE";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(textBox_userID.Text.Trim());
            string userName = textBox_UserName.Text.Trim();
            string userType = comboBox_userType.Text.Trim();
            User newUser = new User(id, userName, userType);
            if (newUser.update()) MessageBox.Show("User Updated");
            else MessageBox.Show("User is not Updated");
            dataGridView_users.DataSource = User.load();
        }

        private void dataGridView_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView_users.Rows[e.RowIndex].Cells[0].Value.ToString();
            string name = dataGridView_users.Rows[e.RowIndex].Cells[1].Value.ToString();
            string type = dataGridView_users.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox_userID.Text = id;
            textBox_UserName.Text = name;
            comboBox_userType.SelectedIndex = comboBox_userType.FindStringExact(type.ToUpper().Trim());
        }
    }
}
