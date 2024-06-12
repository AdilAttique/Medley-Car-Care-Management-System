namespace Medley_Car_Care
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            panel1 = new Panel();
            CustomerNavBar = new Panel();
            AddNew = new Button();
            CustomerList = new Button();
            CustSearchButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            CustomerNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(CustomerNavBar);
            panel1.Controls.Add(mainPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 1001);
            panel1.TabIndex = 1;
            // 
            // CustomerNavBar
            // 
            CustomerNavBar.BackColor = Color.DarkBlue;
            CustomerNavBar.Controls.Add(AddNew);
            CustomerNavBar.Controls.Add(CustomerList);
            CustomerNavBar.Controls.Add(CustSearchButton);
            CustomerNavBar.Dock = DockStyle.Top;
            CustomerNavBar.Location = new Point(0, 0);
            CustomerNavBar.Margin = new Padding(0);
            CustomerNavBar.Name = "CustomerNavBar";
            CustomerNavBar.Size = new Size(1904, 67);
            CustomerNavBar.TabIndex = 0;
            // 
            // AddNew
            // 
            AddNew.BackColor = Color.DarkBlue;
            AddNew.BackgroundImageLayout = ImageLayout.Zoom;
            AddNew.Dock = DockStyle.Left;
            AddNew.FlatAppearance.BorderSize = 0;
            AddNew.FlatStyle = FlatStyle.Flat;
            AddNew.Font = new Font("Bahnschrift", 14.25F);
            AddNew.ForeColor = Color.Snow;
            AddNew.Image = (Image)resources.GetObject("AddNew.Image");
            AddNew.ImageAlign = ContentAlignment.MiddleLeft;
            AddNew.Location = new Point(488, 0);
            AddNew.Margin = new Padding(3, 40, 3, 3);
            AddNew.Name = "AddNew";
            AddNew.Padding = new Padding(30, 0, 0, 0);
            AddNew.Size = new Size(244, 67);
            AddNew.TabIndex = 8;
            AddNew.Text = "      Add New";
            AddNew.TextAlign = ContentAlignment.MiddleLeft;
            AddNew.UseVisualStyleBackColor = false;
            AddNew.Click += AddNew_Click;
            // 
            // CustomerList
            // 
            CustomerList.BackColor = Color.DarkBlue;
            CustomerList.BackgroundImageLayout = ImageLayout.Zoom;
            CustomerList.Dock = DockStyle.Left;
            CustomerList.FlatAppearance.BorderSize = 0;
            CustomerList.FlatStyle = FlatStyle.Flat;
            CustomerList.Font = new Font("Bahnschrift", 14.25F);
            CustomerList.ForeColor = Color.Snow;
            CustomerList.Image = (Image)resources.GetObject("CustomerList.Image");
            CustomerList.ImageAlign = ContentAlignment.MiddleLeft;
            CustomerList.Location = new Point(244, 0);
            CustomerList.Margin = new Padding(3, 40, 3, 3);
            CustomerList.Name = "CustomerList";
            CustomerList.Padding = new Padding(30, 0, 0, 0);
            CustomerList.Size = new Size(244, 67);
            CustomerList.TabIndex = 7;
            CustomerList.Text = "      List";
            CustomerList.TextAlign = ContentAlignment.MiddleLeft;
            CustomerList.UseVisualStyleBackColor = false;
            CustomerList.Click += CustomerList_Click;
            // 
            // CustSearchButton
            // 
            CustSearchButton.BackColor = Color.DarkBlue;
            CustSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            CustSearchButton.Dock = DockStyle.Left;
            CustSearchButton.FlatAppearance.BorderSize = 0;
            CustSearchButton.FlatStyle = FlatStyle.Flat;
            CustSearchButton.Font = new Font("Bahnschrift", 14.25F);
            CustSearchButton.ForeColor = Color.Snow;
            CustSearchButton.Image = (Image)resources.GetObject("CustSearchButton.Image");
            CustSearchButton.ImageAlign = ContentAlignment.MiddleLeft;
            CustSearchButton.Location = new Point(0, 0);
            CustSearchButton.Margin = new Padding(3, 40, 3, 3);
            CustSearchButton.Name = "CustSearchButton";
            CustSearchButton.Padding = new Padding(30, 0, 0, 0);
            CustSearchButton.Size = new Size(244, 67);
            CustSearchButton.TabIndex = 6;
            CustSearchButton.Text = "      Search";
            CustSearchButton.TextAlign = ContentAlignment.MiddleLeft;
            CustSearchButton.UseVisualStyleBackColor = false;
            CustSearchButton.Click += CustSearchButton_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.GhostWhite;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 1001);
            mainPanel.TabIndex = 1;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            panel1.ResumeLayout(false);
            CustomerNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
        private Panel panel1;
        private Panel CustomerNavBar;
        private Button AddNew;
        private Button CustomerList;
        private Button CustSearchButton;
        private Panel mainPanel;
    }
}