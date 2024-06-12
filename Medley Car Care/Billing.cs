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
        UserControl calculator = new Calculator();
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

        }

        private void NetAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
