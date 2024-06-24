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
    public partial class EmployeeSearch : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public EmployeeSearch()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void empsearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(empsearch.Text))
            {

                try
                {
                    string query = "SELECT * FROM Employee WHERE CNIC Like'%"+empsearch.Text+"%';";
                    
                    dt = sql.ExecuetQuery(query);
                    empdgv.DataSource = dt;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                empdgv.DataSource = null;
            }
        }
    }
}
