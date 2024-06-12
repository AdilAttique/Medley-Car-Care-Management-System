namespace Medley_Car_Care
{
    partial class CustomerList
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
            customerlistdgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customerlistdgv).BeginInit();
            SuspendLayout();
            // 
            // customerlistdgv
            // 
            customerlistdgv.BackgroundColor = SystemColors.ButtonHighlight;
            customerlistdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerlistdgv.Location = new Point(245, 123);
            customerlistdgv.Name = "customerlistdgv";
            customerlistdgv.Size = new Size(963, 641);
            customerlistdgv.TabIndex = 0;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(customerlistdgv);
            Name = "CustomerList";
            Size = new Size(1678, 919);
            Load += CustomerList_Load;
            ((System.ComponentModel.ISupportInitialize)customerlistdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customerlistdgv;
    }
}
