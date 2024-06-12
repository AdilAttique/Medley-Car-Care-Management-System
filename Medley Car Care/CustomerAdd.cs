using Mysqlx.Datatypes;
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
    public partial class CustomerAdd : UserControl
    {
        
        public CustomerAdd()
        {
            InitializeComponent();
        }
        
        public void AddCustomerToRecord()
        {
            SQL sql = new SQL();
            try
            {
                string VehicleNumber = vnumber.Text;
                string CustomerName = name.Text;
                string CustomerPhoneNumber = pnumber.Text;
                string CustomerEmail = email.Text;
                string CustomerAddress = address.Text;

                string query = "INSERT INTO Customer (VehicleNumber, Name, PhoneNumber, Email, Address) VALUES ('" + VehicleNumber + "','" + CustomerName + "','" + CustomerPhoneNumber + "',  '" + CustomerEmail + "', '" + CustomerAddress + "');";
                sql.ExecuetNonQuery(query);
                MessageBox.Show("Customr Added Successfully With Vehicle Number = " + VehicleNumber + "");
                vnumber.Text = "";
                name.Text = "";
                pnumber.Text = "";
                email.Text = "";
                address.Text = "";

            }
            catch (SqlException ex)
            {
                sql.ThrowException(ex);
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            
            this.AddCustomerToRecord();
            
        }
    }
}
