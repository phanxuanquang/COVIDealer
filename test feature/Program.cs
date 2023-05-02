using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.XPath;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using HtmlAgilityPack;

class Program
{
    static void Main()
    {
        ////string url = "https://covid19.gov.vn/timelinelist/1711565/1.htm";
        ////string xpath = "/html/body/div[1]/div/h2/a";
        //// Create a new WebClient instance to download the HTML content of the website
        //// Create an HtmlWeb object to download the HTML content

        //HtmlWeb web = new HtmlWeb()
        //{
        //    AutoDetectEncoding = false,
        //    OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
        //};

        //HtmlDocument doc = web.Load("https://covid19.gov.vn/timelinelist/1711565/1.htm");

        //// Use XPath to select an element by its class name
        //HtmlNode node = doc.DocumentNode.SelectSingleNode("//html/body/div[1]");

        //// Print the text content
        //Console.WriteLine(node.InnerText);

    }



    //string url = "https://covid19.gov.vn/timelinelist/1711565/1.htm";

    //var htmlDoc = new HtmlDocument();
    //htmlDoc.OptionReadEncoding = false;
    //var request = (HttpWebRequest)WebRequest.Create(url);
    //request.Method = "GET";
    //using (var response = (HttpWebResponse)request.GetResponse())
    //{
    //    using (var stream = response.GetResponseStream())
    //    {
    //        htmlDoc.Load(stream, Encoding.UTF8);
    //    }
    //}
    //HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//html/body/div[1]");

    //Console.WriteLine(node.InnerText);
}
}
