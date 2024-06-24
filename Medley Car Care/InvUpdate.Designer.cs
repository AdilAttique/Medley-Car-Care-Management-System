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
            label1 = new Label();
            barcode = new TextBox();
            label2 = new Label();
            Additem = new Button();
            itemname = new TextBox();
            label5 = new Label();
            priceperunit = new TextBox();
            label4 = new Label();
            quantityinstock = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(barcode);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Additem);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(399, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 35);
            label1.TabIndex = 0;
            label1.Text = "Add Items to Stock";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // barcode
            // 
            barcode.Location = new Point(286, 126);
            barcode.Name = "barcode";
            barcode.Size = new Size(234, 23);
            barcode.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 134);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 25;
            label2.Text = "Bar Code";
            // 
            // Additem
            // 
            Additem.Location = new Point(122, 437);
            Additem.Name = "Additem";
            Additem.Size = new Size(101, 27);
            Additem.TabIndex = 23;
            Additem.Text = "ADD";
            Additem.UseVisualStyleBackColor = true;
            Additem.Click += Additem_Click;
            // 
            // itemname
            // 
            itemname.Location = new Point(286, 183);
            itemname.Name = "itemname";
            itemname.Size = new Size(234, 23);
            itemname.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 191);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 20;
            label5.Text = "Name";
            // 
            // priceperunit
            // 
            priceperunit.Location = new Point(286, 242);
            priceperunit.Name = "priceperunit";
            priceperunit.Size = new Size(234, 23);
            priceperunit.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 250);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 18;
            label4.Text = "Price Per Unit";
            // 
            // quantityinstock
            // 
            quantityinstock.Location = new Point(286, 303);
            quantityinstock.Name = "quantityinstock";
            quantityinstock.Size = new Size(234, 23);
            quantityinstock.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 311);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 16;
            label3.Text = "Quantity";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox barcode;
        private Label label2;
        private Button Additem;
        private Label label3;
        private TextBox quantityinstock;
        private Label label4;
        private TextBox itemname;
        private TextBox priceperunit;
        private Label label5;
    }
}
