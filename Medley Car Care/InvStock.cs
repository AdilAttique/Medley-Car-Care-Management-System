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
    public partial class InvStock : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public InvStock()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadInventory()
        {
            string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode;";

            dt=sql.ExecuetQuery(query);

            inventorydgv.DataSource = dt;

        }

        private void InvStock_Load(object sender, EventArgs e)
        {
            this.LoadInventory();
        }
    }
}
