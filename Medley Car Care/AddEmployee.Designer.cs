namespace Medley_Car_Care
{
    partial class AddEmployee
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
            cnic = new TextBox();
            label1 = new Label();
            label2 = new Label();
            empname = new TextBox();
            label3 = new Label();
            empaddress = new TextBox();
            label4 = new Label();
            jobtitle = new TextBox();
            label5 = new Label();
            salary = new TextBox();
            emphiredate = new DateTimePicker();
            label6 = new Label();
            panel1 = new Panel();
            AddEmp = new Button();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cnic
            // 
            cnic.Font = new Font("Segoe UI", 12F);
            cnic.Location = new Point(242, 116);
            cnic.Name = "cnic";
            cnic.Size = new Size(296, 29);
            cnic.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label1.Location = new Point(106, 120);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "CNIC No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(106, 180);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Full Name";
            // 
            // empname
            // 
            empname.Font = new Font("Segoe UI", 12F);
            empname.Location = new Point(242, 176);
            empname.Name = "empname";
            empname.Size = new Size(296, 29);
            empname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(106, 240);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // empaddress
            // 
            empaddress.Font = new Font("Segoe UI", 12F);
            empaddress.Location = new Point(242, 236);
            empaddress.Name = "empaddress";
            empaddress.Size = new Size(296, 29);
            empaddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.Location = new Point(106, 360);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 8;
            label4.Text = "Job Title";
            label4.Click += label4_Click;
            // 
            // jobtitle
            // 
            jobtitle.Font = new Font("Segoe UI", 12F);
            jobtitle.Location = new Point(242, 356);
            jobtitle.Name = "jobtitle";
            jobtitle.Size = new Size(296, 29);
            jobtitle.TabIndex = 7;
            jobtitle.TextChanged += jobtitle_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label5.Location = new Point(106, 420);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "Salary";
            // 
            // salary
            // 
            salary.Font = new Font("Segoe UI", 12F);
            salary.Location = new Point(242, 416);
            salary.Name = "salary";
            salary.Size = new Size(296, 29);
            salary.TabIndex = 9;
            // 
            // emphiredate
            // 
            emphiredate.CustomFormat = "yyyy-MM-dd";
            emphiredate.Font = new Font("Segoe UI", 12F);
            emphiredate.Format = DateTimePickerFormat.Custom;
            emphiredate.Location = new Point(242, 293);
            emphiredate.Name = "emphiredate";
            emphiredate.Size = new Size(296, 29);
            emphiredate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label6.Location = new Point(106, 300);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 12;
            label6.Text = "Hire Date";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AddEmp);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emphiredate);
            panel1.Controls.Add(cnic);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(salary);
            panel1.Controls.Add(empname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(jobtitle);
            panel1.Controls.Add(empaddress);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(291, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // AddEmp
            // 
            AddEmp.BackColor = Color.SkyBlue;
            AddEmp.FlatAppearance.BorderSize = 0;
            AddEmp.FlatStyle = FlatStyle.Flat;
            AddEmp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEmp.ForeColor = Color.Black;
            AddEmp.Location = new Point(319, 493);
            AddEmp.Name = "AddEmp";
            AddEmp.Size = new Size(101, 27);
            AddEmp.TabIndex = 17;
            AddEmp.Text = "ADD";
            AddEmp.UseVisualStyleBackColor = false;
            AddEmp.Click += AddEmp_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(autoLabel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 62);
            panel3.TabIndex = 16;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.Snow;
            autoLabel1.Location = new Point(415, 14);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(266, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Add New Employee";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(1678, 919);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox cnic;
        private Label label1;
        private Label label2;
        private TextBox empname;
        private Label label3;
        private TextBox empaddress;
        private Label label4;
        private TextBox jobtitle;
        private Label label5;
        private TextBox salary;
        private DateTimePicker emphiredate;
        private Label label6;
        private Panel panel1;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Button AddEmp;
    }
}
