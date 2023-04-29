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
            Summary.Text = snippet.Description;
        }

        private void contentPanel_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Tittle.BackColor = Channel.BackColor = UploadDate.BackColor = Summary.BackColor = contentPanel.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void contentPanel_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Tittle.BackColor = Channel.BackColor = UploadDate.BackColor = Summary.BackColor = contentPanel.BackColor = Color.White;
        }

        private void Tittle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/embed/" + videoID);
        }        
    }
}
