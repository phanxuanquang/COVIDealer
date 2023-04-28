namespace COVIDealer
{
    partial class VideoTab
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
            this.Video6 = new COVIDealer.VideoThumbnail();
            this.Video5 = new COVIDealer.VideoThumbnail();
            this.Video4 = new COVIDealer.VideoThumbnail();
            this.Video3 = new COVIDealer.VideoThumbnail();
            this.Video2 = new COVIDealer.VideoThumbnail();
            this.Video1 = new COVIDealer.VideoThumbnail();
            this.SuspendLayout();
            // 
            // Video6
            // 
            this.Video6.BackColor = System.Drawing.SystemColors.Control;
            this.Video6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video6.Location = new System.Drawing.Point(756, 385);
            this.Video6.Name = "Video6";
            this.Video6.Size = new System.Drawing.Size(320, 271);
            this.Video6.TabIndex = 5;
            // 
            // Video5
            // 
            this.Video5.BackColor = System.Drawing.SystemColors.Control;
            this.Video5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video5.Location = new System.Drawing.Point(399, 385);
            this.Video5.Name = "Video5";
            this.Video5.Size = new System.Drawing.Size(320, 271);
            this.Video5.TabIndex = 4;
            // 
            // Video4
            // 
            this.Video4.BackColor = System.Drawing.SystemColors.Control;
            this.Video4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video4.Location = new System.Drawing.Point(42, 385);
            this.Video4.Name = "Video4";
            this.Video4.Size = new System.Drawing.Size(320, 271);
            this.Video4.TabIndex = 3;
            // 
            // Video3
            // 
            this.Video3.BackColor = System.Drawing.SystemColors.Control;
            this.Video3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video3.Location = new System.Drawing.Point(756, 83);
            this.Video3.Name = "Video3";
            this.Video3.Size = new System.Drawing.Size(320, 271);
            this.Video3.TabIndex = 2;
            // 
            // Video2
            // 
            this.Video2.BackColor = System.Drawing.SystemColors.Control;
            this.Video2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video2.Location = new System.Drawing.Point(399, 83);
            this.Video2.Name = "Video2";
            this.Video2.Size = new System.Drawing.Size(320, 271);
            this.Video2.TabIndex = 1;
            // 
            // Video1
            // 
            this.Video1.BackColor = System.Drawing.SystemColors.Control;
            this.Video1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Video1.Location = new System.Drawing.Point(42, 83);
            this.Video1.Name = "Video1";
            this.Video1.Size = new System.Drawing.Size(320, 271);
            this.Video1.TabIndex = 0;
            // 
            // VideoTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Video6);
            this.Controls.Add(this.Video5);
            this.Controls.Add(this.Video4);
            this.Controls.Add(this.Video3);
            this.Controls.Add(this.Video2);
            this.Controls.Add(this.Video1);
            this.Name = "VideoTab";
            this.Size = new System.Drawing.Size(1118, 739);
            this.Load += new System.EventHandler(this.VideoTab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoThumbnail Video1;
        private VideoThumbnail Video2;
        private VideoThumbnail Video3;
        private VideoThumbnail Video6;
        private VideoThumbnail Video5;
        private VideoThumbnail Video4;
    }
}
