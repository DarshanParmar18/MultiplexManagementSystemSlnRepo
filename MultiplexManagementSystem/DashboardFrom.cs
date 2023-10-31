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
    public partial class DashboardForm : Form
    {
        SalesForm sales;
        Home homepg;
        addStaff addStaffFrm;
        custDet addcustFrm;
        schedule scheduleFrm;
        addBooking addbookingFrm;
        viewStaff viewStaffFrm;
        Bill bill;
        Ticket ticket;
        public DashboardForm()
        {
            InitializeComponent();
        }
        bool menuEpand = false;
        bool menuEpand2 = false;

        private void MenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuEpand == false)
            {
                MenuContainer.Height += 5;
                if (MenuContainer.Height >= 120)
                {
                    MenuTransition.Stop();
                    menuEpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 5;
                if (MenuContainer.Height <= 50)
                {
                    MenuTransition.Stop();
                    menuEpand = false;
                }
            }
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            //MenuTransition.Start();
            //

            if (addStaffFrm == null)
            {
                addStaffFrm = new addStaff();
                addStaffFrm.FormClosed += AddStaff_FormClosed;
                addStaffFrm.MdiParent = this;
                addStaffFrm.Dock = DockStyle.Fill;
                addStaffFrm.Show();
            }
            else
            {
                addStaffFrm.Activate();
            }
        }
        private void AddStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            addStaffFrm = null;
        }



        //SideBar Transition
        bool sidebarExpand = true;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBarPanel.Width -= 10;
                if (SideBarPanel.Width <= 60)
                {
                    SideBarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                SideBarPanel.Width += 10;
                if (SideBarPanel.Width >= 200)
                {
                    SideBarTransition.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }




        //----------------Schedule Btn--------------------//
        private void Analysis_Click(object sender, EventArgs e)
        {
            if (scheduleFrm == null)
            {
                scheduleFrm = new schedule();
                scheduleFrm.FormClosed += Schedule_FormClosed;
                scheduleFrm.MdiParent = this;
                scheduleFrm.Dock = DockStyle.Fill;
                scheduleFrm.Show();
            }
            else
            {
                scheduleFrm.Activate();
            }
        }
        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            scheduleFrm = null;
        }




        //---------------Sales Btn--------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            if (sales == null)
            {
                sales = new SalesForm();
                sales.FormClosed += Dashboard_FormClosed;
                sales.MdiParent = this;
                sales.Dock = DockStyle.Fill;
                sales.Show();
            }
            else
            {
                sales.Activate();
            }
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            sales = null;
        }


        private void movieTransition_Tick(object sender, EventArgs e)
        {
            if (menuEpand2 == false)
            {
                flowLayoutPanel1.Height += 5;
                if (flowLayoutPanel1.Height >= 160)
                {
                    movieTransition.Stop();
                    menuEpand2 = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= 5;
                if (flowLayoutPanel1.Height <= 50)
                {
                    movieTransition.Stop();
                    menuEpand2 = false;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)//Movie button
        {

            // movieTransition.Start();
            //movies banner on homescreen will load with (Form2) Form
            if (homepg == null)
            {
                homepg = new Home();
                homepg.FormClosed += movies_FormClosed;
                homepg.MdiParent = this;
                homepg.Dock = DockStyle.Fill;
                homepg.Show();
            }
            else
            {
                homepg.Activate();
            }


        }



        //-----Main load form of this form------//
        private void DashboardForm_Load(object sender, EventArgs e)
        {

            //movies banner on homescreen will load with (Form2) Form
            if (homepg == null)
            {
                homepg = new Home();
                homepg.FormClosed += movies_FormClosed;
                homepg.MdiParent = this;
                homepg.Dock = DockStyle.Fill;
                homepg.Show();
            }
            else
            {
                homepg.Activate();
            }
        }
        // This event Function is useed in DashboardForm_Load
        private void movies_FormClosed(object sender, FormClosedEventArgs e)
        {
            homepg = null;
        }

        private void CustDtBtn_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
            if (addcustFrm == null)
            {
                addcustFrm = new custDet();
                addcustFrm.FormClosed += addCust_FormClosed;
                addcustFrm.MdiParent = this;
                addcustFrm.Dock = DockStyle.Fill;
                addcustFrm.Show();
            }
            else
            {
                addcustFrm.Activate();
            }
        }
        private void addCust_FormClosed(object sender, FormClosedEventArgs e)
        {
            addcustFrm = null;
        }

        public void BookingBtn_Click(object sender, EventArgs e)
        {
            if (addbookingFrm == null)
            {
                addbookingFrm = new addBooking();
                addbookingFrm.FormClosed += AddBooking_FormClosed;
                addbookingFrm.MdiParent = this;
                addbookingFrm.Dock = DockStyle.Fill;
                addbookingFrm.Show();
            }
            else
            {
                addbookingFrm.Activate();
            }
        }
        private void AddBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            addbookingFrm = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }

        private void billbutton_Click(object sender, EventArgs e)
        {
            if (ticket == null)
            {
                ticket = new Ticket();
                ticket.FormClosed += Ticket_FormClosed;
                ticket.MdiParent = this;
                ticket.Dock = DockStyle.Fill;
                ticket.Show();
            }
            else
            {
                ticket.Activate();
            }
        }
        private void Ticket_FormClosed(object sender, FormClosedEventArgs e)
        {
            ticket = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bill == null)
            {
                bill = new Bill();
                bill.FormClosed += bill_FormClosed;
                bill.MdiParent = this;
                bill.Dock = DockStyle.Fill;
                bill.Show();
            }
            else
            {
                bill.Activate();
            }
        }
        private void bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            ticket = null;
        }
    }
}
