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
    public partial class Login : Form
    {
        /*        SqlCommand cm = new SqlCommand();
                dbConnect dbcon = new dbConnect();
                SqlDataReader dr;*/
        string title = "Medley Car Care";
        public Login()
        {
            InitializeComponent();
            loadCompany();
        }


        public void loadCompany()
        {
            /*cm = new SqlCommand("SELECT * FROM tbCompany", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblCompany.Text = dr["name"].ToString();
                lblAddress.Text = dr["address"].ToString();
            }
            dr.Close();
            dbcon.close();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "medley" && txtPassword.Text == "123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                this.InvalidCredentials.Text = "Invalid Credentials!";
                btnCancel_Click(sender,e);
            }
            try
            {
                /*  cm = new SqlCommand("SELECT name FROM tbEmployer WHERE name ='" + txtName.Text + "' AND password ='" + txtPassword.Text + "'", dbcon.connect());
                  dbcon.open();
                  dr = cm.ExecuteReader();
                  dr.Read();
                  if (dr.HasRows)
                  {
                      MessageBox.Show("WELCOME " + dr[0].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      this.Hide();
                      MainForm main = new MainForm();
                      main.ShowDialog();
                  }
                  else
                  {
                      MessageBox.Show("Invalid username or password", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
                  dbcon.close();
                  dr.Close();*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
