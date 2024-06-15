namespace Medley_Car_Care
{
    partial class Current_Accounts
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
            ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboDropDown1).BeginInit();
            SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            ribbonControlAdv1.Font = new Font("Segoe UI", 8.25F);
            ribbonControlAdv1.Location = new Point(330, 377);
            ribbonControlAdv1.MenuButtonFont = new Font("Segoe UI", 8.25F);
            ribbonControlAdv1.MenuButtonText = "";
            ribbonControlAdv1.MenuColor = Color.FromArgb(0, 114, 198);
            ribbonControlAdv1.Name = "ribbonControlAdv1";
            ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // 
            // 
            ribbonControlAdv1.OfficeMenu.Name = "";
            ribbonControlAdv1.OfficeMenu.ShowItemToolTips = true;
            ribbonControlAdv1.OfficeMenu.Size = new Size(12, 65);
            ribbonControlAdv1.QuickPanelImageLayout = PictureBoxSizeMode.StretchImage;
            ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            ribbonControlAdv1.SelectedTab = null;
            ribbonControlAdv1.ShowRibbonDisplayOptionButton = true;
            ribbonControlAdv1.Size = new Size(672, 359);
            ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            ribbonControlAdv1.SystemText.RenameDisplayLabelText = "&Display Name:";
            ribbonControlAdv1.TabIndex = 0;
            ribbonControlAdv1.Text = "ribbonControlAdv1";
            // 
            // comboDropDown1
            // 
            comboDropDown1.BeforeTouchSize = new Size(205, 23);
            comboDropDown1.Location = new Point(523, 138);
            comboDropDown1.Name = "comboDropDown1";
            comboDropDown1.Size = new Size(205, 23);
            comboDropDown1.TabIndex = 1;
            // 
            // Current_Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(comboDropDown1);
            Controls.Add(ribbonControlAdv1);
            Margin = new Padding(0);
            Name = "Current_Accounts";
            Size = new Size(1678, 919);
            ((System.ComponentModel.ISupportInitialize)ribbonControlAdv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboDropDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;
    }
}
