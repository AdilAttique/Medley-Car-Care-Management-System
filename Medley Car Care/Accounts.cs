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
    public partial class Accounts : Form
    {
        Current_Accounts Curraccounts = new Current_Accounts();
        Add_Account Addaccount = new Add_Account();

        public Accounts()
        {
            InitializeComponent();
            ShowUserControl(Curraccounts);
            this.CurrAccoutsButton.BackColor = Color.MediumBlue;
        }

        private void ShowUserControl(UserControl userControl)
        {
            foreach (Button btn in this.AccountsNavBar.Controls)
            {
                btn.BackColor = Color.DarkBlue;
            }
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void CurrAccoutsButton_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(Curraccounts);
            this.CurrAccoutsButton.BackColor = Color.MediumBlue;
        }

        private void AddAccounts_Click(object sender, EventArgs e)
        {
            ShowUserControl(Addaccount);
            this.AddAccounts.BackColor = Color.MediumBlue;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
