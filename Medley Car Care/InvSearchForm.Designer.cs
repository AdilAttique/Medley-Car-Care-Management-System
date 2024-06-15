namespace Medley_Car_Care
{
    partial class InvSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvSearchForm));
            panel1 = new Panel();
            inventorysearchdgv = new DataGridView();
            itemsearchbtn = new Button();
            itemsearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inventorysearchdgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(inventorysearchdgv);
            panel1.Controls.Add(itemsearchbtn);
            panel1.Controls.Add(itemsearch);
            panel1.Location = new Point(274, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 0;
            // 
            // inventorysearchdgv
            // 
            inventorysearchdgv.BackgroundColor = SystemColors.Control;
            inventorysearchdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventorysearchdgv.Location = new Point(3, 93);
            inventorysearchdgv.Name = "inventorysearchdgv";
            inventorysearchdgv.Size = new Size(1091, 612);
            inventorysearchdgv.TabIndex = 8;
            // 
            // itemsearchbtn
            // 
            itemsearchbtn.Image = (Image)resources.GetObject("itemsearchbtn.Image");
            itemsearchbtn.Location = new Point(334, 28);
            itemsearchbtn.Name = "itemsearchbtn";
            itemsearchbtn.Size = new Size(36, 29);
            itemsearchbtn.TabIndex = 7;
            itemsearchbtn.UseVisualStyleBackColor = true;
            itemsearchbtn.Click += itemsearchbtn_Click;
            // 
            // itemsearch
            // 
            itemsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemsearch.Location = new Point(46, 28);
            itemsearch.Name = "itemsearch";
            itemsearch.PlaceholderText = "Search here";
            itemsearch.Size = new Size(282, 29);
            itemsearch.TabIndex = 6;
            itemsearch.TextChanged += itemsearch_TextChanged_1;
            // 
            // InvSearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "InvSearchForm";
            Size = new Size(1678, 919);
            Load += InvSearchForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inventorysearchdgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button itemsearchbtn;
        private TextBox itemsearch;
        private DataGridView inventorysearchdgv;
    }
}
