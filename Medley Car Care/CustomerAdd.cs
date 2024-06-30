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
        SQL sql = new SQL();
        public CustomerAdd()
        {
            InitializeComponent();
        }

        public void AddCustomerToRecord()
        {

            try
            {
                string VehicleNumber = vnumber.Text;
                string CustomerName = name.Text;
                string CustomerPhoneNumber = pnumber.Text;
                string CustomerEmail = email.Text;
                string CustomerAddress = address.Text;

                string query = "INSERT INTO Customer (VehicleNumber, Name, PhoneNumber, Email, Address) VALUES ('" + VehicleNumber + "','" + CustomerName + "','" + CustomerPhoneNumber + "',  '" + CustomerEmail + "', '" + CustomerAddress + "');";
                sql.ExecuetNonQuery(query);
                MessageBox.Show("Customr Added Successfully With Vehicle Number = " + VehicleNumber + "", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (vnumber.Text != "" && name.Text != "" && pnumber.Text != "" && email.Text != "" && address.Text != "")
                this.AddCustomerToRecord();
            else
                MessageBox.Show("Please Fill all the Details!", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void pnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
