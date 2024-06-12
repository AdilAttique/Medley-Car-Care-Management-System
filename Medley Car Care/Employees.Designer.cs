namespace Medley_Car_Care
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            menu1 = new Menu();
            navigationBar1 = new NavigationBar();
            EmpSearchButton = new Button();
            EmployeeList = new Button();
            AddNewEmp = new Button();
            EmployeeNavBar = new Panel();
            mainPanel = new Panel();
            EmployeeNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Location = new Point(-560, -199);
            menu1.Name = "menu1";
            menu1.Size = new Size(252, 940);
            menu1.TabIndex = 6;
            // 
            // navigationBar1
            // 
            navigationBar1.BackColor = Color.FromArgb(57, 77, 97);
            navigationBar1.Location = new Point(-560, -291);
            navigationBar1.Name = "navigationBar1";
            navigationBar1.Size = new Size(1920, 94);
            navigationBar1.TabIndex = 5;
            // 
            // EmpSearchButton
            // 
            EmpSearchButton.BackColor = Color.DarkBlue;
            EmpSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            EmpSearchButton.Dock = DockStyle.Left;
            EmpSearchButton.FlatAppearance.BorderSize = 0;
            EmpSearchButton.FlatStyle = FlatStyle.Flat;
            EmpSearchButton.Font = new Font("Bahnschrift", 14.25F);
            EmpSearchButton.ForeColor = Color.Snow;
            EmpSearchButton.Image = (Image)resources.GetObject("EmpSearchButton.Image");
            EmpSearchButton.ImageAlign = ContentAlignment.MiddleLeft;
            EmpSearchButton.Location = new Point(0, 0);
            EmpSearchButton.Margin = new Padding(3, 40, 3, 3);
            EmpSearchButton.Name = "EmpSearchButton";
            EmpSearchButton.Padding = new Padding(30, 0, 0, 0);
            EmpSearchButton.Size = new Size(244, 67);
            EmpSearchButton.TabIndex = 6;
            EmpSearchButton.Text = "      Search";
            EmpSearchButton.TextAlign = ContentAlignment.MiddleLeft;
            EmpSearchButton.UseVisualStyleBackColor = false;
            EmpSearchButton.Click += EmpSearchButton_Click;
            // 
            // EmployeeList
            // 
            EmployeeList.BackColor = Color.DarkBlue;
            EmployeeList.BackgroundImageLayout = ImageLayout.Zoom;
            EmployeeList.Dock = DockStyle.Left;
            EmployeeList.FlatAppearance.BorderSize = 0;
            EmployeeList.FlatStyle = FlatStyle.Flat;
            EmployeeList.Font = new Font("Bahnschrift", 14.25F);
            EmployeeList.ForeColor = Color.Snow;
            EmployeeList.Image = (Image)resources.GetObject("EmployeeList.Image");
            EmployeeList.ImageAlign = ContentAlignment.MiddleLeft;
            EmployeeList.Location = new Point(244, 0);
            EmployeeList.Margin = new Padding(3, 40, 3, 3);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.Padding = new Padding(30, 0, 0, 0);
            EmployeeList.Size = new Size(244, 67);
            EmployeeList.TabIndex = 7;
            EmployeeList.Text = "      List";
            EmployeeList.TextAlign = ContentAlignment.MiddleLeft;
            EmployeeList.UseVisualStyleBackColor = false;
            EmployeeList.Click += EmployeeList_Click;
            // 
            // AddNewEmp
            // 
            AddNewEmp.BackColor = Color.DarkBlue;
            AddNewEmp.BackgroundImageLayout = ImageLayout.Zoom;
            AddNewEmp.Dock = DockStyle.Left;
            AddNewEmp.FlatAppearance.BorderSize = 0;
            AddNewEmp.FlatStyle = FlatStyle.Flat;
            AddNewEmp.Font = new Font("Bahnschrift", 14.25F);
            AddNewEmp.ForeColor = Color.Snow;
            AddNewEmp.Image = (Image)resources.GetObject("AddNewEmp.Image");
            AddNewEmp.ImageAlign = ContentAlignment.MiddleLeft;
            AddNewEmp.Location = new Point(488, 0);
            AddNewEmp.Margin = new Padding(3, 40, 3, 3);
            AddNewEmp.Name = "AddNewEmp";
            AddNewEmp.Padding = new Padding(30, 0, 0, 0);
            AddNewEmp.Size = new Size(244, 67);
            AddNewEmp.TabIndex = 8;
            AddNewEmp.Text = "      Add New";
            AddNewEmp.TextAlign = ContentAlignment.MiddleLeft;
            AddNewEmp.UseVisualStyleBackColor = false;
            AddNewEmp.Click += AddNewEmp_Click;
            // 
            // EmployeeNavBar
            // 
            EmployeeNavBar.BackColor = Color.DarkBlue;
            EmployeeNavBar.Controls.Add(AddNewEmp);
            EmployeeNavBar.Controls.Add(EmployeeList);
            EmployeeNavBar.Controls.Add(EmpSearchButton);
            EmployeeNavBar.Dock = DockStyle.Top;
            EmployeeNavBar.Location = new Point(0, 0);
            EmployeeNavBar.Margin = new Padding(0);
            EmployeeNavBar.Name = "EmployeeNavBar";
            EmployeeNavBar.Size = new Size(1904, 67);
            EmployeeNavBar.TabIndex = 7;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.GhostWhite;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 67);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 934);
            mainPanel.TabIndex = 8;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(mainPanel);
            Controls.Add(EmployeeNavBar);
            Controls.Add(menu1);
            Controls.Add(navigationBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            EmployeeNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
        private Button EmpSearchButton;
        private Button EmployeeList;
        private Button AddNewEmp;
        private Panel EmployeeNavBar;
        private Panel mainPanel;
    }
}