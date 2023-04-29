namespace COVIDealer
{
    partial class VideoThumbnail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.UploadDate = new System.Windows.Forms.Label();
            this.Channel = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.BackColor = System.Drawing.Color.Black;
            this.ThumbnailImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThumbnailImage.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(320, 180);
            this.ThumbnailImage.TabIndex = 0;
            this.ThumbnailImage.TabStop = false;
            this.ThumbnailImage.Click += new System.EventHandler(this.ThumbnailImage_Click);
            // 
            // UploadDate
            // 
            this.UploadDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UploadDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UploadDate.ForeColor = System.Drawing.Color.Gray;
            this.UploadDate.Location = new System.Drawing.Point(0, 243);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UploadDate.Size = new System.Drawing.Size(320, 22);
            this.UploadDate.TabIndex = 2;
            this.UploadDate.Text = "Upload Date";
            // 
            // Channel
            // 
            this.Channel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Channel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Channel.ForeColor = System.Drawing.Color.Gray;
            this.Channel.Location = new System.Drawing.Point(0, 221);
            this.Channel.Name = "Channel";
            this.Channel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Channel.Size = new System.Drawing.Size(320, 22);
            this.Channel.TabIndex = 3;
            this.Channel.Text = "Channel";
            // 
            // Tittle
            // 
            this.Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tittle.BackColor = System.Drawing.SystemColors.Control;
            this.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(7, 183);
            this.Tittle.Margin = new System.Windows.Forms.Padding(0);
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Size = new System.Drawing.Size(306, 38);
            this.Tittle.TabIndex = 4;
            this.Tittle.Text = "Video Tittle";
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            // 
            // VideoThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Channel);
            this.Controls.Add(this.UploadDate);
            this.Controls.Add(this.ThumbnailImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "VideoThumbnail";
            this.Size = new System.Drawing.Size(320, 265);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.Label UploadDate;
        private System.Windows.Forms.Label Channel;
        private System.Windows.Forms.RichTextBox Tittle;
    }
}
