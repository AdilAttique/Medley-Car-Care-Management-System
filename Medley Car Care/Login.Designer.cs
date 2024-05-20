
using System.Security.AccessControl;

namespace Medley_Car_Care
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            btnLogin = new Button();
            btnCancel = new Button();
            lblCompany = new Label();
            pictureBox1 = new PictureBox();
            InvalidCredentials = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.ForeColor = SystemColors.ActiveCaption;
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.ForeColor = Color.White;
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCompany
            // 
            lblCompany.BackColor = Color.LightBlue;
            resources.ApplyResources(lblCompany, "lblCompany");
            lblCompany.ForeColor = SystemColors.HotTrack;
            lblCompany.Name = "lblCompany";
            lblCompany.Click += lblCompany_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // InvalidCredentials
            // 
            InvalidCredentials.BackColor = Color.LightBlue;
            InvalidCredentials.BorderStyle = BorderStyle.None;
            resources.ApplyResources(InvalidCredentials, "InvalidCredentials");
            InvalidCredentials.ForeColor = Color.Red;
            InvalidCredentials.Name = "InvalidCredentials";
            InvalidCredentials.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.LightBlue;
            Controls.Add(InvalidCredentials);
            Controls.Add(pictureBox1);
            Controls.Add(lblCompany);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Login";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Button btnLogin;
        private Button btnCancel;
        private Label lblCompany;
        private PictureBox pictureBox1;
        private TextBox InvalidCredentials;
    }
}