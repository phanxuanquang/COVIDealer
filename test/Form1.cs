using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test
{
    public partial class Form1 : Form
    {
        VideoData videoData;
        public Form1()
        {
            InitializeComponent();
            
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            //HttpClient httpClient = new HttpClient();
            //var response = await httpClient.GetAsync("https://youtube.googleapis.com/youtube/v3/search?part=id%2C%20snippet&maxResults=50&order=date&q=s%E1%BB%91%20ca%20m%E1%BA%AFc%20covid&type=video&key=AIzaSyCCGaaRT6VxH2TXo-PN6zRcwr3MJPWyEfs");
            //videoData = JsonConvert.DeserializeObject<VideoData>(await response.Content.ReadAsStringAsync());

            //Video1 = new VideoThumbnail(videoData.Items[0].Snippet);
        }
    }
}