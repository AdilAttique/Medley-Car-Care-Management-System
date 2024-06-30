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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvStock));
            inventorydgv = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            searchbtn = new Button();
            search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)inventorydgv).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // inventorydgv
            // 
            inventorydgv.BackgroundColor = Color.White;
            inventorydgv.BorderStyle = BorderStyle.None;
            inventorydgv.ColumnHeadersHeight = 45;
            inventorydgv.Dock = DockStyle.Bottom;
            inventorydgv.Location = new Point(0, 51);
            inventorydgv.Name = "inventorydgv";
            inventorydgv.Size = new Size(1438, 674);
            inventorydgv.TabIndex = 0;
            inventorydgv.CellContentClick += inventorydgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(inventorydgv);
            panel2.Location = new Point(120, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 725);
            panel2.TabIndex = 3;
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
            autoLabel1.Size = new Size(87, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Stock";
            // 
            // searchbtn
            // 
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.Location = new Point(399, 108);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(36, 29);
            searchbtn.TabIndex = 10;
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(120, 108);
            search.Name = "search";
            search.PlaceholderText = "Search here";
            search.Size = new Size(273, 27);
            search.TabIndex = 9;
            search.TextChanged += search_TextChanged;
            // 
            // InvStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(searchbtn);
            Controls.Add(search);
            Controls.Add(panel2);
            Name = "InvStock";
            Size = new Size(1678, 919);
            Load += InvStock_Load;
            ((System.ComponentModel.ISupportInitialize)inventorydgv).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView inventorydgv;
        private Panel panel2;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Button searchbtn;
        private TextBox search;
    }
}
