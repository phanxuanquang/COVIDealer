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
            this.UploadDate = new System.Windows.Forms.Label();
            this.Channel = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.RichTextBox();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.Summary);
            this.contentPanel.Controls.Add(this.UploadDate);
            this.contentPanel.Controls.Add(this.Channel);
            this.contentPanel.Controls.Add(this.Tittle);
            this.contentPanel.Controls.Add(this.ThumbnailImage);
            this.contentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentPanel.Location = new System.Drawing.Point(8, 8);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(987, 277);
            this.contentPanel.TabIndex = 0;
            this.contentPanel.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.contentPanel.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Summary
            // 
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.BackColor = System.Drawing.Color.White;
            this.Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Summary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Summary.ForeColor = System.Drawing.Color.Gray;
            this.Summary.Location = new System.Drawing.Point(490, 171);
            this.Summary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Size = new System.Drawing.Size(495, 106);
            this.Summary.TabIndex = 15;
            this.Summary.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            this.Summary.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.Summary.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // UploadDate
            // 
            this.UploadDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UploadDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UploadDate.ForeColor = System.Drawing.Color.Gray;
            this.UploadDate.Location = new System.Drawing.Point(488, 92);
            this.UploadDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Size = new System.Drawing.Size(112, 25);
            this.UploadDate.TabIndex = 14;
            this.UploadDate.Text = "Upload Date";
            this.UploadDate.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.UploadDate.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Channel
            // 
            this.Channel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Channel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Channel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Channel.ForeColor = System.Drawing.Color.Gray;
            this.Channel.Location = new System.Drawing.Point(488, 131);
            this.Channel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(499, 35);
            this.Channel.TabIndex = 13;
            this.Channel.Text = "Channel";
            this.Channel.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.Channel.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // Tittle
            // 
            this.Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tittle.BackColor = System.Drawing.Color.White;
            this.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(488, 3);
            this.Tittle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Size = new System.Drawing.Size(499, 85);
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
            this.ThumbnailImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(480, 277);
            this.ThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbnailImage.TabIndex = 11;
            this.ThumbnailImage.TabStop = false;
            this.ThumbnailImage.Click += new System.EventHandler(this.Tittle_Click);
            this.ThumbnailImage.MouseEnter += new System.EventHandler(this.contentPanel_MouseEnter);
            this.ThumbnailImage.MouseLeave += new System.EventHandler(this.contentPanel_MouseLeave);
            // 
            // VideoThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VideoThumbnail";
            this.Size = new System.Drawing.Size(1000, 292);
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
