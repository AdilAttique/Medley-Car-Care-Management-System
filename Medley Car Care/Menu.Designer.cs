namespace Medley_Car_Care
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Dashboard = new ToolStripMenuItem();
            MenuBar = new MenuStrip();
            Billing = new ToolStripMenuItem();
            Accounts = new ToolStripMenuItem();
            Reports = new ToolStripMenuItem();
            Inventory = new ToolStripMenuItem();
            Customer = new ToolStripMenuItem();
            Employees = new ToolStripMenuItem();
            LogOut = new ToolStripMenuItem();
            MenuBar.SuspendLayout();
            SuspendLayout();
            // 
            // Dashboard
            // 
            Dashboard.BackColor = Color.FromArgb(47, 65, 81);
            Dashboard.BackgroundImageLayout = ImageLayout.Zoom;
            Dashboard.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dashboard.ForeColor = Color.Snow;
            Dashboard.Image = (Image)resources.GetObject("Dashboard.Image");
            Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            Dashboard.ImageTransparentColor = Color.Transparent;
            Dashboard.Margin = new Padding(0, 40, 0, 0);
            Dashboard.Name = "Dashboard";
            Dashboard.Padding = new Padding(0, 4, 75, 0);
            Dashboard.Size = new Size(256, 45);
            Dashboard.Text = "Dashboard ";
            // 
            // MenuBar
            // 
            MenuBar.BackColor = Color.FromArgb(47, 65, 81);
            MenuBar.Dock = DockStyle.Fill;
            MenuBar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuBar.GripMargin = new Padding(2);
            MenuBar.GripStyle = ToolStripGripStyle.Visible;
            MenuBar.ImageScalingSize = new Size(23, 23);
            MenuBar.Items.AddRange(new ToolStripItem[] { Dashboard, Billing, Accounts, Reports, Inventory, Customer, Employees, LogOut });
            MenuBar.LayoutStyle = ToolStripLayoutStyle.Flow;
            MenuBar.Location = new Point(0, 0);
            MenuBar.Margin = new Padding(5, 0, 0, 0);
            MenuBar.Name = "MenuBar";
            MenuBar.Padding = new Padding(3, 2, 2, 2);
            MenuBar.Size = new Size(252, 950);
            MenuBar.TabIndex = 0;
            MenuBar.Text = "MenuBar";
            MenuBar.ItemClicked += MenuBar_ItemClicked;
            // 
            // Billing
            // 
            Billing.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Billing.ForeColor = Color.Snow;
            Billing.Image = (Image)resources.GetObject("Billing.Image");
            Billing.ImageTransparentColor = Color.Transparent;
            Billing.Margin = new Padding(0, 40, 0, 0);
            Billing.Name = "Billing";
            Billing.Padding = new Padding(0);
            Billing.Size = new Size(265, 41);
            Billing.Text = "Billing                     ";
            // 
            // Accounts
            // 
            Accounts.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Accounts.ForeColor = Color.Snow;
            Accounts.Image = (Image)resources.GetObject("Accounts.Image");
            Accounts.ImageTransparentColor = Color.Transparent;
            Accounts.Margin = new Padding(0, 40, 0, 0);
            Accounts.Name = "Accounts";
            Accounts.RightToLeft = RightToLeft.No;
            Accounts.Size = new Size(257, 41);
            Accounts.Text = "Accounts              ";
            Accounts.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // Reports
            // 
            Reports.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reports.ForeColor = Color.Snow;
            Reports.Image = (Image)resources.GetObject("Reports.Image");
            Reports.Margin = new Padding(0, 40, 0, 0);
            Reports.Name = "Reports";
            Reports.Size = new Size(254, 41);
            Reports.Text = "Reports                ";
            // 
            // Inventory
            // 
            Inventory.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Inventory.ForeColor = Color.Snow;
            Inventory.Image = (Image)resources.GetObject("Inventory.Image");
            Inventory.Margin = new Padding(0, 40, 0, 0);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(261, 41);
            Inventory.Text = "Inventory              ";
            // 
            // Customer
            // 
            Customer.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer.ForeColor = Color.Snow;
            Customer.Image = (Image)resources.GetObject("Customer.Image");
            Customer.Margin = new Padding(0, 40, 0, 0);
            Customer.Name = "Customer";
            Customer.Size = new Size(254, 41);
            Customer.Text = "Customers           ";
            // 
            // Employees
            // 
            Employees.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Employees.ForeColor = Color.Snow;
            Employees.Image = (Image)resources.GetObject("Employees.Image");
            Employees.Margin = new Padding(0, 40, 0, 0);
            Employees.Name = "Employees";
            Employees.Size = new Size(264, 41);
            Employees.Text = "Employees            ";
            // 
            // LogOut
            // 
            LogOut.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOut.ForeColor = Color.Snow;
            LogOut.Image = (Image)resources.GetObject("LogOut.Image");
            LogOut.Margin = new Padding(0, 200, 0, 0);
            LogOut.Name = "LogOut";
            LogOut.Size = new Size(274, 41);
            LogOut.Text = "Log Out                  ";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MenuBar);
            Name = "Menu";
            Size = new Size(252, 950);
            MenuBar.ResumeLayout(false);
            MenuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem Dashboard;
        private MenuStrip MenuBar;
        private ToolStripMenuItem Billing;
        private ToolStripMenuItem Accounts;
        private ToolStripMenuItem Reports;
        private ToolStripMenuItem Inventory;
        private ToolStripMenuItem Customer;
        private ToolStripMenuItem Employees;
        private ToolStripMenuItem LogOut;
    }
}
