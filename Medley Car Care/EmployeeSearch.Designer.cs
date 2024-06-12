namespace Medley_Car_Care
{
    partial class EmployeeSearch
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
            hScrollBar1 = new HScrollBar();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(484, 285);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(562, 39);
            hScrollBar1.TabIndex = 0;
            // 
            // EmployeeSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(hScrollBar1);
            Name = "EmployeeSearch";
            Size = new Size(1678, 919);
            ResumeLayout(false);
        }

        #endregion

        private HScrollBar hScrollBar1;
    }
}
