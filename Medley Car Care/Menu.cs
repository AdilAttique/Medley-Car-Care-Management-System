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
    public partial class Menu : UserControl
    {
        
        public Menu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void MenuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem menuItem in MenuBar.Items)
            {
                menuItem.Font = new Font(menuItem.Font, FontStyle.Regular);
            }
           
            /*ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)sender;
            clickedMenuItem.Font = new Font(currentMenuItem.Font, FontStyle.Bold);*/
            ToolStripMenuItem clickedMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Apply bold font to the clicked item
            clickedMenuItem.Font = new Font(clickedMenuItem.Font, FontStyle.Bold);
           
            if(clickedMenuItem.Text == "Log Out")
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
