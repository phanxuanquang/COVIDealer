using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class MainWindows : Form
    {
        ChatTab chatTab = null;
        StatisticTab statisticTab = null;
        VideoTab videoTab = null;
        NewsTab newsTab = null;
        public MainWindows()  
        {
            InitializeComponent();
            this.Icon = Properties.Resources.COVIDealer;

            StatisticsTab_Button_Click(this, null);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;          
                return handleParam;
            }
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

        #region Button Events
        private void ChatTab_Button_Click(object sender, EventArgs e)
        {
            if (chatTab == null)
            {
                chatTab = new ChatTab();
            }
            loadTab(chatTab);      
        }

        private void StatisticsTab_Button_Click(object sender, EventArgs e)
        {
            if (statisticTab == null)
            {
                statisticTab = new StatisticTab();
            }
            loadTab(statisticTab);
        }

        private void SearchTab_Button_Click(object sender, EventArgs e)
        {

        }

        private void NewsTab_Button_Click(object sender, EventArgs e)
        {
            if (newsTab == null)
            {
                newsTab = new NewsTab();           
            }
            loadTab(newsTab);
        }

        private void VideoTab_Button_Click(object sender, EventArgs e)
        {
            if (videoTab == null)
            {
                videoTab = new VideoTab();
            }
            loadTab(videoTab);
        }
        #endregion
    }
}
