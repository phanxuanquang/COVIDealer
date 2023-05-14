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
            this.contentPanel = new System.Windows.Forms.Panel();
            this.Summary = new System.Windows.Forms.RichTextBox();
            this.Tittle = new System.Windows.Forms.RichTextBox();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.Channel = new System.Windows.Forms.Label();
            this.UploadDate = new System.Windows.Forms.Label();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.Summary);
            this.contentPanel.Controls.Add(this.UploadDate);
            this.contentPanel.Controls.Add(this.Channel);
            this.contentPanel.Controls.Add(this.Tittle);
            this.contentPanel.Controls.Add(this.ThumbnailImage);
            this.contentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentPanel.Location = new System.Drawing.Point(5, 5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(757, 180);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.contentPanel.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Summary
            // 
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.BackColor = System.Drawing.Color.White;
            this.Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Summary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Summary.ForeColor = System.Drawing.Color.Gray;
            this.Summary.Location = new System.Drawing.Point(327, 111);
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Size = new System.Drawing.Size(429, 69);
            this.Summary.TabIndex = 15;
            this.Summary.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            this.Summary.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.Summary.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Tittle
            // 
            this.Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tittle.BackColor = System.Drawing.Color.White;
            this.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(325, 2);
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Size = new System.Drawing.Size(432, 55);
            this.Tittle.TabIndex = 12;
            this.Tittle.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            this.Tittle.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.Tittle.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.BackColor = System.Drawing.Color.Black;
            this.ThumbnailImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThumbnailImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.ThumbnailImage.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(320, 180);
            this.ThumbnailImage.TabIndex = 11;
            this.ThumbnailImage.TabStop = false;
            this.ThumbnailImage.Click += new System.EventHandler(this.Tittle_Click);
            this.ThumbnailImage.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.ThumbnailImage.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Channel
            // 
            this.Channel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Channel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Channel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Channel.ForeColor = System.Drawing.Color.Gray;
            this.Channel.Location = new System.Drawing.Point(325, 85);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(432, 23);
            this.Channel.TabIndex = 13;
            this.Channel.Text = "Channel";
            this.Channel.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.Channel.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // UploadDate
            // 
            this.UploadDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UploadDate.ForeColor = System.Drawing.Color.Gray;
            this.UploadDate.Location = new System.Drawing.Point(325, 60);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(432, 23);
            this.UploadDate.TabIndex = 14;
            this.UploadDate.Text = "Upload Date";
            this.UploadDate.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.UploadDate.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // VideoThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPanel);
            this.DoubleBuffered = true;
            this.Name = "VideoThumbnail";
            this.Size = new System.Drawing.Size(766, 190);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RichTextBox Summary;
        private System.Windows.Forms.RichTextBox Tittle;
        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.Label UploadDate;
        private System.Windows.Forms.Label Channel;
    }
}
