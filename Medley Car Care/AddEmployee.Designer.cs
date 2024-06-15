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
            AddEmp = new Button();
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
            SuspendLayout();
            // 
            // cnic
            // 
            cnic.Location = new Point(448, 199);
            cnic.Name = "cnic";
            cnic.Size = new Size(296, 23);
            cnic.TabIndex = 0;
            // 
            // AddEmp
            // 
            AddEmp.Location = new Point(314, 524);
            AddEmp.Name = "AddEmp";
            AddEmp.Size = new Size(75, 23);
            AddEmp.TabIndex = 1;
            AddEmp.Text = "Add";
            AddEmp.UseVisualStyleBackColor = true;
            AddEmp.Click += AddEmp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(314, 202);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "CNIC No.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 252);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Full Name";
            // 
            // empname
            // 
            empname.Location = new Point(448, 249);
            empname.Name = "empname";
            empname.Size = new Size(296, 23);
            empname.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(314, 303);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // empaddress
            // 
            empaddress.Location = new Point(448, 300);
            empaddress.Name = "empaddress";
            empaddress.Size = new Size(296, 23);
            empaddress.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 405);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 8;
            label4.Text = "Job Title";
            // 
            // jobtitle
            // 
            jobtitle.Location = new Point(448, 402);
            jobtitle.Name = "jobtitle";
            jobtitle.Size = new Size(296, 23);
            jobtitle.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 455);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "Salary";
            // 
            // salary
            // 
            salary.Location = new Point(448, 452);
            salary.Name = "salary";
            salary.Size = new Size(296, 23);
            salary.TabIndex = 9;
            // 
            // emphiredate
            // 
            emphiredate.CustomFormat = "yyyy-MM-dd";
            emphiredate.Format = DateTimePickerFormat.Custom;
            emphiredate.Location = new Point(448, 355);
            emphiredate.Name = "emphiredate";
            emphiredate.Size = new Size(296, 23);
            emphiredate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(315, 361);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 12;
            label6.Text = "Hire Date";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(label6);
            Controls.Add(emphiredate);
            Controls.Add(label5);
            Controls.Add(salary);
            Controls.Add(label4);
            Controls.Add(jobtitle);
            Controls.Add(label3);
            Controls.Add(empaddress);
            Controls.Add(label2);
            Controls.Add(empname);
            Controls.Add(label1);
            Controls.Add(AddEmp);
            Controls.Add(cnic);
            Name = "AddEmployee";
            Size = new Size(1678, 919);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cnic;
        private Button AddEmp;
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
    }
}
