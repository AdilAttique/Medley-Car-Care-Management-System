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
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Employee;";
                dt = sql.ExecuetQuery(query);
                emplistdgv.DataSource = dt;

            }catch (SqlException ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
