using System;
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
            this.Icon = Properties.Resources.Icon;

            //StatisticsTab_Button_Click(this, null);
            ChatTab_Button_Click(this, null);
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
            this.Text = "COVIDealer - " + ChatTab_Button.Text;
            loadTab(chatTab);

        }

        private void StatisticsTab_Button_Click(object sender, EventArgs e)
        {
            if (statisticTab == null)
            {
                statisticTab = new StatisticTab();
            }
            this.Text = "COVIDealer - " + StatisticsTab_Button.Text;
            loadTab(statisticTab);
        }

        private void NewsTab_Button_Click(object sender, EventArgs e)
        {
            if (newsTab == null)
            {
                newsTab = new NewsTab();
            }
            this.Text = "COVIDealer - " + NewsTab_Button.Text;
            loadTab(newsTab);
        }

        private void VideoTab_Button_Click(object sender, EventArgs e)
        {
            if (videoTab == null)
            {
                videoTab = new VideoTab();
            }
            this.Text = "COVIDealer - " + VideoTab_Button.Text;
            loadTab(videoTab);
        }
        private void AboutTab_Button_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
