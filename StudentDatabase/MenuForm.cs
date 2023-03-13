using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class MenuForm : Form
    {
        bool sideBar = false;
        public MenuForm() 
        {
            InitializeComponent();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu process = new MainMenu();
            process.MdiParent = this;
            process.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchOption searchtool = new SearchOption();
            searchtool.MdiParent = this;
            searchtool.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            
            MainMenu process = new MainMenu();
            process.TopLevel = false;
            process.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(process);
            process.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchOption search = new SearchOption();
            search.TopLevel = false;
            search.FormBorderStyle= FormBorderStyle.None;
            panelMain.Controls.Clear();
            this.panelMain.Controls.Add(search);
            search.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanelLeft_tick(object sender, EventArgs e)
        {
            if (sideBar) 
            {
                tableLayoutPanelLeft.Width -= 10;
                if (tableLayoutPanelLeft.Width == tableLayoutPanelLeft.MinimumSize.Width) 
                {
                    sideBar = false;
                    SideTimer.Stop();
                }
            }
            else 
            {
                tableLayoutPanelLeft.Width += 10;
                if(tableLayoutPanelLeft.Width == tableLayoutPanelLeft.MaximumSize.Width) 
                {
                    sideBar = true;
                    SideTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            SideTimer.Start();
        }

        private void tableLayoutPanelLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
