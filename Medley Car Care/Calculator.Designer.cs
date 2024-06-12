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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculatorControl = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            SuspendLayout();
            // 
            // calculatorControl
            // 
            calculatorControl.AccessibleDescription = "Calculator control";
            calculatorControl.AccessibleName = "Calculator Control";
            calculatorControl.BeforeTouchSize = new Size(404, 531);
            calculatorControl.Culture = new System.Globalization.CultureInfo("en-US");
            calculatorControl.DoubleValue = 0D;
            calculatorControl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculatorControl.ForeColor = SystemColors.ControlText;
            calculatorControl.Location = new Point(71, 16);
            calculatorControl.MetroColor = Color.Black;
            calculatorControl.Name = "calculatorControl";
            calculatorControl.Size = new Size(404, 531);
            calculatorControl.TabIndex = 0;
            calculatorControl.Text = "CalculatorControl";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(calculatorControl);
            Name = "Calculator";
            Size = new Size(559, 573);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl;
    }
}
