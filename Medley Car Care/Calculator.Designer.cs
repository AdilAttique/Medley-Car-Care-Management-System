namespace Medley_Car_Care
{
    partial class Calculator
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

        #region Windows Form Designer generated code

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
            calculatorControl1.BeforeTouchSize = new Size(497, 544);
            calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
            calculatorControl1.DoubleValue = 0D;
            calculatorControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatorControl1.ForeColor = SystemColors.ControlText;
            calculatorControl1.Location = new Point(73, 12);
            calculatorControl1.MetroColor = Color.Black;
            calculatorControl1.Name = "calculatorControl1";
            calculatorControl1.Size = new Size(497, 544);
            calculatorControl1.TabIndex = 0;
            calculatorControl1.Text = "calculatorControl1";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(654, 568);
            Controls.Add(calculatorControl1);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
    }
}