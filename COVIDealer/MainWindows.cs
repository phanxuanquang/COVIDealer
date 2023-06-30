using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class MainWindows : Form
    {
        ChatTab chatTab = null;
        StatisticTab statisticTab = null;
        VideoTab videoTab = null;
        NewsTab newsTab = null;
        string headerName = "COVIDealer - ";
        public MainWindows()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Icon;
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
            this.Text = headerName + ChatTab_Button.Text;
            loadTab(chatTab);

        }

        private void StatisticsTab_Button_Click(object sender, EventArgs e)
        {
            if (statisticTab == null)
            {
                statisticTab = new StatisticTab();
            }
            this.Text = headerName + StatisticsTab_Button.Text;
            loadTab(statisticTab);
        }

        private void NewsTab_Button_Click(object sender, EventArgs e)
        {
            if (newsTab == null)
            {
                newsTab = new NewsTab();
            }
            this.Text = headerName + NewsTab_Button.Text;
            loadTab(newsTab);
        }

        private void VideoTab_Button_Click(object sender, EventArgs e)
        {
            if (videoTab == null)
            {
                videoTab = new VideoTab();
            }
            this.Text = headerName + VideoTab_Button.Text;
            loadTab(videoTab);
        }
        private async void AboutTab_Button_Click(object sender, EventArgs e)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
                var response = await httpClient.GetAsync("https://api.github.com/repos/phanxuanquang/COVIDealer/releases/latest");
                LatestReleaseInfo.Infor latestReleaseInfo = JsonConvert.DeserializeObject<LatestReleaseInfo.Infor>(await response.Content.ReadAsStringAsync());


                if (AboutTab_Button.Tag.ToString() == latestReleaseInfo.TagName)
                {
                    MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult confirmation = MessageBox.Show($"Đã có phiên bản mới được cập nhật vào lúc: {latestReleaseInfo.PublishedAt.ToString("HH:mm - dd/MM/yyyy").Trim()}.\n\nThông tin phiên bản:\n{latestReleaseInfo.Body}\n\nBạn có muốn tải về không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmation == DialogResult.Yes)
                    {
                        Process.Start(latestReleaseInfo.Assets.ToArray()[0].BrowserDownloadUrl);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại, vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void MainWindows_Load(object sender, EventArgs e)
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    ChatTab_Button_Click(this, null);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng kiểm tra kết nối mạng và thử lại.", "Không có kết nối mạng", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
    }
}
