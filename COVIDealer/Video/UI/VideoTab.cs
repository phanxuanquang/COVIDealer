using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Configuration;

namespace COVIDealer
{
    public partial class VideoTab : UserControl
    {
        VideoData videoData;
        int pageIndex = 0;
        public VideoTab()
        {
            InitializeComponent();
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

        private async void VideoTab_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://youtube.googleapis.com/youtube/v3/search?part=id%2C%20snippet&maxResults=50&order=date&q=s%E1%BB%91%20ca%20m%E1%BA%AFc%20covid&type=video&key=AIzaSyCCGaaRT6VxH2TXo-PN6zRcwr3MJPWyEfs");
            videoData = JsonConvert.DeserializeObject<VideoData>(await response.Content.ReadAsStringAsync());

            setThumbnail(pageIndex);
            
        }

        void setDataForThumbnail(VideoThumbnail videoThumbnail, int i)
        {
            videoThumbnail.snippet = videoData.Items[i].Snippet;
            videoThumbnail.videoID = videoData.Items[i].Id.VideoId;
            videoThumbnail.setParameter();
        }

        void setThumbnail(int i)
        {
            setDataForThumbnail(videoThumbnail1, i);
            setDataForThumbnail(videoThumbnail2, i + 1);
            setDataForThumbnail(videoThumbnail3, i + 2);
            setDataForThumbnail(videoThumbnail4, i + 3);
            setDataForThumbnail(videoThumbnail5, i + 4);
            setDataForThumbnail(videoThumbnail6, i + 5);
        }

        private void NextPage_Button_Click(object sender, EventArgs e)
        {
            pageIndex++;
            if (pageIndex >= 0)
            {
                PreviousPage_Button.Enabled = true;
            }
            this.setThumbnail(pageIndex);
        }

        private void PreviousPage_Button_Click(object sender, EventArgs e)
        {
            pageIndex--;
            if (pageIndex == 0)
            {
                PreviousPage_Button.Enabled = false;
            }
            this.setThumbnail(pageIndex);
        }
    }
}
