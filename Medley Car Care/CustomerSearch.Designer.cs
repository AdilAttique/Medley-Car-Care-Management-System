namespace Medley_Car_Care
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            panel1 = new Panel();
            customerdgv = new DataGridView();
            searchbtn = new Button();
            search = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerdgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(customerdgv);
            panel1.Controls.Add(searchbtn);
            panel1.Controls.Add(search);
            panel1.Location = new Point(291, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 1;
            // 
            // customerdgv
            // 
            customerdgv.AllowUserToOrderColumns = true;
            customerdgv.BackgroundColor = SystemColors.ButtonHighlight;
            customerdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerdgv.Location = new Point(0, 86);
            customerdgv.Name = "customerdgv";
            customerdgv.Size = new Size(1097, 619);
            customerdgv.TabIndex = 8;
            // 
            // searchbtn
            // 
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.Location = new Point(334, 28);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(36, 29);
            searchbtn.TabIndex = 7;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // search
            // 
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search.Location = new Point(46, 28);
            search.Name = "search";
            search.PlaceholderText = "Search here";
            search.Size = new Size(282, 29);
            search.TabIndex = 6;
            search.TextChanged += search_TextChanged_1;
            // 
            // CustomerSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "CustomerSearch";
            Size = new Size(1678, 919);
            Load += CustomerSearch_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button searchbtn;
        private TextBox search;
        private DataGridView customerdgv;
    }
}
