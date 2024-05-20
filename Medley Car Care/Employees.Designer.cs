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
            menu1 = new Menu();
            navigationBar1 = new NavigationBar();
            menu2 = new Menu();
            navigationBar2 = new NavigationBar();
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
            // menu2
            // 
            menu2.Location = new Point(0, 93);
            menu2.Name = "menu2";
            menu2.Size = new Size(252, 940);
            menu2.TabIndex = 8;
            // 
            // navigationBar2
            // 
            navigationBar2.BackColor = Color.FromArgb(57, 77, 97);
            navigationBar2.Location = new Point(0, 0);
            navigationBar2.Name = "navigationBar2";
            navigationBar2.Size = new Size(1920, 94);
            navigationBar2.TabIndex = 7;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1001);
            Controls.Add(menu2);
            Controls.Add(navigationBar2);
            Controls.Add(menu1);
            Controls.Add(navigationBar1);
            Name = "Employees";
            Text = "Employees";
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
        private Menu menu2;
        private NavigationBar navigationBar2;
    }
}