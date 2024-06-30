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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeList));
            emplistdgv = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            empsearchbtn = new Button();
            empsearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)emplistdgv).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // emplistdgv
            // 
            emplistdgv.BackgroundColor = Color.White;
            emplistdgv.BorderStyle = BorderStyle.None;
            emplistdgv.ColumnHeadersHeight = 45;
            emplistdgv.Dock = DockStyle.Bottom;
            emplistdgv.Location = new Point(0, 57);
            emplistdgv.Name = "emplistdgv";
            emplistdgv.Size = new Size(1438, 668);
            emplistdgv.TabIndex = 0;
            emplistdgv.CellContentClick += emplistdgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(emplistdgv);
            panel2.Location = new Point(120, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 725);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(autoLabel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1438, 62);
            panel3.TabIndex = 0;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.Snow;
            autoLabel1.Location = new Point(606, 13);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(213, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Employees List";
            // 
            // empsearchbtn
            // 
            empsearchbtn.Image = (Image)resources.GetObject("empsearchbtn.Image");
            empsearchbtn.Location = new Point(408, 56);
            empsearchbtn.Name = "empsearchbtn";
            empsearchbtn.Size = new Size(36, 29);
            empsearchbtn.TabIndex = 9;
            empsearchbtn.UseVisualStyleBackColor = true;
            // 
            // empsearch
            // 
            empsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empsearch.Location = new Point(120, 56);
            empsearch.Name = "empsearch";
            empsearch.PlaceholderText = "Search here";
            empsearch.Size = new Size(282, 29);
            empsearch.TabIndex = 8;
            empsearch.TextChanged += empsearch_TextChanged;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(empsearchbtn);
            Controls.Add(empsearch);
            Controls.Add(panel2);
            Name = "EmployeeList";
            Size = new Size(1678, 919);
            Load += EmployeeList_Load;
            ((System.ComponentModel.ISupportInitialize)emplistdgv).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView emplistdgv;
        private Panel panel2;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Button empsearchbtn;
        private TextBox empsearch;
    }
}
