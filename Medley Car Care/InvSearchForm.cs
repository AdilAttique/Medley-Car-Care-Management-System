using Syncfusion.UI.Xaml.Spreadsheet;
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

namespace Medley_Car_Care
{
    public partial class InvSearchForm : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public InvSearchForm()
        {
            InitializeComponent();
            sql = new SQL();
            itemsearch.TextChanged += new EventHandler(Itemsearch_TextChanged);

        }

        private void InvSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void Cust_Load(object sender, EventArgs e)
        {

        }

        private void itemsearchbtn_Click(object sender, EventArgs e)
        {

        }

        private void Itemsearch_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(itemsearch.Text))
            {

                try
                {
                    string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode WHERE Item.BarCode LIKE'%" + itemsearch.Text + "%';";
                    DataTable dt = new DataTable();
                    dt = sql.ExecuetQuery(query);
                    inventorysearchdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                inventorysearchdgv.DataSource = null;
            }
        }

        private void itemsearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
