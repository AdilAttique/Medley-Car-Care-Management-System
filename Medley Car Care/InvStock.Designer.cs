namespace Medley_Car_Care
{
    partial class InvStock
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
            panel1 = new Panel();
            inventorydgv = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(inventorydgv);
            panel1.Location = new Point(113, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 744);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // inventorydgv
            // 
            inventorydgv.BackgroundColor = SystemColors.Control;
            inventorydgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorydgv.Location = new Point(3, 3);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.Size = new Size(1346, 741);
            inventorydgv.TabIndex = 0;
            // 
            // InvStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "InvStock";
            Size = new Size(1678, 919);
            Load += InvStock_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView inventorydgv;
    }
}
