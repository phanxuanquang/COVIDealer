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
        public VideoThumbnail()
        {
            InitializeComponent();
        }
        public VideoThumbnail(Snippet snippet)
        {
            InitializeComponent();

            Thumbnail.LoadAsync(snippet.Thumbnails.Medium.Url);
            Tittle.Text = snippet.Title;
            Channel.Text = snippet.ChannelTitle;
            UploadDate.Text = snippet.PublishTime.ToString("dd/mm/yyyy");
        }
    }
}
