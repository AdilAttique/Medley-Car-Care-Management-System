
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(827, 405);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(827, 484);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Password :";
            label3.Click += label3_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(827, 428);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 26);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(827, 507);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(292, 26);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ActiveCaption;
            checkBox1.Location = new Point(827, 548);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(142, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(17, 205, 239);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(849, 625);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(996, 625);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 42);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblCompany
            // 
            lblCompany.BackColor = Color.LightBlue;
            lblCompany.Font = new Font("Century Schoolbook", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompany.ForeColor = SystemColors.HotTrack;
            lblCompany.Location = new Point(759, 922);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(390, 47);
            lblCompany.TabIndex = 6;
            lblCompany.Text = "Medley Car Care";
            lblCompany.TextAlign = ContentAlignment.MiddleRight;
            lblCompany.Click += lblCompany_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(781, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 284);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(lblCompany);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label3);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medley Car Care";
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
    }
}