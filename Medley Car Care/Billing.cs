using Syncfusion.UI.Xaml.Schedule;
using Syncfusion.UI.Xaml.SmithChart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Medley_Car_Care
{

    public partial class Billing : Form
    {
        SQL sql;

        //public int revenue { get; set; }

    public Billing()
        {
            InitializeComponent();
            sql = new SQL();
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
            string VehicleNumber = VehicleSearchBox.Text;

            try
            {
                string query = "SELECT * FROM Customer WHERE VehicleNumber LIKE '%" + VehicleNumber + "%';";
                DataTable tempdata = sql.ExecuetQuery(query);

                if (tempdata.Rows.Count > 0)
                {

                }
                else
                {
                    DialogResult result = MessageBox.Show("Customer not found. Do you want to add a new customer?", "Customer Not Found", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        Dashboard tempdb = new Dashboard();
                        tempdb.Customers_Click(sender, e);

                    }
                }
            }
            catch (SqlException ex)
            {
                sql.ThrowException(ex);
            }
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

        private int rowcount = 2;

        public void ManageQuantityInInventory(string BarCode, int qtytominus)
        {
            try
            {


                string query = "UPDATE Inventory SET QuantityInStock =(SELECT QuantityInStock from Inventory WHERE BarCode='" + BarCode + "')-" + qtytominus + " WHERE BarCode='" + BarCode + "';";

                sql.ExecuetNonQuery(query);
            }
            catch (SqlException ex)
            {
                sql.ThrowException(ex);
            }
        }
        private void additemtotable_Click(object sender, EventArgs e)
        {
            string itemsearchedbarcode = ProductBarcodeBox.Text;
            string VehicleNumber = VehicleSearchBox.Text;
            string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode WHERE Item.BarCode LIKE'%" + itemsearchedbarcode + "%';";

            DataTable dt = sql.ExecuetQuery(query);
            float netamount = 0;
            if (dt.Rows.Count > 0)
            {
                DataRow itemrow = dt.Rows[0];
                string barcode = itemrow["BarCode"].ToString();
                string name = itemrow["ItemName"].ToString();
                int totalqtyinstock = int.Parse(itemrow["QuantityInStock"].ToString());
                int qtyperunit = int.Parse(itemquantity.Text);
                int priceperunit = int.Parse(itemrow["PricePerUnit"].ToString());
                int totalprice = priceperunit * qtyperunit;



                tableLayoutPanel1.RowCount += 1;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                tableLayoutPanel1.Controls.Add(new Label { Text = (rowcount - 1).ToString(), TextAlign = ContentAlignment.MiddleCenter }, 0, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = barcode, TextAlign = ContentAlignment.MiddleCenter }, 1, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = name, TextAlign = ContentAlignment.MiddleCenter }, 2, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = totalqtyinstock.ToString(), TextAlign = ContentAlignment.MiddleCenter }, 3, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = qtyperunit.ToString(), TextAlign = ContentAlignment.MiddleCenter }, 4, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = priceperunit.ToString(), TextAlign = ContentAlignment.MiddleCenter }, 5, rowcount);
                tableLayoutPanel1.Controls.Add(new Label { Text = totalprice.ToString(), TextAlign = ContentAlignment.MiddleCenter }, 6, rowcount);
                rowcount++;
                ManageQuantityInInventory(barcode, qtyperunit);
                for (int i = 2; i < tableLayoutPanel1.RowCount; i++)
                {
                    Label netbill = (Label)tableLayoutPanel1.GetControlFromPosition(6, i);
                    if (netbill != null)
                        netamount += float.Parse(netbill.Text);
                }

                ProductBarcodeBox.Text = "";
                ProductNameBox.Text = "";
                itemquantity.Text = "";
                TotalAmountBox.Text = netamount.ToString();

            }

        }

        private void ProductBarcodeBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ProductBarcodeBox.Text))
            {

                string ProductBarCode = ProductBarcodeBox.Text;
                string query = "SELECT* FROM Item WHERE BarCode LIKE '%" + ProductBarCode + "%';";

                SqlDataReader rdr = sql.ExecuteReader(query);
                string name = "";

                while (rdr.Read())
                {
                    name = rdr["ItemName"].ToString();

                }

                ProductNameBox.Text = name;
            }
            else
            {
                ProductNameBox.Text = null;
            }
            sql.CloseConnection();

        }

        private void ProductNameBox_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(ProductBarcodeBox.Text))
            //{

            //    string ProductName = ProductNameBox.Text;
            //    string query = "SELECT* FROM Item WHERE ItemName LIKE '%" + ProductName + "%';";

            //    SqlDataReader rdr = sql.ExecuteReader(query);
            //    int Barcode = 0;

            //    while (rdr.Read())
            //    {
            //        Barcode = int.Parse(rdr["BarCode"].ToString());

            //    }

            //    //ProductBarcodeBox.TextChanged -= ProductBarcodeBox_TextChanged;
            //    ProductBarcodeBox.Text = Barcode.ToString();
            //    //ProductBarcodeBox.TextChanged += ProductBarcodeBox_TextChanged;

            //}
            //else
            //{
            //    //ProductBarcodeBox.TextChanged -= ProductBarcodeBox_TextChanged;
            //    ProductBarcodeBox.Text = string.Empty;
            //    //ProductBarcodeBox.TextChanged += ProductBarcodeBox_TextChanged;
            //}
            //sql.CloseConnection();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                SearchCustomerButton_Click(sender, e);
            }
            else
            {
                textBox4.Text = null;
            }
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            string CustomerPhoneNumber = textBox2.Text;
            string query = "SELECT* FROM Customer WHERE PhoneNumber LIKE '%" + CustomerPhoneNumber + "%';";

            SqlDataReader rdr = sql.ExecuteReader(query);
            string name = "";
            string vnum = "";
            while (rdr.Read())
            {
                name = rdr["Name"].ToString();
                vnum = rdr["VehicleNumber"].ToString();
            }

            textBox4.Text = name;
            VehicleSearchBox.Text = vnum;
            sql.CloseConnection();
        }

        private void editableList1_Load(object sender, EventArgs e)
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

        private void DiscountBox_TextChanged(object sender, EventArgs e)
        {

            if (TotalAmountBox.Text.Length > 0 && DiscountBox.Text.Length > 0)
            {
                double a = double.Parse(TotalAmountBox.Text), b = double.Parse(DiscountBox.Text);
                double result = a - b;
                NetAmountBox.Text = result.ToString();
            }
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TotalAmountBox.Text))
            {
                MessageBox.Show("Checout Completed \n\n Total Bill : " + NetAmountBox.Text + "");
                ProductBarcodeBox.Text = "";
                ProductNameBox.Text = "";
                itemquantity.Text = "";
                textBox2.Text = "";
                VehicleSearchBox.Text = "";
                ClearTableLayout(tableLayoutPanel1);
                rowcount = 2;
                //revenue += int.Parse(NetAmountBox.Text);
            }
            else
            {
                MessageBox.Show("ADD Items To Checkout");

            }





        }

        private void ClearTableLayout(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.SuspendLayout();



            for (int i = tableLayoutPanel.Controls.Count - 1; i >= 7; i--)
            {
                Control control = tableLayoutPanel.Controls[i];
                tableLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
            //tableLayoutPanel.RowCount = 1;
            //tableLayoutPanel.ColumnCount = 1;
            //tableLayoutPanel.RowStyles.Clear();
            //tableLayoutPanel.ColumnStyles.Clear();

            tableLayoutPanel.ResumeLayout();
        }
        public string getnetamount ()
        {
            return NetAmountBox.Text;
        }
    }
}


//0334 5678988