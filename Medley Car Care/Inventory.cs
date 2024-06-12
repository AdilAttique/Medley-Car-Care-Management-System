using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medley_Car_Care
{
    public partial class Inventory : Form
    {
        InvSearchForm userControl1 = new InvSearchForm();
        InvStock userControl2 = new InvStock();
        InvUpdate userControl3 = new InvUpdate();

        public Inventory()
        {
            InitializeComponent();

        }
        private void menu1_Load(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void ShowUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void InvSearchButton_Click(object sender, EventArgs e)
        {
            this.InvSearchButton.BackColor = Color.MediumBlue;
            this.UpdateButton.BackColor = Color.DarkBlue;
            this.StockButton.BackColor = Color.DarkBlue;
            ShowUserControl(userControl1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.InvSearchButton.BackColor = Color.MediumBlue;
            ShowUserControl(userControl1);

        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            this.InvSearchButton.BackColor = Color.DarkBlue;
            this.UpdateButton.BackColor = Color.DarkBlue;
            this.StockButton.BackColor = Color.MediumBlue;
            ShowUserControl(userControl2);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            this.InvSearchButton.BackColor = Color.DarkBlue;
            this.StockButton.BackColor = Color.DarkBlue;
            this.UpdateButton.BackColor = Color.MediumBlue;
            ShowUserControl(userControl3);
        }

        private void InvNavBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
