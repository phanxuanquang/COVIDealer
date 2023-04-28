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
            this.UploadDate = new System.Windows.Forms.Label();
            this.Channel = new System.Windows.Forms.Label();
            this.Tittle = new System.Windows.Forms.Label();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadDate
            // 
            this.UploadDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UploadDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UploadDate.ForeColor = System.Drawing.Color.Gray;
            this.UploadDate.Location = new System.Drawing.Point(0, 249);
            this.UploadDate.Name = "UploadDate";
            this.UploadDate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.UploadDate.Size = new System.Drawing.Size(320, 22);
            this.UploadDate.TabIndex = 12;
            this.UploadDate.Text = "Time";
            // 
            // Channel
            // 
            this.Channel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Channel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Channel.ForeColor = System.Drawing.Color.Gray;
            this.Channel.Location = new System.Drawing.Point(0, 227);
            this.Channel.Name = "Channel";
            this.Channel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Channel.Size = new System.Drawing.Size(320, 22);
            this.Channel.TabIndex = 11;
            this.Channel.Text = "Channel";
            // 
            // Tittle
            // 
            this.Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(0, 180);
            this.Tittle.Name = "Tittle";
            this.Tittle.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Tittle.Size = new System.Drawing.Size(320, 47);
            this.Tittle.TabIndex = 10;
            this.Tittle.Text = "Tittle";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Thumbnail
            // 
            this.Thumbnail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumbnail.Dock = System.Windows.Forms.DockStyle.Top;
            this.Thumbnail.Location = new System.Drawing.Point(0, 0);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(320, 180);
            this.Thumbnail.TabIndex = 9;
            this.Thumbnail.TabStop = false;
            // 
            // VideoThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.UploadDate);
            this.Controls.Add(this.Channel);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.Thumbnail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "VideoThumbnail";
            this.Size = new System.Drawing.Size(320, 271);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UploadDate;
        private System.Windows.Forms.Label Channel;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.PictureBox Thumbnail;
    }
}
