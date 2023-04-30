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
using HtmlAgilityPack;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            List<string> strings = GetArticleTitles();
            foreach (string s in strings)
            {
                richTextBox1.Text += s + "\n";
            }

        }

        public static List<string> GetArticleTitles()
        {
            // Create a new HtmlWeb instance to load the website
            var web = new HtmlWeb();

            // Load the website's HTML document
            var doc = web.Load("https://covid19.gov.vn/ban-tin-covid-19.htm");

            // Find the div tag with class "box-stream timeline_list"
            var divTag = doc.DocumentNode.SelectSingleNode("//div[@class='box-stream timeline_list']");

            // Extract the list of article elements
            var articleList = divTag.Descendants("article").ToList();

            // Extract the titles of each article and add them to a list
            var titleList = new List<string>();
            foreach (var article in articleList)
            {
                var titleNode = article.SelectSingleNode(".//h3[@class='box-stream-item']");
                if (titleNode != null)
                {
                    var title = titleNode.InnerText.Trim();
                    titleList.Add(title);
                }
            }

            return titleList;
        }
    }
}