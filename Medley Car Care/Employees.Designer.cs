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
            panel1 = new Panel();
            InvNavBar = new Panel();
            UpdateButton = new Button();
            StockButton = new Button();
            InvSearchButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            InvNavBar.SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.Lavender;
            panel1.Controls.Add(InvNavBar);
            panel1.Controls.Add(mainPanel);
            panel1.Location = new Point(242, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1678, 919);
            panel1.TabIndex = 7;
            // 
            // InvNavBar
            // 
            InvNavBar.BackColor = Color.DarkBlue;
            InvNavBar.Controls.Add(UpdateButton);
            InvNavBar.Controls.Add(StockButton);
            InvNavBar.Controls.Add(InvSearchButton);
            InvNavBar.Dock = DockStyle.Top;
            InvNavBar.Location = new Point(0, 0);
            InvNavBar.Margin = new Padding(0);
            InvNavBar.Name = "InvNavBar";
            InvNavBar.Size = new Size(1678, 67);
            InvNavBar.TabIndex = 0;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.DarkBlue;
            UpdateButton.BackgroundImageLayout = ImageLayout.Zoom;
            UpdateButton.Dock = DockStyle.Left;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Bahnschrift", 14.25F);
            UpdateButton.ForeColor = Color.Snow;
            UpdateButton.Image = (Image)resources.GetObject("UpdateButton.Image");
            UpdateButton.ImageAlign = ContentAlignment.MiddleLeft;
            UpdateButton.Location = new Point(488, 0);
            UpdateButton.Margin = new Padding(3, 40, 3, 3);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Padding = new Padding(30, 0, 0, 0);
            UpdateButton.Size = new Size(244, 67);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "      Update";
            UpdateButton.TextAlign = ContentAlignment.MiddleLeft;
            UpdateButton.UseVisualStyleBackColor = false;
            // 
            // StockButton
            // 
            StockButton.BackColor = Color.DarkBlue;
            StockButton.BackgroundImageLayout = ImageLayout.Zoom;
            StockButton.Dock = DockStyle.Left;
            StockButton.FlatAppearance.BorderSize = 0;
            StockButton.FlatStyle = FlatStyle.Flat;
            StockButton.Font = new Font("Bahnschrift", 14.25F);
            StockButton.ForeColor = Color.Snow;
            StockButton.Image = (Image)resources.GetObject("StockButton.Image");
            StockButton.ImageAlign = ContentAlignment.MiddleLeft;
            StockButton.Location = new Point(244, 0);
            StockButton.Margin = new Padding(3, 40, 3, 3);
            StockButton.Name = "StockButton";
            StockButton.Padding = new Padding(30, 0, 0, 0);
            StockButton.Size = new Size(244, 67);
            StockButton.TabIndex = 7;
            StockButton.Text = "      Stock";
            StockButton.TextAlign = ContentAlignment.MiddleLeft;
            StockButton.UseVisualStyleBackColor = false;
            // 
            // InvSearchButton
            // 
            InvSearchButton.BackColor = Color.DarkBlue;
            InvSearchButton.BackgroundImageLayout = ImageLayout.Zoom;
            InvSearchButton.Dock = DockStyle.Left;
            InvSearchButton.FlatAppearance.BorderSize = 0;
            InvSearchButton.FlatStyle = FlatStyle.Flat;
            InvSearchButton.Font = new Font("Bahnschrift", 14.25F);
            InvSearchButton.ForeColor = Color.Snow;
            InvSearchButton.Image = (Image)resources.GetObject("InvSearchButton.Image");
            InvSearchButton.ImageAlign = ContentAlignment.MiddleLeft;
            InvSearchButton.Location = new Point(0, 0);
            InvSearchButton.Margin = new Padding(3, 40, 3, 3);
            InvSearchButton.Name = "InvSearchButton";
            InvSearchButton.Padding = new Padding(30, 0, 0, 0);
            InvSearchButton.Size = new Size(244, 67);
            InvSearchButton.TabIndex = 6;
            InvSearchButton.Text = "      Search";
            InvSearchButton.TextAlign = ContentAlignment.MiddleLeft;
            InvSearchButton.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.GhostWhite;
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 66);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1678, 853);
            mainPanel.TabIndex = 1;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(panel1);
            Controls.Add(menu1);
            Controls.Add(navigationBar1);
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            panel1.ResumeLayout(false);
            InvNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
        private Panel panel1;
        private Panel InvNavBar;
        private Button UpdateButton;
        private Button StockButton;
        private Button InvSearchButton;
        private Panel mainPanel;
    }
}