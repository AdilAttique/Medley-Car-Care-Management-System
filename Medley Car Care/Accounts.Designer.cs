namespace Medley_Car_Care
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            panel1 = new Panel();
            AccountsNavBar = new Panel();
            AddAccounts = new Button();
            CurrAccoutsButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            AccountsNavBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(mainPanel);
            panel1.Controls.Add(AccountsNavBar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 1001);
            panel1.TabIndex = 0;
            // 
            // AccountsNavBar
            // 
            AccountsNavBar.BackColor = Color.DarkBlue;
            AccountsNavBar.Controls.Add(AddAccounts);
            AccountsNavBar.Controls.Add(CurrAccoutsButton);
            AccountsNavBar.Dock = DockStyle.Top;
            AccountsNavBar.Location = new Point(0, 0);
            AccountsNavBar.Margin = new Padding(0);
            AccountsNavBar.Name = "AccountsNavBar";
            AccountsNavBar.Size = new Size(1904, 67);
            AccountsNavBar.TabIndex = 2;
            // 
            // AddAccounts
            // 
            AddAccounts.BackColor = Color.DarkBlue;
            AddAccounts.BackgroundImageLayout = ImageLayout.Zoom;
            AddAccounts.Dock = DockStyle.Left;
            AddAccounts.FlatAppearance.BorderSize = 0;
            AddAccounts.FlatStyle = FlatStyle.Flat;
            AddAccounts.Font = new Font("Bahnschrift", 14.25F);
            AddAccounts.ForeColor = Color.Snow;
            AddAccounts.Image = (Image)resources.GetObject("AddAccounts.Image");
            AddAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            AddAccounts.Location = new Point(244, 0);
            AddAccounts.Margin = new Padding(3, 40, 3, 3);
            AddAccounts.Name = "AddAccounts";
            AddAccounts.Padding = new Padding(30, 0, 0, 0);
            AddAccounts.Size = new Size(244, 67);
            AddAccounts.TabIndex = 7;
            AddAccounts.Text = "        Add Accounts";
            AddAccounts.TextAlign = ContentAlignment.MiddleLeft;
            AddAccounts.UseVisualStyleBackColor = false;
            AddAccounts.Click += AddAccounts_Click;
            // 
            // CurrAccoutsButton
            // 
            CurrAccoutsButton.BackColor = Color.DarkBlue;
            CurrAccoutsButton.BackgroundImageLayout = ImageLayout.Zoom;
            CurrAccoutsButton.Dock = DockStyle.Left;
            CurrAccoutsButton.FlatAppearance.BorderSize = 0;
            CurrAccoutsButton.FlatStyle = FlatStyle.Flat;
            CurrAccoutsButton.Font = new Font("Bahnschrift", 14.25F);
            CurrAccoutsButton.ForeColor = Color.Snow;
            CurrAccoutsButton.Image = (Image)resources.GetObject("CurrAccoutsButton.Image");
            CurrAccoutsButton.ImageAlign = ContentAlignment.MiddleLeft;
            CurrAccoutsButton.Location = new Point(0, 0);
            CurrAccoutsButton.Margin = new Padding(3, 40, 3, 3);
            CurrAccoutsButton.Name = "CurrAccoutsButton";
            CurrAccoutsButton.Padding = new Padding(30, 0, 0, 0);
            CurrAccoutsButton.Size = new Size(244, 67);
            CurrAccoutsButton.TabIndex = 6;
            CurrAccoutsButton.Text = "        Current Accounts";
            CurrAccoutsButton.TextAlign = ContentAlignment.MiddleLeft;
            CurrAccoutsButton.UseVisualStyleBackColor = false;
            CurrAccoutsButton.Click += CurrAccoutsButton_Click_1;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.GhostWhite;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 67);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1904, 934);
            mainPanel.TabIndex = 3;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Accounts";
            Text = "Accounts";
            panel1.ResumeLayout(false);
            AccountsNavBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel AccountsNavBar;
        private Button CurrAccoutsButton;
        private Button AddAccounts;
        private Panel mainPanel;
    }
}