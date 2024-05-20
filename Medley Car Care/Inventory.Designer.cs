namespace Medley_Car_Care
{
    partial class Inventory
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
            menu1 = new Menu();
            navigationBar1 = new NavigationBar();
            SuspendLayout();
            // 
            // menu1
            // 
            menu1.Location = new Point(0, 93);
            menu1.Name = "menu1";
            menu1.Size = new Size(252, 940);
            menu1.TabIndex = 6;
            menu1.Load += menu1_Load;
            // 
            // navigationBar1
            // 
            navigationBar1.BackColor = Color.FromArgb(57, 77, 97);
            navigationBar1.Location = new Point(0, 1);
            navigationBar1.Name = "navigationBar1";
            navigationBar1.Size = new Size(1920, 94);
            navigationBar1.TabIndex = 5;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(menu1);
            Controls.Add(navigationBar1);
            Name = "Inventory";
            Text = "Inventory";
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
    }
}