namespace Medley_Car_Care
{
    partial class EmployeeList
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
            emplistdgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)emplistdgv).BeginInit();
            SuspendLayout();
            // 
            // emplistdgv
            // 
            emplistdgv.BackgroundColor = SystemColors.Control;
            emplistdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emplistdgv.Location = new Point(365, 67);
            emplistdgv.Name = "emplistdgv";
            emplistdgv.Size = new Size(913, 547);
            emplistdgv.TabIndex = 0;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(emplistdgv);
            Name = "EmployeeList";
            Size = new Size(1678, 919);
            Load += EmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)emplistdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView emplistdgv;
    }
}
