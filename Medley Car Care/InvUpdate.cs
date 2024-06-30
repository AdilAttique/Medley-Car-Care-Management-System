using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medley_Car_Care
{
    public partial class InvUpdate : UserControl
    {
        SQL sql = new SQL();
        public InvUpdate()
        {
            InitializeComponent();
        }

        private void InvUpdate_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void AddItemToInventory()
        {

            try
            {
                string BarCode = barcode.Text;
                string ItemName = itemname.Text;
                float PricePerUnit = float.Parse(priceperunit.Text);
                int QuantityInStock = int.Parse(quantityinstock.Text);


                string query = "INSERT INTO Item (BarCode, ItemName, PricePerUnit) VALUES ('" + BarCode + "','" + ItemName + "','" + PricePerUnit + "');";
                string query2 = "INSERT INTO Inventory (BarCode, QuantityInStock) VALUES ('" + BarCode + "','" + QuantityInStock + "');";
                sql.ExecuetNonQuery(query);
                sql.ExecuetNonQuery(query2);
                MessageBox.Show("Item Added Successfully With Bar Code= " + BarCode + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                barcode.Text = "";
                itemname.Text = "";
                priceperunit.Text = "";
                quantityinstock.Text = "";


            }
            catch (SqlException ex)
            {
                sql.ThrowException(ex);
            }
        }

        private void AddItem_Click_1(object sender, EventArgs e)
        {
            if (barcode.Text != "" && itemname.Text != "" && priceperunit.Text != "" && quantityinstock.Text != "")
                this.AddItemToInventory();
            else
                MessageBox.Show("Please Fill all the Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
