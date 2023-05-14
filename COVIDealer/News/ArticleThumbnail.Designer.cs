namespace COVIDealer
{
    partial class ArticleThumbnail
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
            this.Summary = new System.Windows.Forms.RichTextBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.RichTextBox();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Summary
            // 
            this.Summary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Summary.BackColor = System.Drawing.Color.White;
            this.Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Summary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Summary.ForeColor = System.Drawing.Color.Gray;
            this.Summary.Location = new System.Drawing.Point(270, 86);
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Size = new System.Drawing.Size(429, 74);
            this.Summary.TabIndex = 15;
            this.Summary.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.Summary);
            this.contentPanel.Controls.Add(this.Tittle);
            this.contentPanel.Controls.Add(this.ThumbnailImage);
            this.contentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentPanel.Location = new System.Drawing.Point(5, 5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(700, 162);
            this.contentPanel.TabIndex = 1;
            // 
            // Tittle
            // 
            this.Tittle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tittle.BackColor = System.Drawing.Color.White;
            this.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(268, 30);
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Size = new System.Drawing.Size(432, 55);
            this.Tittle.TabIndex = 12;
            this.Tittle.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            this.Tittle.Click += new System.EventHandler(this.Tittle_Click);
            // 
            // ThumbnailImage
            // 
            this.ThumbnailImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ThumbnailImage.BackColor = System.Drawing.Color.Transparent;
            this.ThumbnailImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThumbnailImage.Location = new System.Drawing.Point(0, 0);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(260, 162);
            this.ThumbnailImage.TabIndex = 11;
            this.ThumbnailImage.TabStop = false;
            // 
            // ArticleThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.DoubleBuffered = true;
            this.Name = "ArticleThumbnail";
            this.Size = new System.Drawing.Size(711, 172);
            this.MouseEnter += new System.EventHandler(this.ArticleThumbnail_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ArticleThumbnail_MouseLeave);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Summary;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RichTextBox Tittle;
        private System.Windows.Forms.PictureBox ThumbnailImage;
    }
}
