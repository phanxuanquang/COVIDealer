using System;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Linq;
using System.Xml.XPath;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            HttpResponseMessage response = await httpClient.GetAsync("https://covid19.gov.vn/timelinelist/1711565/2.htm");
                if (response.IsSuccessStatusCode)
            {
                HtmlDocument document = new HtmlDocument();
                byte[] bytes = await response.Content.ReadAsByteArrayAsync();
                bytes = Decompress(bytes);
                string content = HttpUtility.HtmlDecode(Encoding.UTF8.GetString(bytes));
                document.LoadHtml(content);
                var nodes = document.DocumentNode.SelectSingleNode("//div[contains(@class, 'box-stream-item')]/div/p");
                Console.WriteLine(nodes.InnerText);
            }
        }
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
