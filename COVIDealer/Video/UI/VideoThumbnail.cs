using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class VideoThumbnail : UserControl
    {
        public Snippet snippet;
        public string videoID;
        public VideoThumbnail() 
        {
            InitializeComponent();
            
        }
        public void setParameter()
        {
            ThumbnailImage.ImageLocation = snippet.Thumbnails.Medium.Url;
            Tittle.Text = snippet.Title;
            Channel.Text = snippet.ChannelTitle;
            UploadDate.Text = snippet.PublishTime.ToString("dd/MM/yyyy - HH:mm");
        }


        private void Tittle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/embed/" + videoID);
        }

        private void ThumbnailImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/embed/" + videoID);
        }
    }
}
