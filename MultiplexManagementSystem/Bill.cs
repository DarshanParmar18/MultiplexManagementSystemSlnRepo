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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseCustandMovieDataSet.MCDB' table. You can move, or remove it, as needed.
            this.mCDBTableAdapter.Fill(this.databaseCustandMovieDataSet.MCDB);
            mCDBBindingSource.DataSource = this.databaseCustandMovieDataSet.MCDB;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchTxtbox.Text))
            {
                dataGridView1.DataSource = mCDBBindingSource;
            }
            else
            {
                var query = from o in this.databaseCustandMovieDataSet.MCDB
                            where o.custName.Contains(SearchTxtbox.Text) || o.movieName.Contains(SearchTxtbox.Text) || o.total == SearchTxtbox.Text || o.paymentType == SearchTxtbox.Text 
                            select o;
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Visible = true;
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printBill printBill = new printBill();
            printBill.ShowDialog();
            //this.Close();
        }
    }
}
