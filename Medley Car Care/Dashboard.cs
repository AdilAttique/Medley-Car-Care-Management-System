using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medley_Car_Care
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
     
        private void OpenChildForm(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void NavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void MedleyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BillCustomer_Click(object sender, EventArgs e)
        {

        }
        private void BillCustomer_Hover(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Accounts());
            this.DashboardPanel.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory());
            this.DashboardPanel.Hide();

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports());
            this.DashboardPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void billing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Billing());
            this.DashboardPanel.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dboard_Click(object sender, EventArgs e)
        {
            /*if (dashb == null)
            {
                *//*dashb = new Dashboard();
                dashb.MdiParent = this;
                dashb.Show();*//*
                OpenChildForm(new Dashboard());
            }
            else
            {
                dashb.Activate();
            }*/
            this.Activate();
            this.DashboardPanel.Show();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customers());
            this.DashboardPanel.Hide();
        }

        private void Employees_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
            this.DashboardPanel.Hide();
        }

        private void Employees_Click_1(object sender, EventArgs e)
        {
            /*Emp = new Employees();
            Emp.Show();
            this.Hide();*/

            OpenChildForm(new Employees());
            this.DashboardPanel.Hide();
        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
            log.Activate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
