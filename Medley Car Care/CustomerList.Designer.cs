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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
            customerlistdgv = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            search = new TextBox();
            searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)customerlistdgv).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // customerlistdgv
            // 
            customerlistdgv.BackgroundColor = Color.White;
            customerlistdgv.BorderStyle = BorderStyle.None;
            customerlistdgv.ColumnHeadersHeight = 30;
            customerlistdgv.Dock = DockStyle.Bottom;
            customerlistdgv.Location = new Point(0, 57);
            customerlistdgv.Name = "customerlistdgv";
            customerlistdgv.Size = new Size(1438, 668);
            customerlistdgv.TabIndex = 0;
            customerlistdgv.CellContentClick += customerlistdgv_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(customerlistdgv);
            panel2.Location = new Point(120, 160);
            panel2.Name = "panel2";
            panel2.Size = new Size(1438, 725);
            panel2.TabIndex = 1;
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
            panel3.Paint += panel3_Paint;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.Snow;
            autoLabel1.Location = new Point(606, 13);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(213, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Customers List";
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(120, 114);
            search.Name = "search";
            search.PlaceholderText = "Search here";
            search.Size = new Size(273, 27);
            search.TabIndex = 2;
            search.TextChanged += search_TextChanged_1;
            // 
            // searchbtn
            // 
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.Location = new Point(399, 114);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(36, 29);
            searchbtn.TabIndex = 8;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(searchbtn);
            Controls.Add(search);
            Controls.Add(panel2);
            Name = "CustomerList";
            Size = new Size(1678, 919);
            Load += CustomerList_Load;
            ((System.ComponentModel.ISupportInitialize)customerlistdgv).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView customerlistdgv;
        private DataGridViewTextBoxColumn Header;
        private DataGridViewTextBoxColumn Column1;
        private Panel panel2;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private TextBox search;
        private Button searchbtn;
    }
}
