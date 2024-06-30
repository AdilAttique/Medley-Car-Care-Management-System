using Syncfusion.Windows.Forms.Tools;
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
    public partial class InvStock : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public InvStock()
        {
            InitializeComponent();
            sql = new SQL();

            inventorydgv.CellPainting += inventorydgv_CellPainting;
            inventorydgv.CellClick += inventorydgv_CellClick;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inventorydgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == inventorydgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != inventorydgv.Rows.Count - 1)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var deleteIcon = Properties.Resources.deleteIcon;
                int iconSize = 25;
                var iconBounds = new Rectangle(
                    e.CellBounds.Left + (e.CellBounds.Width - iconSize) / 2,
                    e.CellBounds.Top + (e.CellBounds.Height - iconSize) / 2,
                    iconSize,
                    iconSize
                );

                e.Graphics.DrawImage(deleteIcon, iconBounds);

                e.Handled = true;
            }
        }

        private void inventorydgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == inventorydgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != inventorydgv.Rows.Count - 1)
            {
                string itemName = Convert.ToString(inventorydgv.Rows[e.RowIndex].Cells["ItemName"].Value);
                string barcode = Convert.ToString(inventorydgv.Rows[e.RowIndex].Cells["BarCode"].Value);
                var result = MessageBox.Show($"Are you sure you want to delete '{itemName}' with Barcode: {barcode}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // DELETE QUERY TO BE WRITTEN HERE!!!

                    inventorydgv.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Item Has been Deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void LoadInventory()
        {
            string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode;";

            dt = sql.ExecuetQuery(query);

            inventorydgv.DataSource = dt;

        }

        private void InvStock_Load(object sender, EventArgs e)
        {
            this.LoadInventory();
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            foreach (DataGridViewColumn column in inventorydgv.Columns)
            {
                if (column.Name != "Delete")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            inventorydgv.ColumnHeadersHeight = 45;
            inventorydgv.EnableHeadersVisualStyles = false;
            inventorydgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            inventorydgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            inventorydgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11.25F, FontStyle.Bold);

            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "";
            deleteButtonColumn.UseColumnTextForButtonValue = false;
            inventorydgv.Columns.Add(deleteButtonColumn);
            inventorydgv.Columns["Delete"].Width = 80;
            inventorydgv.Columns["Delete"].DefaultCellStyle.BackColor = Color.White;

            foreach (DataGridViewColumn column in inventorydgv.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void inventorydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {

                try
                {
                    string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode WHERE Item.BarCode LIKE'%" + search.Text + "%';";
                    DataTable dt = new DataTable();
                    dt = sql.ExecuetQuery(query);
                    inventorydgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                string query = "SELECT Item.BarCode,Item.ItemName, Item.PricePerUnit,Inventory.QuantityinStock FROM Item  JOIN Inventory ON Item.BarCode=Inventory.BarCode;";

                dt = sql.ExecuetQuery(query);

                inventorydgv.DataSource = dt;
            }
        }
    }
}
