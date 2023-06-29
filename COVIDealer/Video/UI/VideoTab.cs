using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class VideoTab : UserControl
    {
        VideoData videoData;
        public VideoTab()
        {
            InitializeComponent();
        }

        private async void VideoTab_test_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://youtube.googleapis.com/youtube/v3/search?part=id%2C%20snippet&maxResults=50&order=date&q=s%E1%BB%91%20ca%20m%E1%BA%AFc%20covid&type=video&key=AIzaSyCCGaaRT6VxH2TXo-PN6zRcwr3MJPWyEfs");
            videoData = JsonConvert.DeserializeObject<VideoData>(await response.Content.ReadAsStringAsync());

            VideoThumbnail newItem;
            foreach (var item in videoData.Items)
            {
                newItem = new VideoThumbnail();
                flowLayoutPanel1.Controls.Add(newItem);
                newItem.snippet = item.Snippet;
                newItem.videoID = item.Id.VideoId;
                newItem.setParameter();
            }

        }
    }
}
