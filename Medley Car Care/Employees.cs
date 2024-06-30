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
    public partial class Employees : Form
    {
        EmployeeSearch employeesearch = new EmployeeSearch();
        EmployeeList employeelist = new EmployeeList();
        AddEmployee addemployee = new AddEmployee();

        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            ShowUserControl(employeesearch);
            this.EmpSearchButton.BackColor = Color.MediumBlue;
        }

        private void ShowUserControl(UserControl userControl)
        {
            foreach (Button btn in this.EmployeeNavBar.Controls)
            {
                btn.BackColor = Color.DarkBlue;
            }
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpSearchButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(employeesearch);
            this.EmpSearchButton.BackColor = Color.MediumBlue;
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            ShowUserControl(employeelist);
            this.EmployeeList.BackColor = Color.MediumBlue;
        }

        private void AddNewEmp_Click(object sender, EventArgs e)
        {
            ShowUserControl(addemployee);
            this.AddNewEmp.BackColor = Color.MediumBlue;
        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
