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
    public partial class CustomerList : UserControl
    {
        SQL sql=new SQL(); 
        DataTable dt=new DataTable();
        public CustomerList()
        {
            InitializeComponent();
            this.LoadCustomerList();
        }

        public void LoadCustomerList()
        {
            string query = "SELECT * FROM Customer;";
            dt = sql.ExecuetQuery(query);

            customerlistdgv.DataSource = dt;
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
           this.LoadCustomerList();
        }
    }
}
