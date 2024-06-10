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
    
    public partial class Customers : Form
    {
        CustomerSearch customerSearch = new CustomerSearch();
        CustomerList customerList = new CustomerList();
        CustomerAdd customerAdd = new CustomerAdd();

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        private void ShowUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CustSearchButton_Click(object sender, EventArgs e)
        {
          
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {

        }

        private void AddNew_Click(object sender, EventArgs e)
        {

        }
    }
}
