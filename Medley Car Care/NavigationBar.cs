using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medley_Car_Care
{
    public partial class NavigationBar : UserControl
    {
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        public NavigationBar()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void NavigationBar_Load(object sender, EventArgs e)
        {

        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString("ddd, dd MMM, yyyy h:mm tt");
        }
    }
}
