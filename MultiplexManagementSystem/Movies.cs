using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MultiplexManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        DashboardForm dashboardForm;
        private void Movies_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            //lABEL 2
            label2.Parent = pictureBox1;
            //L3
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            //L4
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 


       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
