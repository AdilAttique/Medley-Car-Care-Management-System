using Syncfusion.UI.Xaml.Grid;
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
    public partial class CustomerList : UserControl
    {
        SQL sql = new SQL();
        DataTable dt = new DataTable();
        public CustomerList()
        {
            InitializeComponent();
            this.LoadCustomerList();
            customerlistdgv.CellPainting += customerlistdgv_CellPainting;
            customerlistdgv.CellClick += customerlistdgv_CellClick;
        }

        private void search_TextChanged_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                try
                {
                    string query = "SELECT * FROM Customer WHERE VehicleNumber LIKE'%" + search.Text + "%';";
                    DataTable dt = new DataTable();
                    dt = sql.ExecuetQuery(query);
                    customerlistdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                string query = "SELECT * FROM Customer;";
                dt = sql.ExecuetQuery(query);

                customerlistdgv.DataSource = dt;
            }
        }


        public void LoadCustomerList()
        {
            string query = "SELECT * FROM Customer;";
            dt = sql.ExecuetQuery(query);

            customerlistdgv.DataSource = dt;
        }

        private void customerlistdgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == customerlistdgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != customerlistdgv.Rows.Count - 1)
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

        private void customerlistdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == customerlistdgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != customerlistdgv.Rows.Count - 1)
            {
                string customerName = Convert.ToString(customerlistdgv.Rows[e.RowIndex].Cells["Name"].Value);
                var result = MessageBox.Show($"Are you sure you want to delete '{customerName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // DELETE QUERY TO BE WRITTEN HERE!!!

                    customerlistdgv.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Customer Has been Deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CustomerList_Load(object sender, EventArgs e)
        {
            this.LoadCustomerList();
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            foreach (DataGridViewColumn column in customerlistdgv.Columns)
            {
                if (column.Name != "Delete")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            customerlistdgv.ColumnHeadersHeight = 45;
            customerlistdgv.EnableHeadersVisualStyles = false;
            customerlistdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            customerlistdgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            customerlistdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "";
            deleteButtonColumn.UseColumnTextForButtonValue = false;
            customerlistdgv.Columns.Add(deleteButtonColumn);
            customerlistdgv.Columns["Delete"].Width = 80;
            customerlistdgv.Columns["Delete"].DefaultCellStyle.BackColor = Color.White;

            foreach (DataGridViewColumn column in customerlistdgv.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void customerlistdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
