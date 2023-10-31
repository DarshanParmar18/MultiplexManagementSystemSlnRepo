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
    public partial class viewStaff : Form
    {
        public viewStaff()
        {
            InitializeComponent();
        }

        private void viewStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.StaffTB' table. You can move, or remove it, as needed.
            this.staffTBTableAdapter.Fill(this.databaseCustandMovieDataSet.StaffTB);
            // TODO: This line of code loads data into the 'empDBDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.empDBDataSet1.Employees);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(SearchTxtbox.Text))
            {
                dataGridView1.DataSource = staffTBBindingSource;
            }
            else
            {
                var query = from o in this.databaseCustandMovieDataSet.StaffTB
                            where o.firstName.Contains(SearchTxtbox.Text) || o.lastName.Contains(SearchTxtbox.Text) || o.email == SearchTxtbox.Text || o.address == SearchTxtbox.Text || o.salary == SearchTxtbox.Text || o.roles.Contains(SearchTxtbox.Text) || o.ID.Equals(SearchTxtbox.Text)
                            select o;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //DashboardForm dashboard = new DashboardForm();
            //dashboard.Show();
            this.Hide();
        }
    }
}
