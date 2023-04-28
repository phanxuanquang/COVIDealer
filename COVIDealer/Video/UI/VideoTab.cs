using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using Google.Apis.YouTube.v3;
using Newtonsoft.Json;
using System.Net.Http;

namespace COVIDealer
{
    public partial class VideoTab : UserControl
    {
        VideoData videoData;
        public VideoTab()
        {
            InitializeComponent();
        }

        private async void VideoTab_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://youtube.googleapis.com/youtube/v3/search?part=id%2C%20snippet&maxResults=50&order=date&q=s%E1%BB%91%20ca%20m%E1%BA%AFc%20covid&type=video&key=AIzaSyCCGaaRT6VxH2TXo-PN6zRcwr3MJPWyEfs");
            videoData = JsonConvert.DeserializeObject<VideoData>(await response.Content.ReadAsStringAsync());

            Video1 = new VideoThumbnail(videoData.Items[0].Snippet);
        }
    }
}
