namespace Medley_Car_Care
{
    partial class CustomerAdd
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            vnumber = new TextBox();
            label2 = new Label();
            AddCustomer = new Button();
            address = new TextBox();
            label6 = new Label();
            name = new TextBox();
            label5 = new Label();
            pnumber = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(vnumber);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(AddCustomer);
            panel1.Controls.Add(address);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pnumber);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(email);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(291, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(autoLabel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 62);
            panel3.TabIndex = 15;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.Snow;
            autoLabel1.Location = new Point(415, 14);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(266, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Add New Customer";
            autoLabel1.Click += autoLabel1_Click;
            // 
            // vnumber
            // 
            vnumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vnumber.Location = new Point(242, 116);
            vnumber.Name = "vnumber";
            vnumber.Size = new Size(234, 29);
            vnumber.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 120);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 14;
            label2.Text = "Vehicle Number";
            label2.Click += label2_Click;
            // 
            // AddCustomer
            // 
            AddCustomer.BackColor = Color.SkyBlue;
            AddCustomer.FlatAppearance.BorderSize = 0;
            AddCustomer.FlatStyle = FlatStyle.Flat;
            AddCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustomer.ForeColor = Color.Black;
            AddCustomer.Location = new Point(302, 433);
            AddCustomer.Name = "AddCustomer";
            AddCustomer.Size = new Size(101, 27);
            AddCustomer.TabIndex = 12;
            AddCustomer.Text = "ADD";
            AddCustomer.UseVisualStyleBackColor = false;
            AddCustomer.Click += AddCustomer_Click;
            // 
            // address
            // 
            address.Font = new Font("Segoe UI", 12F);
            address.Location = new Point(242, 356);
            address.Name = "address";
            address.Size = new Size(234, 29);
            address.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label6.Location = new Point(106, 360);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 12F);
            name.Location = new Point(242, 176);
            name.Name = "name";
            name.Size = new Size(234, 29);
            name.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label5.Location = new Point(106, 180);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // pnumber
            // 
            pnumber.Font = new Font("Segoe UI", 12F);
            pnumber.Location = new Point(242, 236);
            pnumber.Name = "pnumber";
            pnumber.Size = new Size(234, 29);
            pnumber.TabIndex = 6;
            pnumber.TextChanged += pnumber_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.Location = new Point(106, 240);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 12F);
            email.Location = new Point(242, 296);
            email.Name = "email";
            email.Size = new Size(234, 29);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(106, 300);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "CustomerAdd";
            Size = new Size(1678, 919);
            Load += CustomerAdd_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox name;
        private Label label5;
        private TextBox pnumber;
        private Label label4;
        private TextBox email;
        private Label label3;
        private TextBox address;
        private Label label6;
        private Button AddCustomer;
        private TextBox vnumber;
        private Label label2;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
    }
}
