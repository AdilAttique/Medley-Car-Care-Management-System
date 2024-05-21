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
            menuContainer.SuspendLayout();
            SuspendLayout();
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
            Cust.BackColor = Color.FromArgb(57, 77, 97);
            Cust.Location = new Point(0, 1);
            Cust.Name = "Cust";
            Cust.Size = new Size(1920, 94);
            Cust.TabIndex = 3;
            // 
            // Accounts
            // 
            Accounts.BackColor = Color.FromArgb(47, 65, 81);
            Accounts.BackgroundImageLayout = ImageLayout.Zoom;
            Accounts.FlatAppearance.BorderSize = 0;
            Accounts.FlatStyle = FlatStyle.Flat;
            Accounts.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Accounts.ForeColor = Color.Snow;
            Accounts.Image = (Image)resources.GetObject("Accounts.Image");
            Accounts.ImageAlign = ContentAlignment.MiddleLeft;
            Accounts.Location = new Point(3, 206);
            Accounts.Margin = new Padding(3, 30, 3, 3);
            Accounts.Name = "Accounts";
            Accounts.Padding = new Padding(10, 0, 0, 0);
            Accounts.Size = new Size(244, 50);
            Accounts.TabIndex = 5;
            Accounts.Text = "      Accounts";
            Accounts.TextAlign = ContentAlignment.MiddleLeft;
            Accounts.UseVisualStyleBackColor = false;
            Accounts.Click += Accounts_Click;
            // 
            // menuContainer
            // 
            menuContainer.BackColor = Color.FromArgb(47, 65, 81);
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
            menuContainer.Paint += flowLayoutPanel1_Paint_1;
            // 
            // Dboard
            // 
            Dboard.BackColor = Color.FromArgb(47, 65, 81);
            Dboard.BackgroundImageLayout = ImageLayout.Zoom;
            Dboard.FlatAppearance.BorderSize = 0;
            Dboard.FlatStyle = FlatStyle.Flat;
            Dboard.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dboard.ForeColor = Color.Snow;
            Dboard.Image = (Image)resources.GetObject("Dboard.Image");
            Dboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dboard.Location = new Point(3, 40);
            Dboard.Margin = new Padding(3, 40, 3, 3);
            Dboard.Name = "Dboard";
            Dboard.Padding = new Padding(10, 0, 0, 0);
            Dboard.Size = new Size(244, 50);
            Dboard.TabIndex = 5;
            Dboard.Text = "      Dashboard";
            Dboard.TextAlign = ContentAlignment.MiddleLeft;
            Dboard.UseVisualStyleBackColor = false;
            Dboard.Click += Dboard_Click;
            // 
            // Billing
            // 
            Billing.BackColor = Color.FromArgb(47, 65, 81);
            Billing.BackgroundImageLayout = ImageLayout.Zoom;
            Billing.FlatAppearance.BorderSize = 0;
            Billing.FlatStyle = FlatStyle.Flat;
            Billing.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Billing.ForeColor = Color.Snow;
            Billing.Image = (Image)resources.GetObject("Billing.Image");
            Billing.ImageAlign = ContentAlignment.MiddleLeft;
            Billing.Location = new Point(3, 123);
            Billing.Margin = new Padding(3, 30, 3, 3);
            Billing.Name = "Billing";
            Billing.Padding = new Padding(10, 0, 0, 0);
            Billing.Size = new Size(244, 50);
            Billing.TabIndex = 5;
            Billing.Text = "      Billing";
            Billing.TextAlign = ContentAlignment.MiddleLeft;
            Billing.UseVisualStyleBackColor = false;
            Billing.Click += billing_Click;
            // 
            // Reports
            // 
            Reports.BackColor = Color.FromArgb(47, 65, 81);
            Reports.BackgroundImageLayout = ImageLayout.Zoom;
            Reports.FlatAppearance.BorderSize = 0;
            Reports.FlatStyle = FlatStyle.Flat;
            Reports.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reports.ForeColor = Color.Snow;
            Reports.Image = (Image)resources.GetObject("Reports.Image");
            Reports.ImageAlign = ContentAlignment.MiddleLeft;
            Reports.Location = new Point(3, 289);
            Reports.Margin = new Padding(3, 30, 3, 3);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(10, 0, 0, 0);
            Reports.Size = new Size(244, 50);
            Reports.TabIndex = 5;
            Reports.Text = "      Reports";
            Reports.TextAlign = ContentAlignment.MiddleLeft;
            Reports.UseVisualStyleBackColor = false;
            Reports.Click += Reports_Click;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.FromArgb(47, 65, 81);
            Inventory.BackgroundImageLayout = ImageLayout.Zoom;
            Inventory.FlatAppearance.BorderSize = 0;
            Inventory.FlatStyle = FlatStyle.Flat;
            Inventory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Inventory.ForeColor = Color.Snow;
            Inventory.Image = (Image)resources.GetObject("Inventory.Image");
            Inventory.ImageAlign = ContentAlignment.MiddleLeft;
            Inventory.Location = new Point(3, 372);
            Inventory.Margin = new Padding(3, 30, 3, 3);
            Inventory.Name = "Inventory";
            Inventory.Padding = new Padding(10, 0, 0, 0);
            Inventory.Size = new Size(244, 50);
            Inventory.TabIndex = 5;
            Inventory.Text = "      Inventory";
            Inventory.TextAlign = ContentAlignment.MiddleLeft;
            Inventory.UseVisualStyleBackColor = false;
            Inventory.Click += Inventory_Click;
            // 
            // Customers
            // 
            Customers.BackColor = Color.FromArgb(47, 65, 81);
            Customers.BackgroundImageLayout = ImageLayout.Zoom;
            Customers.FlatAppearance.BorderSize = 0;
            Customers.FlatStyle = FlatStyle.Flat;
            Customers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customers.ForeColor = Color.Snow;
            Customers.Image = (Image)resources.GetObject("Customers.Image");
            Customers.ImageAlign = ContentAlignment.MiddleLeft;
            Customers.Location = new Point(3, 455);
            Customers.Margin = new Padding(3, 30, 3, 3);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(10, 0, 0, 0);
            Customers.Size = new Size(244, 50);
            Customers.TabIndex = 5;
            Customers.Text = "      Customers";
            Customers.TextAlign = ContentAlignment.MiddleLeft;
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // Employees
            // 
            Employees.BackColor = Color.FromArgb(47, 65, 81);
            Employees.BackgroundImageLayout = ImageLayout.Zoom;
            Employees.FlatAppearance.BorderSize = 0;
            Employees.FlatStyle = FlatStyle.Flat;
            Employees.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employees.ForeColor = Color.Snow;
            Employees.Image = (Image)resources.GetObject("Employees.Image");
            Employees.ImageAlign = ContentAlignment.MiddleLeft;
            Employees.Location = new Point(3, 538);
            Employees.Margin = new Padding(3, 30, 3, 3);
            Employees.Name = "Employees";
            Employees.Padding = new Padding(10, 0, 0, 0);
            Employees.Size = new Size(244, 50);
            Employees.TabIndex = 5;
            Employees.Text = "      Employees";
            Employees.TextAlign = ContentAlignment.MiddleLeft;
            Employees.UseVisualStyleBackColor = false;
            Employees.Click += Employees_Click_1;
            // 
            // LogOut
            // 
            LogOut.BackColor = Color.FromArgb(47, 65, 81);
            LogOut.BackgroundImageLayout = ImageLayout.Zoom;
            LogOut.FlatAppearance.BorderSize = 0;
            LogOut.FlatStyle = FlatStyle.Flat;
            LogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Snow;
            LogOut.Image = (Image)resources.GetObject("LogOut.Image");
            LogOut.ImageAlign = ContentAlignment.MiddleLeft;
            LogOut.Location = new Point(3, 741);
            LogOut.Margin = new Padding(3, 150, 3, 3);
            LogOut.Name = "LogOut";
            LogOut.Padding = new Padding(10, 0, 0, 0);
            LogOut.Size = new Size(244, 50);
            LogOut.TabIndex = 5;
            LogOut.Text = "      Log Out";
            LogOut.TextAlign = ContentAlignment.MiddleLeft;
            LogOut.UseVisualStyleBackColor = false;
            LogOut.Click += LogOut_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1904, 1001);
            Controls.Add(menuContainer);
            Controls.Add(Cust);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private NavigationBar Cust;
        private Button Accounts;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Billing;
        private Button button2;
        private Button Inventory;
        private Button Customers;
        private Button LogOut;
        private Button Employees;
        public FlowLayoutPanel menuContainer;
        private Button Dboard;
        private Button Reports;
    }
}