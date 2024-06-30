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
    public partial class CustomerSearch : UserControl
    {
        private SQL sql;
        public CustomerSearch()
        {
            InitializeComponent();
            sql = new SQL();
            search.TextChanged += new EventHandler(search_TextChanged);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {


            try
            {
                string query = "SELECT * FROM Customer WHERE VehicleNumber ='" + search.Text + "';";
                DataTable dt = new DataTable();
                dt = sql.ExecuetQuery(query);
                customerdgv.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(search.Text))
            {
                try
                {
                    string query = "SELECT * FROM Customer WHERE VehicleNumber LIKE'%" + search.Text + "%';";
                    DataTable dt = new DataTable();
                    dt = sql.ExecuetQuery(query);
                    customerdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                customerdgv.DataSource = null;
            }
        }
        private void CustomerSearch_Load(object sender, EventArgs e)
        {

        }

        private void search_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
