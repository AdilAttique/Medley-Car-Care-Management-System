using Microsoft.Win32;
using Syncfusion.Windows.Converters;
using Syncfusion.Windows.Tools;
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
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public Dashboard()
        {
            InitializeComponent();
            InitializeTimer();

        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            this.Dboard.BackColor = Color.FromArgb(21, 25, 48);
            this.Billing.BackColor = Color.FromArgb(21, 25, 48);
            this.Reports.BackColor = Color.FromArgb(21, 25, 48);
            this.Accounts.BackColor = Color.FromArgb(21, 25, 48);
            this.Inventory.BackColor = Color.FromArgb(21, 25, 48);
            this.Customers.BackColor = Color.FromArgb(21, 25, 48);
            this.Employees.BackColor = Color.FromArgb(21, 25, 48);
            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
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

        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void Accounts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Accounts());
            this.Accounts.BackColor = Color.DarkBlue;
            this.DashboardPanel.Hide();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Inventory());
            this.Inventory.BackColor = Color.DarkBlue;
            this.DashboardPanel.Hide();

        }

        private void Reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports());
            this.Reports.BackColor = Color.DarkBlue;
            this.DashboardPanel.Hide();
        }


        private void billing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Billing());
            this.Billing.BackColor = Color.DarkBlue;
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
            this.Activate();
            this.DashboardPanel.Show();
            this.Dboard.BackColor = Color.DarkBlue;
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            this.Billing.BackColor = Color.FromArgb(21, 25, 48);
            this.Reports.BackColor = Color.FromArgb(21, 25, 48);
            this.Accounts.BackColor = Color.FromArgb(21, 25, 48);
            this.Inventory.BackColor = Color.FromArgb(21, 25, 48);
            this.Customers.BackColor = Color.FromArgb(21, 25, 48);
            this.Employees.BackColor = Color.FromArgb(21, 25, 48);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customers());
            this.Customers.BackColor = Color.DarkBlue;
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
            OpenChildForm(new Employees());
            this.Employees.BackColor = Color.DarkBlue;
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void currencyTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {
            this.Dboard.BackColor = Color.DarkBlue;
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("ddd, dd MMM, yyyy h:mm tt");
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }
    }
}
