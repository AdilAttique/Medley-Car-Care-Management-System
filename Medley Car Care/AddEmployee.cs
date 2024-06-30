using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medley_Car_Care
{
    public partial class AddEmployee : UserControl
    {
        SQL sql;
        DataTable dt = new DataTable();
        public AddEmployee()
        {
            InitializeComponent();
            sql = new SQL();
        }



        public void AddEmployeeToRecord()
        {

            try
            {
                string CNIC = cnic.Text;
                string Name = empname.Text;
                string Address = empaddress.Text;
                DateTime HireDate = emphiredate.Value;
                string JobTitle = jobtitle.Text;
                float Salary = float.Parse(salary.Text);

                string query = "INSERT INTO Employee (CNIC, Name, JobTitle, HireDate, Address,Salary) VALUES ('" + CNIC + "','" + Name + "', '" + JobTitle + "', '" + HireDate + "','" + Address + "',  '" + Salary + "');";
                sql.ExecuetNonQuery(query);
                MessageBox.Show("Employee Added Successfully With CNIC Number = " + CNIC + "");
                cnic.Text = "";
                empname.Text = "";
                empaddress.Text = "";
                jobtitle.Text = "";
                salary.Text = "";

            }
            catch (SqlException ex)
            {
                sql.ThrowException(ex);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void jobtitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (cnic.Text != "" && empname.Text != "" && empaddress.Text != "" && jobtitle.Text != "" && salary.Text != "")
                this.AddEmployeeToRecord();
            else
                MessageBox.Show("Please Fill all the Details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
