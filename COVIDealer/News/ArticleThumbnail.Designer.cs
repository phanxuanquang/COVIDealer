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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.RichTextBox();
            this.ThumbnailImage = new System.Windows.Forms.PictureBox();
            this.contentPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Summary
            // 
            this.Summary.BackColor = System.Drawing.Color.White;
            this.Summary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Summary.Dock = System.Windows.Forms.DockStyle.Top;
            this.Summary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Summary.ForeColor = System.Drawing.Color.Gray;
            this.Summary.Location = new System.Drawing.Point(0, 118);
            this.Summary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Size = new System.Drawing.Size(587, 158);
            this.Summary.TabIndex = 15;
            this.Summary.Text = "Ca Mắc COVID-19 Tăng, Bình Dương Yêu Cầu 6 Trường Hợp Phải Đeo Khẩu Trang | SKĐS";
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.panel1);
            this.contentPanel.Controls.Add(this.ThumbnailImage);
            this.contentPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contentPanel.Location = new System.Drawing.Point(8, 8);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(984, 276);
            this.contentPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Summary);
            this.panel1.Controls.Add(this.Tittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 276);
            this.panel1.TabIndex = 16;
            // 
            // Tittle
            // 
            this.Tittle.BackColor = System.Drawing.Color.White;
            this.Tittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tittle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tittle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Tittle.Location = new System.Drawing.Point(0, 0);
            this.Tittle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.Size = new System.Drawing.Size(587, 118);
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
            this.ThumbnailImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThumbnailImage.Name = "ThumbnailImage";
            this.ThumbnailImage.Size = new System.Drawing.Size(390, 276);
            this.ThumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbnailImage.TabIndex = 11;
            this.ThumbnailImage.TabStop = false;
            // 
            // ArticleThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArticleThumbnail";
            this.Size = new System.Drawing.Size(1000, 292);
            this.MouseEnter += new System.EventHandler(this.ArticleThumbnail_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ArticleThumbnail_MouseLeave);
            this.contentPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Summary;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.RichTextBox Tittle;
        private System.Windows.Forms.PictureBox ThumbnailImage;
        private System.Windows.Forms.Panel panel1;
    }
}
