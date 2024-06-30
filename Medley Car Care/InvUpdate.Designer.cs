namespace Medley_Car_Care
{
    partial class InvUpdate
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
            AddItem = new Button();
            panel3 = new Panel();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            barcode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            quantityinstock = new TextBox();
            label4 = new Label();
            itemname = new TextBox();
            priceperunit = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(AddItem);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(barcode);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(quantityinstock);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(itemname);
            panel1.Controls.Add(priceperunit);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(274, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(1097, 708);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // AddItem
            // 
            AddItem.BackColor = Color.SkyBlue;
            AddItem.FlatAppearance.BorderSize = 0;
            AddItem.FlatStyle = FlatStyle.Flat;
            AddItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItem.ForeColor = Color.Black;
            AddItem.Location = new Point(304, 366);
            AddItem.Name = "AddItem";
            AddItem.Size = new Size(101, 27);
            AddItem.TabIndex = 27;
            AddItem.Text = "ADD";
            AddItem.UseVisualStyleBackColor = false;
            AddItem.Click += AddItem_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Controls.Add(autoLabel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1097, 62);
            panel3.TabIndex = 26;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.Snow;
            autoLabel1.Location = new Point(435, 14);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(197, 35);
            autoLabel1.TabIndex = 0;
            autoLabel1.Text = "Add New Item";
            // 
            // barcode
            // 
            barcode.Font = new Font("Segoe UI", 12F);
            barcode.Location = new Point(242, 116);
            barcode.Name = "barcode";
            barcode.Size = new Size(234, 29);
            barcode.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label2.Location = new Point(106, 120);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 25;
            label2.Text = "Bar Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label3.Location = new Point(106, 300);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 16;
            label3.Text = "Quantity";
            // 
            // quantityinstock
            // 
            quantityinstock.Font = new Font("Segoe UI", 12F);
            quantityinstock.Location = new Point(242, 296);
            quantityinstock.Name = "quantityinstock";
            quantityinstock.Size = new Size(234, 29);
            quantityinstock.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label4.Location = new Point(106, 240);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 18;
            label4.Text = "Price Per Unit";
            // 
            // itemname
            // 
            itemname.Font = new Font("Segoe UI", 12F);
            itemname.Location = new Point(242, 176);
            itemname.Name = "itemname";
            itemname.Size = new Size(234, 29);
            itemname.TabIndex = 19;
            // 
            // priceperunit
            // 
            priceperunit.Font = new Font("Segoe UI", 12F);
            priceperunit.Location = new Point(242, 236);
            priceperunit.Name = "priceperunit";
            priceperunit.Size = new Size(234, 29);
            priceperunit.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            label5.Location = new Point(106, 180);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 20;
            label5.Text = "Name";
            // 
            // InvUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "InvUpdate";
            Size = new Size(1678, 919);
            Load += InvUpdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox barcode;
        private Label label2;
        private Label label3;
        private TextBox quantityinstock;
        private Label label4;
        private TextBox itemname;
        private TextBox priceperunit;
        private Label label5;
        private Panel panel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Button AddItem;
    }
}
