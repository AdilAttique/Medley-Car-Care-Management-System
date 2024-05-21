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
            button1 = new Button();
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(472, 260);
            button1.Name = "button1";
            button1.Size = new Size(372, 193);
            button1.TabIndex = 7;
            button1.Text = "I AM EMPLOYEES";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1923, 1061);
            Controls.Add(button1);
            Controls.Add(menu1);
            Controls.Add(navigationBar1);
            IsMdiContainer = false;
            Name = "Employees";
            Text = "Employees";
            Load += Employees_Load;
            Controls.SetChildIndex(navigationBar1, 0);
            Controls.SetChildIndex(menu1, 0);
            Controls.SetChildIndex(button1, 0);
            ResumeLayout(false);
        }

        #endregion

        private Menu menu1;
        private NavigationBar navigationBar1;
        private Button button1;
    }
}