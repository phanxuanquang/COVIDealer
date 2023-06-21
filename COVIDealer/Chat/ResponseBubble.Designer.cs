namespace COVIDealer
{
    partial class ResponseBubble
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
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail
            // 
            this.Thumbnail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.Thumbnail.Dock = System.Windows.Forms.DockStyle.Right;
            this.Thumbnail.Image = global::COVIDealer.Properties.Resources.Chat_AI;
            this.Thumbnail.Location = new System.Drawing.Point(1577, 0);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(100, 70);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Thumbnail.TabIndex = 2;
            this.Thumbnail.TabStop = false;
            // 
            // ContentBox
            // 
            this.ContentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ContentBox.ForeColor = System.Drawing.Color.Black;
            this.ContentBox.Location = new System.Drawing.Point(3, 3);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ContentBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(1568, 64);
            this.ContentBox.TabIndex = 4;
            this.ContentBox.Text = "";
            // 
            // ResponseBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.Thumbnail);
            this.Name = "ResponseBubble";
            this.Size = new System.Drawing.Size(1677, 70);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.RichTextBox ContentBox;
    }
}
