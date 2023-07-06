using HtmlAgilityPack;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class ArticleThumbnail : UserControl
    {
        string articleLink;
        public ArticleThumbnail(HtmlNode articleData)
        {
            InitializeComponent();
            Tittle.Text = articleData.ChildNodes["div"].ChildNodes["h2"].InnerText.Trim();
            Summary.Text = articleData.ChildNodes["div"].ChildNodes["p"].InnerText.Trim();
            ThumbnailImage.ImageLocation = articleData.ChildNodes["a"].ChildNodes["img"].Attributes["src"].Value;

            articleLink = "https://covid19.gov.vn" + articleData.ChildNodes["a"].Attributes["href"].Value;
        }

        private void ArticleThumbnail_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Tittle.BackColor = Summary.BackColor = contentPanel.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void ArticleThumbnail_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Tittle.BackColor = Summary.BackColor = contentPanel.BackColor = Color.White;
        }

        private void Tittle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(articleLink);
        }
    }
}
