namespace Medley_Car_Care
{
    partial class NavigationBar
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
            MedleyName = new Label();
            Time = new Label();
            SuspendLayout();
            // 
            // MedleyName
            // 
            MedleyName.AutoSize = true;
            MedleyName.BackColor = Color.Transparent;
            MedleyName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MedleyName.ForeColor = Color.Snow;
            MedleyName.Location = new Point(12, 18);
            MedleyName.Name = "MedleyName";
            MedleyName.Size = new Size(214, 55);
            MedleyName.TabIndex = 3;
            MedleyName.Text = "MEDLEY";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.ForeColor = Color.Snow;
            Time.Location = new Point(1578, 27);
            Time.Name = "Time";
            Time.Size = new Size(308, 32);
            Time.TabIndex = 4;
            Time.Text = "Sun, 19 May, 2024, 6:40 PM";
            Time.Click += Time_Click;
            // 
            // NavigationBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 77, 97);
            Controls.Add(Time);
            Controls.Add(MedleyName);
            Name = "NavigationBar";
            Size = new Size(1920, 94);
            Load += NavigationBar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MedleyName;
        private Label Time;
    }
}
