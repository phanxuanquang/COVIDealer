namespace COVIDealer
{
    partial class StatisticTab
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
            this.Location_Label = new System.Windows.Forms.Label();
            this.Statistics_Panel = new System.Windows.Forms.Panel();
            this.totalCase_Panel = new System.Windows.Forms.Panel();
            this.covidCase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treatedCase_Panel = new System.Windows.Forms.Panel();
            this.treatedCase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deathCase_Panel = new System.Windows.Forms.Panel();
            this.deathCase = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Statistics_Panel.SuspendLayout();
            this.totalCase_Panel.SuspendLayout();
            this.treatedCase_Panel.SuspendLayout();
            this.deathCase_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Location_Label
            // 
            this.Location_Label.AutoSize = true;
            this.Location_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Location_Label.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Location_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(52)))), ((int)(((byte)(145)))));
            this.Location_Label.Location = new System.Drawing.Point(3, 0);
            this.Location_Label.Name = "Location_Label";
            this.Location_Label.Size = new System.Drawing.Size(129, 28);
            this.Location_Label.TabIndex = 6;
            this.Location_Label.Text = "► Việt Nam:";
            this.Location_Label.Click += new System.EventHandler(this.Location_Label_Click);
            // 
            // Statistics_Panel
            // 
            this.Statistics_Panel.Controls.Add(this.deathCase_Panel);
            this.Statistics_Panel.Controls.Add(this.treatedCase_Panel);
            this.Statistics_Panel.Controls.Add(this.totalCase_Panel);
            this.Statistics_Panel.Controls.Add(this.Location_Label);
            this.Statistics_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Statistics_Panel.Location = new System.Drawing.Point(0, 0);
            this.Statistics_Panel.Name = "Statistics_Panel";
            this.Statistics_Panel.Size = new System.Drawing.Size(940, 111);
            this.Statistics_Panel.TabIndex = 7;
            // 
            // totalCase_Panel
            // 
            this.totalCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.totalCase_Panel.Controls.Add(this.covidCase);
            this.totalCase_Panel.Controls.Add(this.label1);
            this.totalCase_Panel.Location = new System.Drawing.Point(0, 32);
            this.totalCase_Panel.Name = "totalCase_Panel";
            this.totalCase_Panel.Size = new System.Drawing.Size(300, 79);
            this.totalCase_Panel.TabIndex = 7;
            // 
            // covidCase
            // 
            this.covidCase.BackColor = System.Drawing.Color.Transparent;
            this.covidCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.covidCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.covidCase.ForeColor = System.Drawing.Color.Red;
            this.covidCase.Location = new System.Drawing.Point(0, 28);
            this.covidCase.Name = "covidCase";
            this.covidCase.Size = new System.Drawing.Size(300, 51);
            this.covidCase.TabIndex = 5;
            this.covidCase.Text = "0";
            this.covidCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "SỐ CA NHIỄM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // treatedCase_Panel
            // 
            this.treatedCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treatedCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(246)))), ((int)(((byte)(236)))));
            this.treatedCase_Panel.Controls.Add(this.treatedCase);
            this.treatedCase_Panel.Controls.Add(this.label4);
            this.treatedCase_Panel.Location = new System.Drawing.Point(320, 32);
            this.treatedCase_Panel.Name = "treatedCase_Panel";
            this.treatedCase_Panel.Size = new System.Drawing.Size(300, 79);
            this.treatedCase_Panel.TabIndex = 8;
            // 
            // treatedCase
            // 
            this.treatedCase.BackColor = System.Drawing.Color.Transparent;
            this.treatedCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatedCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.treatedCase.ForeColor = System.Drawing.Color.Green;
            this.treatedCase.Location = new System.Drawing.Point(0, 28);
            this.treatedCase.Name = "treatedCase";
            this.treatedCase.Size = new System.Drawing.Size(300, 51);
            this.treatedCase.TabIndex = 5;
            this.treatedCase.Text = "0";
            this.treatedCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "KHỎI BỆNH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // deathCase_Panel
            // 
            this.deathCase_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deathCase_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.deathCase_Panel.Controls.Add(this.deathCase);
            this.deathCase_Panel.Controls.Add(this.label6);
            this.deathCase_Panel.Location = new System.Drawing.Point(640, 32);
            this.deathCase_Panel.Name = "deathCase_Panel";
            this.deathCase_Panel.Size = new System.Drawing.Size(300, 79);
            this.deathCase_Panel.TabIndex = 9;
            // 
            // deathCase
            // 
            this.deathCase.BackColor = System.Drawing.Color.Transparent;
            this.deathCase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deathCase.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deathCase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.deathCase.Location = new System.Drawing.Point(0, 28);
            this.deathCase.Name = "deathCase";
            this.deathCase.Size = new System.Drawing.Size(300, 51);
            this.deathCase.TabIndex = 5;
            this.deathCase.Text = "0";
            this.deathCase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "TỬ VONG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // StatisticTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Statistics_Panel);
            this.Name = "StatisticTab";
            this.Size = new System.Drawing.Size(940, 651);
            this.Statistics_Panel.ResumeLayout(false);
            this.Statistics_Panel.PerformLayout();
            this.totalCase_Panel.ResumeLayout(false);
            this.treatedCase_Panel.ResumeLayout(false);
            this.deathCase_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private InternalStatistics_Panel internalStatistics_Panel;
        private System.Windows.Forms.Label Location_Label;
        private System.Windows.Forms.Panel Statistics_Panel;
        private System.Windows.Forms.Panel totalCase_Panel;
        private System.Windows.Forms.Label covidCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel treatedCase_Panel;
        private System.Windows.Forms.Label treatedCase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel deathCase_Panel;
        private System.Windows.Forms.Label deathCase;
        private System.Windows.Forms.Label label6;
    }
}
