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
        ChatTab chatTab;
        StatisticTab statisticTab;
        VideoTab videoTab;

        StatisticData data;
        public MainWindows()
        {
            InitializeComponent();

            chatTab = new ChatTab();
            videoTab = new VideoTab();
            statisticTab = new StatisticTab();

            loadTab(chatTab);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
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

        private void ChatTab_Button_Click(object sender, EventArgs e)
        {
            loadTab(chatTab);      
        }

        private void StatisticsTab_Button_Click(object sender, EventArgs e)
        {
            loadTab(statisticTab);
        }

        private void SearchTab_Button_Click(object sender, EventArgs e)
        {

        }

        private void NewsTab_Button_Click(object sender, EventArgs e)
        {

        }

        private void VideoTab_Button_Click(object sender, EventArgs e)
        {
            loadTab(videoTab);
        }

        private async void MainWindows_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://static.pipezero.com/covid/data.json");
            data = JsonConvert.DeserializeObject<StatisticData>(await response.Content.ReadAsStringAsync());   
        }
    }
}
