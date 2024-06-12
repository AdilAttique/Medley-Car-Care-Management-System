namespace Medley_Car_Care
{
    partial class AddEmployee
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
            calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            SuspendLayout();
            // 
            // calculatorControl1
            // 
            calculatorControl1.AccessibleDescription = "Calculator control";
            calculatorControl1.AccessibleName = "Calculator Control";
            calculatorControl1.BeforeTouchSize = new Size(459, 538);
            calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            calculatorControl1.DoubleValue = 0D;
            calculatorControl1.Font = new Font("Segoe UI", 9F);
            calculatorControl1.ForeColor = SystemColors.ControlText;
            calculatorControl1.Location = new Point(557, 150);
            calculatorControl1.MetroColor = SystemColors.Control;
            calculatorControl1.Name = "calculatorControl1";
            calculatorControl1.Size = new Size(459, 538);
            calculatorControl1.TabIndex = 0;
            calculatorControl1.Text = "calculatorControl1";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(calculatorControl1);
            Name = "AddEmployee";
            Size = new Size(1678, 919);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
    }
}
