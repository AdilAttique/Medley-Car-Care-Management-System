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
            // Add the new user control to the panel
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }

        private void InvSearchButton_Click(object sender, EventArgs e)
        {
            InvSearchForm userControl1 = new InvSearchForm();
            ShowUserControl(userControl1);
           
        }
    }
}
