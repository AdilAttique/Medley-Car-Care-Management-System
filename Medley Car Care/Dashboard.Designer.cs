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
            Syncfusion.Windows.Forms.Chart.ChartCustomPoint chartCustomPoint1 = new Syncfusion.Windows.Forms.Chart.ChartCustomPoint();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3dItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
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
            panel1 = new Panel();
            TodaysCustomers = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            CustomerCounter = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            CurrencyBox = new Syncfusion.Windows.Forms.Tools.GradientPanelExt();
            Revenue = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            panel3 = new Panel();
            DataGraph = new Syncfusion.Windows.Forms.Chart.ChartControl();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            QuickAccessBar = new TabPage();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button3 = new Button();
            textBox4 = new TextBox();
            tabPage2 = new TabPage();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            button1 = new Button();
            textBox3 = new TextBox();
            gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            Time = new Label();
            MedleyName = new Label();
            menuContainer.SuspendLayout();
            DashboardPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TodaysCustomers).BeginInit();
            TodaysCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CurrencyBox).BeginInit();
            CurrencyBox.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            QuickAccessBar.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
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
            Accounts.Click += Accounts_Click;
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
            menuContainer.Paint += menuContainer_Paint;
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
            Dboard.Click += Dboard_Click;
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
            Billing.Click += billing_Click;
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
            Reports.Click += Reports_Click;
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
            Inventory.Click += Inventory_Click;
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
            Customers.Click += Customers_Click;
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
            Employees.Click += Employees_Click_1;
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
            LogOut.Click += LogOut_Click_1;
            // 
            // DashboardPanel
            // 
            DashboardPanel.BackColor = Color.GhostWhite;
            DashboardPanel.BackgroundImageLayout = ImageLayout.None;
            DashboardPanel.ColumnCount = 1;
            DashboardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DashboardPanel.Controls.Add(panel1, 0, 0);
            DashboardPanel.Controls.Add(panel3, 0, 2);
            DashboardPanel.Controls.Add(panel2, 0, 1);
            DashboardPanel.Location = new Point(242, 93);
            DashboardPanel.Name = "DashboardPanel";
            DashboardPanel.Padding = new Padding(150, 30, 50, 50);
            DashboardPanel.RowCount = 3;
            DashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DashboardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            DashboardPanel.Size = new Size(1678, 919);
            DashboardPanel.TabIndex = 6;
            DashboardPanel.Paint += tableLayoutPanel1_Paint_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(TodaysCustomers);
            panel1.Controls.Add(CurrencyBox);
            panel1.Controls.Add(autoLabel1);
            panel1.Location = new Point(153, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 266);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // TodaysCustomers
            // 
            TodaysCustomers.BackColor = Color.Lavender;
            TodaysCustomers.Border = new Padding(12);
            TodaysCustomers.BorderStyle = BorderStyle.None;
            TodaysCustomers.Controls.Add(CustomerCounter);
            TodaysCustomers.Controls.Add(autoLabel3);
            TodaysCustomers.Location = new Point(657, 42);
            TodaysCustomers.Name = "TodaysCustomers";
            TodaysCustomers.Size = new Size(334, 196);
            TodaysCustomers.TabIndex = 4;
            // 
            // CustomerCounter
            // 
            CustomerCounter.Font = new Font("Bahnschrift Condensed", 21.75F);
            CustomerCounter.Location = new Point(155, 76);
            CustomerCounter.Name = "CustomerCounter";
            CustomerCounter.Size = new Size(27, 35);
            CustomerCounter.TabIndex = 4;
            CustomerCounter.Text = "0";
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Bahnschrift SemiCondensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel3.Location = new Point(62, 22);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(216, 25);
            autoLabel3.TabIndex = 3;
            autoLabel3.Text = "Customers Served Today";
            // 
            // CurrencyBox
            // 
            CurrencyBox.BackColor = Color.Lavender;
            CurrencyBox.Border = new Padding(12);
            CurrencyBox.BorderStyle = BorderStyle.None;
            CurrencyBox.Controls.Add(Revenue);
            CurrencyBox.Controls.Add(autoLabel2);
            CurrencyBox.Location = new Point(82, 42);
            CurrencyBox.Name = "CurrencyBox";
            CurrencyBox.Size = new Size(334, 196);
            CurrencyBox.TabIndex = 3;
            // 
            // Revenue
            // 
            Revenue.Font = new Font("Bahnschrift Condensed", 21.75F);
            Revenue.Location = new Point(136, 76);
            Revenue.Name = "Revenue";
            Revenue.Size = new Size(56, 35);
            Revenue.TabIndex = 4;
            Revenue.Text = "Rs 0";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.Location = new Point(86, 22);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(167, 29);
            autoLabel2.TabIndex = 3;
            autoLabel2.Text = "Today's Revenue";
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 15.75F, FontStyle.Bold);
            autoLabel1.Location = new Point(0, 0);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(207, 25);
            autoLabel1.TabIndex = 2;
            autoLabel1.Text = "Dashboard Overview";
            // 
            // panel3
            // 
            panel3.Controls.Add(DataGraph);
            panel3.Location = new Point(153, 591);
            panel3.Name = "panel3";
            panel3.Size = new Size(1472, 258);
            panel3.TabIndex = 4;
            // 
            // DataGraph
            // 
            DataGraph.BorderAppearance.BaseColor = Color.Black;
            DataGraph.BorderAppearance.Interior.ForeColor = Color.Gray;
            DataGraph.ChartArea.CursorLocation = new Point(0, 0);
            DataGraph.ChartArea.CursorReDraw = false;
            DataGraph.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            chartCustomPoint1.Font.Facename = "Segoe UI";
            DataGraph.CustomPoints.Add(chartCustomPoint1);
            DataGraph.IsWindowLess = false;
            // 
            // 
            // 
            DataGraph.Legend.Location = new Point(668, 31);
            DataGraph.Localize = null;
            DataGraph.Location = new Point(129, 6);
            DataGraph.Name = "DataGraph";
            DataGraph.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            DataGraph.PrimaryXAxis.Margin = true;
            DataGraph.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            DataGraph.PrimaryYAxis.Margin = true;
            DataGraph.Size = new Size(777, 249);
            DataGraph.TabIndex = 2;
            // 
            // 
            // 
            DataGraph.Title.Name = "Default";
            DataGraph.ToolBar.BackColor = Color.SlateGray;
            DataGraph.ToolBar.EnableDefaultItems = false;
            DataGraph.ToolBar.Items.Add(chartToolBarSaveItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarCopyItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarPrintItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarSplitter1);
            DataGraph.ToolBar.Items.Add(chartToolBarPaletteItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarStyleItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarTypeItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarSeries3dItem1);
            DataGraph.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            DataGraph.VisualTheme = "";
            DataGraph.Zooming.Border.BackColor = Color.Transparent;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Location = new Point(153, 312);
            panel2.Name = "panel2";
            panel2.Size = new Size(1472, 258);
            panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(QuickAccessBar);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1226, 248);
            tabControl1.TabIndex = 1;
            // 
            // QuickAccessBar
            // 
            QuickAccessBar.BorderStyle = BorderStyle.FixedSingle;
            QuickAccessBar.Controls.Add(autoLabel5);
            QuickAccessBar.Controls.Add(button3);
            QuickAccessBar.Controls.Add(textBox4);
            QuickAccessBar.Location = new Point(4, 24);
            QuickAccessBar.Name = "QuickAccessBar";
            QuickAccessBar.Padding = new Padding(3);
            QuickAccessBar.Size = new Size(1218, 220);
            QuickAccessBar.TabIndex = 0;
            QuickAccessBar.Text = "Inventory";
            QuickAccessBar.UseVisualStyleBackColor = true;
            // 
            // autoLabel5
            // 
            autoLabel5.Dock = DockStyle.Right;
            autoLabel5.Font = new Font("Bahnschrift Light Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel5.Location = new Point(1120, 3);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(93, 23);
            autoLabel5.TabIndex = 6;
            autoLabel5.Text = "Quick Access";
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(294, 7);
            button3.Name = "button3";
            button3.Size = new Size(36, 29);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(6, 6);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Search here";
            textBox4.Size = new Size(282, 29);
            textBox4.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(autoLabel4);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1218, 220);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customer";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // autoLabel4
            // 
            autoLabel4.Dock = DockStyle.Right;
            autoLabel4.Font = new Font("Bahnschrift Light Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLabel4.Location = new Point(1120, 3);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(93, 23);
            autoLabel4.TabIndex = 7;
            autoLabel4.Text = "Quick Access";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(294, 7);
            button1.Name = "button1";
            button1.Size = new Size(36, 29);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(6, 6);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Search here";
            textBox3.Size = new Size(282, 29);
            textBox3.TabIndex = 4;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(42, 50, 120);
            gradientPanel1.BorderStyle = BorderStyle.None;
            gradientPanel1.Controls.Add(Time);
            gradientPanel1.Controls.Add(MedleyName);
            gradientPanel1.Dock = DockStyle.Top;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1904, 96);
            gradientPanel1.TabIndex = 8;
            gradientPanel1.Paint += gradientPanel1_Paint;
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.ForeColor = Color.Snow;
            Time.Location = new Point(1559, 31);
            Time.Name = "Time";
            Time.Size = new Size(308, 32);
            Time.TabIndex = 5;
            Time.Text = "Sun, 19 May, 2024, 6:40 PM";
            Time.Click += Time_Click;
            // 
            // MedleyName
            // 
            MedleyName.AutoSize = true;
            MedleyName.BackColor = Color.Transparent;
            MedleyName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedleyName.ForeColor = Color.Snow;
            MedleyName.Location = new Point(31, 22);
            MedleyName.Name = "MedleyName";
            MedleyName.Size = new Size(214, 55);
            MedleyName.TabIndex = 4;
            MedleyName.Text = "MEDLEY";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1904, 1008);
            Controls.Add(menuContainer);
            Controls.Add(DashboardPanel);
            Controls.Add(gradientPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            menuContainer.ResumeLayout(false);
            DashboardPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TodaysCustomers).EndInit();
            TodaysCustomers.ResumeLayout(false);
            TodaysCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CurrencyBox).EndInit();
            CurrencyBox.ResumeLayout(false);
            CurrencyBox.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            QuickAccessBar.ResumeLayout(false);
            QuickAccessBar.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gradientPanel1).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand2;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage QuickAccessBar;
        private TabPage tabPage2;
        private Button button3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox3;
        private Panel panel3;
        private Panel panel2;
        private Syncfusion.Windows.Forms.Chart.ChartControl DataGraph;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt CurrencyBox;
        private Syncfusion.Windows.Forms.Tools.GradientPanelExt TodaysCustomers;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel CustomerCounter;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel Revenue;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Label MedleyName;
        private Label Time;
    }
}