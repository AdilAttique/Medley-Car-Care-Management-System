namespace Medley_Car_Care
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            Cust = new NavigationBar();
            Accounts = new Button();
            menuContainer = new FlowLayoutPanel();
            Dboard = new Button();
            Billing = new Button();
            Reports = new Button();
            Inventory = new Button();
            Customers = new Button();
            Employees = new Button();
            LogOut = new Button();
            DashboardPanel = new TableLayoutPanel();
            panel2 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            roundedPanel1 = new RoundedPanel(components);
            mySqlCommand2 = new MySql.Data.MySqlClient.MySqlCommand();
            menuContainer.SuspendLayout();
            DashboardPanel.SuspendLayout();
            panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Cust
            // 
            Cust.BackColor = Color.FromArgb(42, 50, 120);
            Cust.Location = new Point(0, 1);
            Cust.Name = "Cust";
            Cust.Size = new Size(1920, 94);
            Cust.TabIndex = 3;
            // 
            // Accounts
            // 
            Accounts.BackColor = Color.FromArgb(21, 25, 48);
            Accounts.BackgroundImageLayout = ImageLayout.Zoom;
            Accounts.FlatAppearance.BorderSize = 0;
            Accounts.FlatStyle = FlatStyle.Flat;
            Accounts.Font = new Font("Bahnschrift", 14.25F);
            Accounts.ForeColor = Color.Snow;
            Accounts.Image = (Image)resources.GetObject("Accounts.Image");
            Accounts.ImageAlign = ContentAlignment.MiddleLeft;
            Accounts.Location = new Point(3, 186);
            Accounts.Margin = new Padding(3, 20, 3, 3);
            Accounts.Name = "Accounts";
            Accounts.Padding = new Padding(30, 0, 0, 0);
            Accounts.Size = new Size(244, 50);
            Accounts.TabIndex = 5;
            Accounts.Text = "      Accounts";
            Accounts.TextAlign = ContentAlignment.MiddleLeft;
            Accounts.UseVisualStyleBackColor = false;
            Accounts.Click += this.Accounts_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(21, 25, 48);
            menuContainer.Controls.Add(Dboard);
            menuContainer.Controls.Add(Billing);
            menuContainer.Controls.Add(Accounts);
            menuContainer.Controls.Add(Reports);
            menuContainer.Controls.Add(Inventory);
            menuContainer.Controls.Add(Customers);
            menuContainer.Controls.Add(Employees);
            menuContainer.Controls.Add(LogOut);
            menuContainer.Location = new Point(0, 93);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(245, 968);
            menuContainer.TabIndex = 4;
            menuContainer.Paint += this.flowLayoutPanel1_Paint_1;
            // 
            // Dboard
            // 
            Dboard.BackColor = Color.FromArgb(21, 25, 48);
            Dboard.BackgroundImageLayout = ImageLayout.Zoom;
            Dboard.FlatAppearance.BorderSize = 0;
            Dboard.FlatStyle = FlatStyle.Flat;
            Dboard.Font = new Font("Bahnschrift", 14.25F);
            Dboard.ForeColor = Color.Snow;
            Dboard.Image = (Image)resources.GetObject("Dboard.Image");
            Dboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dboard.Location = new Point(3, 40);
            Dboard.Margin = new Padding(3, 40, 3, 3);
            Dboard.Name = "Dboard";
            Dboard.Padding = new Padding(30, 0, 0, 0);
            Dboard.Size = new Size(244, 50);
            Dboard.TabIndex = 5;
            Dboard.Text = "      Dashboard";
            Dboard.TextAlign = ContentAlignment.MiddleLeft;
            Dboard.UseVisualStyleBackColor = false;
            Dboard.Click += this.Dboard_Click;
            // 
            // Billing
            // 
            Billing.BackColor = Color.FromArgb(21, 25, 48);
            Billing.BackgroundImageLayout = ImageLayout.Zoom;
            Billing.FlatAppearance.BorderSize = 0;
            Billing.FlatStyle = FlatStyle.Flat;
            Billing.Font = new Font("Bahnschrift", 14.25F);
            Billing.ForeColor = Color.Snow;
            Billing.Image = (Image)resources.GetObject("Billing.Image");
            Billing.ImageAlign = ContentAlignment.MiddleLeft;
            Billing.Location = new Point(3, 113);
            Billing.Margin = new Padding(3, 20, 3, 3);
            Billing.Name = "Billing";
            Billing.Padding = new Padding(30, 0, 0, 0);
            Billing.Size = new Size(244, 50);
            Billing.TabIndex = 5;
            Billing.Text = "      Billing";
            Billing.TextAlign = ContentAlignment.MiddleLeft;
            Billing.UseVisualStyleBackColor = false;
            Billing.Click += this.billing_Click;
            // 
            // Reports
            // 
            Reports.BackColor = Color.FromArgb(21, 25, 48);
            Reports.BackgroundImageLayout = ImageLayout.Zoom;
            Reports.FlatAppearance.BorderSize = 0;
            Reports.FlatStyle = FlatStyle.Flat;
            Reports.Font = new Font("Bahnschrift", 14.25F);
            Reports.ForeColor = Color.Snow;
            Reports.Image = (Image)resources.GetObject("Reports.Image");
            Reports.ImageAlign = ContentAlignment.MiddleLeft;
            Reports.Location = new Point(3, 259);
            Reports.Margin = new Padding(3, 20, 3, 3);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(30, 0, 0, 0);
            Reports.Size = new Size(244, 50);
            Reports.TabIndex = 5;
            Reports.Text = "      Reports";
            Reports.TextAlign = ContentAlignment.MiddleLeft;
            Reports.UseVisualStyleBackColor = false;
            Reports.Click += this.Reports_Click;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.FromArgb(21, 25, 48);
            Inventory.BackgroundImageLayout = ImageLayout.Zoom;
            Inventory.FlatAppearance.BorderSize = 0;
            Inventory.FlatStyle = FlatStyle.Flat;
            Inventory.Font = new Font("Bahnschrift", 14.25F);
            Inventory.ForeColor = Color.Snow;
            Inventory.Image = (Image)resources.GetObject("Inventory.Image");
            Inventory.ImageAlign = ContentAlignment.MiddleLeft;
            Inventory.Location = new Point(3, 332);
            Inventory.Margin = new Padding(3, 20, 3, 3);
            Inventory.Name = "Inventory";
            Inventory.Padding = new Padding(30, 0, 0, 0);
            Inventory.Size = new Size(244, 50);
            Inventory.TabIndex = 5;
            Inventory.Text = "      Inventory";
            Inventory.TextAlign = ContentAlignment.MiddleLeft;
            Inventory.UseVisualStyleBackColor = false;
            Inventory.Click += this.Inventory_Click;
            // 
            // Customers
            // 
            Customers.BackColor = Color.FromArgb(21, 25, 48);
            Customers.BackgroundImageLayout = ImageLayout.Zoom;
            Customers.FlatAppearance.BorderSize = 0;
            Customers.FlatStyle = FlatStyle.Flat;
            Customers.Font = new Font("Bahnschrift", 14.25F);
            Customers.ForeColor = Color.Snow;
            Customers.Image = (Image)resources.GetObject("Customers.Image");
            Customers.ImageAlign = ContentAlignment.MiddleLeft;
            Customers.Location = new Point(3, 405);
            Customers.Margin = new Padding(3, 20, 3, 3);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(30, 0, 0, 0);
            Customers.Size = new Size(244, 50);
            Customers.TabIndex = 5;
            Customers.Text = "      Customers";
            Customers.TextAlign = ContentAlignment.MiddleLeft;
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += this.Customers_Click;
            // 
            // Employees
            // 
            Employees.BackColor = Color.FromArgb(21, 25, 48);
            Employees.BackgroundImageLayout = ImageLayout.Zoom;
            Employees.FlatAppearance.BorderSize = 0;
            Employees.FlatStyle = FlatStyle.Flat;
            Employees.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employees.ForeColor = Color.Snow;
            Employees.Image = (Image)resources.GetObject("Employees.Image");
            Employees.ImageAlign = ContentAlignment.MiddleLeft;
            Employees.Location = new Point(3, 478);
            Employees.Margin = new Padding(3, 20, 3, 3);
            Employees.Name = "Employees";
            Employees.Padding = new Padding(30, 0, 0, 0);
            Employees.Size = new Size(244, 50);
            Employees.TabIndex = 5;
            Employees.Text = "      Employees";
            Employees.TextAlign = ContentAlignment.MiddleLeft;
            Employees.UseVisualStyleBackColor = false;
            Employees.Click += this.Employees_Click_1;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.FromArgb(21, 25, 48);
            LogOut.BackgroundImageLayout = ImageLayout.Zoom;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Baskerville Old Face", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Snow;
            LogOut.Image = (Image)resources.GetObject("LogOut.Image");
            LogOut.ImageAlign = ContentAlignment.MiddleLeft;
            LogOut.Location = new Point(3, 681);
            LogOut.Margin = new Padding(3, 150, 3, 3);
            LogOut.Name = "LogOut";
            LogOut.Padding = new Padding(30, 0, 0, 0);
            LogOut.Size = new Size(244, 50);
            LogOut.TabIndex = 5;
            LogOut.Text = "      Log Out";
            LogOut.TextAlign = ContentAlignment.MiddleLeft;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += this.LogOut_Click_1;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.FloralWhite;
            DashboardPanel.BackgroundImageLayout = ImageLayout.None;
            DashboardPanel.ColumnCount = 2;
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.53586F));
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.4641409F));
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            DashboardPanel.Controls.Add(panel2, 0, 1);
            DashboardPanel.Controls.Add(roundedPanel1, 0, 0);
            DashboardPanel.Location = new Point(242, 93);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Padding = new Padding(100);
            DashboardPanel.RowCount = 2;
            DashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            DashboardPanel.Size = new Size(1678, 919);
            DashboardPanel.TabIndex = 6;
            DashboardPanel.Paint += this.tableLayoutPanel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(350, 559);
            panel2.Margin = new Padding(250, 100, 100, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(929, 160);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(318, 19);
            button2.Name = "button2";
            button2.Size = new Size(36, 29);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(30, 18);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search here";
            textBox2.Size = new Size(282, 29);
            textBox2.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Gray;
            roundedPanel1.CornerRadius = 30;
            roundedPanel1.Location = new Point(103, 103);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(348, 206);
            roundedPanel1.TabIndex = 2;
            // 
            // mySqlCommand2
            // 
            mySqlCommand2.CacheAge = 0;
            mySqlCommand2.Connection = null;
            mySqlCommand2.EnableCaching = false;
            mySqlCommand2.Transaction = null;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.BackColor = Color.AliceBlue;
            this.ClientSize = new Size(1904, 1008);
            this.Controls.Add(DashboardPanel);
            this.Controls.Add(menuContainer);
            this.Controls.Add(Cust);
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = FormWindowState.Maximized;
            this.Load += this.Dashboard_Load;
            menuContainer.ResumeLayout(false);
            DashboardPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private NavigationBar Cust;
        private Button Accounts;
        private Button Billing;
        private Button Inventory;
        private Button Customers;
        private Button LogOut;
        private Button Employees;
        public FlowLayoutPanel menuContainer;
        private Button Dboard;
        private Button Reports;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel DashboardPanel;
        private Panel panel2;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private Button button2;
        private TextBox textBox2;
        private RoundedPanel roundedPanel1;
    }
}