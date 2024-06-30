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
    public partial class EmployeeList : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public EmployeeList()
        {
            InitializeComponent();
            sql = new SQL();
            emplistdgv.CellPainting += emplistdgv_CellPainting;
            emplistdgv.CellClick += emplistdgv_CellClick;
        }

        private void emplistdgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == emplistdgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != emplistdgv.Rows.Count - 1)
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

        private void emplistdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == emplistdgv.Columns["Delete"].Index && e.RowIndex >= 0 && e.RowIndex != emplistdgv.Rows.Count - 1)
            {
                string empName = Convert.ToString(emplistdgv.Rows[e.RowIndex].Cells["Name"].Value);
                var result = MessageBox.Show($"Are you sure you want to delete '{empName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // DELETE QUERY TO BE WRITTEN HERE!!!

                    emplistdgv.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Employee Has been Deleted!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Employee;";
                dt = sql.ExecuetQuery(query);
                emplistdgv.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            foreach (DataGridViewColumn column in emplistdgv.Columns)
            {
                if (column.Name != "Delete")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            emplistdgv.ColumnHeadersHeight = 45;
            emplistdgv.EnableHeadersVisualStyles = false;
            emplistdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            emplistdgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            emplistdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11.25F, FontStyle.Bold);

            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "";
            deleteButtonColumn.UseColumnTextForButtonValue = false;
            emplistdgv.Columns.Add(deleteButtonColumn);
            emplistdgv.Columns["Delete"].Width = 80;
            emplistdgv.Columns["Delete"].DefaultCellStyle.BackColor = Color.White;

            foreach (DataGridViewColumn column in emplistdgv.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void emplistdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void empsearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(empsearch.Text))
            {

                try
                {
                    string query = "SELECT * FROM Employee WHERE CNIC Like'%" + empsearch.Text + "%';";

                    dt = sql.ExecuetQuery(query);
                    emplistdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    string query = "SELECT * FROM Employee;";
                    dt = sql.ExecuetQuery(query);
                    emplistdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
