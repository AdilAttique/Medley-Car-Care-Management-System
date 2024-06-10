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
            tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).BeginInit();
            tabControlAdv1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tabControlAdv1);
            panel1.Location = new Point(113, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 744);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // tabControlAdv1
            // 
            tabControlAdv1.BackColor = Color.Silver;
            tabControlAdv1.BeforeTouchSize = new Size(1145, 706);
            tabControlAdv1.BorderStyle = BorderStyle.None;
            tabControlAdv1.Controls.Add(tabPageAdv1);
            tabControlAdv1.Controls.Add(tabPageAdv2);
            tabControlAdv1.Location = new Point(0, 35);
            tabControlAdv1.Name = "tabControlAdv1";
            tabControlAdv1.Size = new Size(1145, 706);
            tabControlAdv1.TabIndex = 0;
            // 
            // tabPageAdv1
            // 
            tabPageAdv1.Image = null;
            tabPageAdv1.ImageSize = new Size(16, 16);
            tabPageAdv1.Location = new Point(0, 26);
            tabPageAdv1.Name = "tabPageAdv1";
            tabPageAdv1.ShowCloseButton = true;
            tabPageAdv1.Size = new Size(1145, 680);
            tabPageAdv1.TabIndex = 1;
            tabPageAdv1.Text = "tabPageAdv1";
            tabPageAdv1.ThemesEnabled = false;
            // 
            // tabPageAdv2
            // 
            tabPageAdv2.Image = null;
            tabPageAdv2.ImageSize = new Size(16, 16);
            tabPageAdv2.Location = new Point(0, 26);
            tabPageAdv2.Name = "tabPageAdv2";
            tabPageAdv2.ShowCloseButton = true;
            tabPageAdv2.Size = new Size(1145, 680);
            tabPageAdv2.TabIndex = 2;
            tabPageAdv2.Text = "tabPageAdv2";
            tabPageAdv2.ThemesEnabled = false;
            // 
            // InvStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(panel1);
            Name = "InvStock";
            Size = new Size(1678, 919);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabControlAdv1).EndInit();
            tabControlAdv1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
    }
}
