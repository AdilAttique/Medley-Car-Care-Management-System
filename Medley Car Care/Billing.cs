using Syncfusion.UI.Xaml.Diagram;
using Syncfusion.Windows.Forms.Tools;
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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            /*for (int row = 0; row < tableLayoutPanel1.RowCount; row++)
            {
                for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                {
                    Panel panel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        BorderStyle = BorderStyle.None
                    };

                    // Set background color for the first and last rows
                    if (row == 0 || row == tableLayoutPanel1.RowCount - 1)
                    {
                        panel.BackColor = Color.SkyBlue;
                    }
                    tableLayoutPanel1.Controls.Add(panel, col, row);
                    panel.SendToBack();
                }
            }*/


        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CuurentMileageText_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VehicleSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void TotalAmountBox_TextChanged(object sender, EventArgs e)
        {
            NetAmountBox.Text = TotalAmountBox.Text;
        }

        private void NetAmountBox_TextChanged(object sender, EventArgs e)
        {
            /* if (TotalAmountBox.Text.Length > 0 && DiscountBox.Text.Length > 0)
             {
                 double a = double.Parse(TotalAmountBox.Text), b = double.Parse(DiscountBox.Text);
                 double result = a - b;
                 NetAmountBox.Text = result.ToString();
             }
             else if (TotalAmountBox.Text.Length > 0)
             {

             }*/
        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {

        }

        private void DiscountBox_TextChanged(object sender, EventArgs e)
        {
            if (TotalAmountBox.Text.Length > 0 && DiscountBox.Text.Length > 0)
            {
                double a = double.Parse(TotalAmountBox.Text), b = double.Parse(DiscountBox.Text);
                double result = a - b;
                NetAmountBox.Text = result.ToString();
            }
        }

        private void BalanceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReceivedBox_TextChanged(object sender, EventArgs e)
        {
            if (ReceivedBox.Text.Length > 0 && NetAmountBox.Text.Length > 0)
            {
                double c = double.Parse(NetAmountBox.Text), d = double.Parse(ReceivedBox.Text);
                double Result = d - c;
                BalanceBox.Text = Result.ToString();
            }
        }

        private void unCheck(CheckBoxAdv current)
        {
            if(CashCheck != current)
            {
                CashCheck.Checked = false;
            }
            if(Credit != current)
            {
                Credit.Checked = false;
            }
            if(ATMText != current)
            {
                ATMText.Checked = false;
            }
            if(JazzCashCheck != current)
            {
                JazzCashCheck.Checked = false;
            }
        }
        private void CashCheck_CheckStateChanged(object sender, EventArgs e)
        {
            unCheck(CashCheck);
        }

        private void Credit_CheckStateChanged(object sender, EventArgs e)
        {
            unCheck(Credit);
        }

        private void ATMText_CheckStateChanged(object sender, EventArgs e)
        {
            unCheck(ATMText);
        }

        private void JazzCashCheck_CheckStateChanged(object sender, EventArgs e)
        {
            unCheck(JazzCashCheck);
        }
    }
}
