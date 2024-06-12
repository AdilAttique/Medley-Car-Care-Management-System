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
            AddCustomer = new Button();
            address = new TextBox();
            label6 = new Label();
            name = new TextBox();
            label5 = new Label();
            pnumber = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label3 = new Label();
            label1 = new Label();
            vnumber = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel1.Controls.Add(label1);
            panel1.Location = new Point(291, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 1;
            // 
            // AddCustomer
            // 
            AddCustomer.Location = new Point(113, 503);
            AddCustomer.Name = "AddCustomer";
            AddCustomer.Size = new Size(101, 27);
            AddCustomer.TabIndex = 12;
            AddCustomer.Text = "ADD";
            AddCustomer.UseVisualStyleBackColor = true;
            AddCustomer.Click += AddCustomer_Click;
            // 
            // address
            // 
            address.Location = new Point(277, 363);
            address.Name = "address";
            address.Size = new Size(234, 23);
            address.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 371);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Address";
            // 
            // name
            // 
            name.Location = new Point(277, 180);
            name.Name = "name";
            name.Size = new Size(234, 23);
            name.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(113, 188);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Name";
            // 
            // pnumber
            // 
            pnumber.Location = new Point(277, 239);
            pnumber.Name = "pnumber";
            pnumber.Size = new Size(234, 23);
            pnumber.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 247);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // email
            // 
            email.Location = new Point(277, 300);
            email.Name = "email";
            email.Size = new Size(234, 23);
            email.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 308);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 35);
            label1.TabIndex = 0;
            label1.Text = "Add New Customer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // vnumber
            // 
            vnumber.Location = new Point(277, 123);
            vnumber.Name = "vnumber";
            vnumber.Size = new Size(234, 23);
            vnumber.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 131);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 14;
            label2.Text = "Vehicle Number";
            // 
            // CustomerAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "CustomerAdd";
            Size = new Size(1678, 919);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
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
    }
}
