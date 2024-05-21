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
        Billing bill;
        Accounts Accs;
        Reports Reps;
        Inventory Invent;
        Customers Custom;
        Employees Emp;
        Login login;

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
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void billing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Billing());
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
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            if (Custom == null)
            {
                /*Custom = new Customers();
                Custom.Show();
                this.Hide();*/
                OpenChildForm(new Customers());
            }
            else
            {
                Custom.Activate();
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Login());
        }

        private void Employees_Click_1(object sender, EventArgs e)
        {
            /*Emp = new Employees();
            Emp.Show();
            this.Hide();*/

            OpenChildForm(new Employees());
        }

        private void LogOut_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Close();
            log.Activate();
        }
    }
}
