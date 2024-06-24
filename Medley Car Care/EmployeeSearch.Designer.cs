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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSearch));
            panel1 = new Panel();
            empdgv = new DataGridView();
            empsearchbtn = new Button();
            empsearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empdgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(empdgv);
            panel1.Controls.Add(empsearchbtn);
            panel1.Controls.Add(empsearch);
            panel1.Location = new Point(291, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 2;
            // 
            // empdgv
            // 
            empdgv.AllowUserToOrderColumns = true;
            empdgv.BackgroundColor = SystemColors.ButtonHighlight;
            empdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empdgv.Location = new Point(0, 86);
            empdgv.Name = "empdgv";
            empdgv.Size = new Size(1097, 619);
            empdgv.TabIndex = 8;
            // 
            // empsearchbtn
            // 
            empsearchbtn.Image = (Image)resources.GetObject("empsearchbtn.Image");
            empsearchbtn.Location = new Point(334, 28);
            empsearchbtn.Name = "empsearchbtn";
            empsearchbtn.Size = new Size(36, 29);
            empsearchbtn.TabIndex = 7;
            empsearchbtn.UseVisualStyleBackColor = true;
            // 
            // empsearch
            // 
            empsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empsearch.Location = new Point(46, 28);
            empsearch.Name = "empsearch";
            empsearch.PlaceholderText = "Search here";
            empsearch.Size = new Size(282, 29);
            empsearch.TabIndex = 6;
            empsearch.TextChanged += empsearch_TextChanged;
            // 
            // EmployeeSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "EmployeeSearch";
            Size = new Size(1678, 919);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView empdgv;
        private Button empsearchbtn;
        private TextBox empsearch;
    }
}
