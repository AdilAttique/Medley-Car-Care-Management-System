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
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            SuspendLayout();
            // 
            // clock1
            // 
            clock1.BackgroundColor = SystemColors.Control;
            clock1.BeforeTouchSize = new Size(327, 327);
            clock1.ClockFormat = "HH:mm:ss";
            clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Rectangle;
            clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Analog;
            clock1.CurrentDateTime = new DateTime(2024, 6, 10, 15, 39, 38, 927);
            clock1.CustomTime = new DateTime(2024, 6, 10, 15, 39, 38, 927);
            clock1.DigitalRenderer = digitalClockRenderer1;
            clock1.DisplayDates = true;
            clock1.Location = new Point(584, 221);
            clock1.MinimumSize = new Size(75, 75);
            clock1.Name = "clock1";
            clock1.Now = new DateTime(0L);
            clock1.Remainder = new DateTime(2024, 6, 10, 15, 39, 38, 925);
            clock1.Renderer = clockRenderer1;
            clock1.ShowClockFrame = false;
            clock1.ShowCustomTimeClock = false;
            clock1.ShowHourDesignator = false;
            clock1.Size = new Size(327, 327);
            clock1.StopTimer = false;
            clock1.TabIndex = 0;
            clock1.Text = "clock1";
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(clock1);
            Name = "CustomerList";
            Size = new Size(1678, 919);
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.Clock clock1;
    }
}
