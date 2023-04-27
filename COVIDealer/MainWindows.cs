using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class MainWindows : Form
    {
        ChatTab chatTab;
        public MainWindows()
        {
            InitializeComponent();

            chatTab = new ChatTab();

            loadTab(chatTab);
        }
        private void loadTab(UserControl tab)
        {
            if (!mainPanel.Controls.Contains(tab))
            {
                mainPanel.Controls.Add(tab);
            }
            tab.BringToFront();
            tab.Dock = DockStyle.Fill;
        }

        private void ChatTab_Button_Click(object sender, EventArgs e)
        {
            loadTab(chatTab);      
        }

        private void StatisticsTab_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchTab_Button_Click(object sender, EventArgs e)
        {

        }

        private void NewsTab_Button_Click(object sender, EventArgs e)
        {

        }

        private void VideoTab_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
