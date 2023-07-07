using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class NewsTab : UserControl
    {

        public NewsTab()
        {
            InitializeComponent();
        }

        private async void NewsTab_Load(object sender, EventArgs e)
        {
            List<HtmlNode> nodes = new List<HtmlNode>();
            for (int index = 1; index <= 5; index++)
            {
                List<HtmlNode> task = await getDataFrom($"https://covid19.gov.vn/timelinelist/1711566/{index}.htm", "//div[contains(@class, 'box-stream-item')]");
                nodes.AddRange(task);
            }
            foreach (var item in nodes.Select(item => new ArticleThumbnail(item)))
            {
                contentPanel.Controls.Add(item);
            }
        }

        async Task<List<HtmlNode>> getDataFrom(string URL, string xpath)
        {
            List<HtmlNode> items = new List<HtmlNode>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(URL);
                HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                byte[] bytes = await response.Content.ReadAsByteArrayAsync();
                bytes = Decompress(bytes);
                string content = HttpUtility.HtmlDecode(Encoding.UTF8.GetString(bytes));
                document.LoadHtml(content);
                HtmlNodeCollection nodes = document.DocumentNode.SelectNodes(xpath);
                if (nodes == null) return items;
                foreach (var node in nodes)
                {
                    items.Add(node);
                }
            }
            return items;
        }

        public static byte[] Decompress(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                zipStream.CopyTo(resultStream);
                return resultStream.ToArray();
            }
        }
    }
}
