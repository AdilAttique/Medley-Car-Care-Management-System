using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medley_Car_Care
{
    public partial class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 30;

        public RoundedPanel()
        {
            InitializeComponent();
        }

        public RoundedPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int radius = CornerRadius;
            int diameter = radius * 2;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Top left corner
            path.AddArc(0, 0, diameter, diameter, 180, 90);

            // Top edge
            path.AddLine(radius, 0, this.Width - radius, 0);

            // Top right corner
            path.AddArc(this.Width - diameter, 0, diameter, diameter, 270, 90);

            // Right edge
            path.AddLine(this.Width, radius, this.Width, this.Height - radius);

            // Bottom right corner
            path.AddArc(this.Width - diameter, this.Height - diameter, diameter, diameter, 0, 90);

            // Bottom edge
            path.AddLine(this.Width - radius, this.Height, radius, this.Height);

            // Bottom left corner
            path.AddArc(0, this.Height - diameter, diameter, diameter, 90, 90);

            // Left edge
            path.AddLine(0, this.Height - radius, 0, radius);

            path.CloseFigure();

            this.Region = new Region(path);

            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Brush brush = new SolidBrush(this.BackColor))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(this.ForeColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}

