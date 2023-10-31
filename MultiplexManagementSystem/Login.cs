using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplexManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            emailTextBox.Focus();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "username" && passwordTextBox.Text == "password")
            {
                DashboardForm dashboardForm = new DashboardForm();
                dashboardForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Clear();
                passwordTextBox.Clear();

            }
        }
    }
}
