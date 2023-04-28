namespace COVIDealer
{
    partial class MainWindows
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindows));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.VideoTab_Button = new Guna.UI.WinForms.GunaTileButton();
            this.NewsTab_Button = new Guna.UI.WinForms.GunaTileButton();
            this.SearchTab_Button = new Guna.UI.WinForms.GunaTileButton();
            this.StatisticsTab_Button = new Guna.UI.WinForms.GunaTileButton();
            this.ChatTab_Button = new Guna.UI.WinForms.GunaTileButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.MenuPanel.Controls.Add(this.VideoTab_Button);
            this.MenuPanel.Controls.Add(this.NewsTab_Button);
            this.MenuPanel.Controls.Add(this.SearchTab_Button);
            this.MenuPanel.Controls.Add(this.StatisticsTab_Button);
            this.MenuPanel.Controls.Add(this.ChatTab_Button);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(130, 761);
            this.MenuPanel.TabIndex = 0;
            // 
            // VideoTab_Button
            // 
            this.VideoTab_Button.Animated = true;
            this.VideoTab_Button.AnimationHoverSpeed = 0.07F;
            this.VideoTab_Button.AnimationSpeed = 0.03F;
            this.VideoTab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.VideoTab_Button.BorderColor = System.Drawing.Color.Black;
            this.VideoTab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.VideoTab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.VideoTab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.VideoTab_Button.ForeColor = System.Drawing.Color.White;
            this.VideoTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("VideoTab_Button.Image")));
            this.VideoTab_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.VideoTab_Button.Location = new System.Drawing.Point(0, 531);
            this.VideoTab_Button.Name = "VideoTab_Button";
            this.VideoTab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.VideoTab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.VideoTab_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.VideoTab_Button.OnHoverImage = null;
            this.VideoTab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.VideoTab_Button.Size = new System.Drawing.Size(130, 130);
            this.VideoTab_Button.TabIndex = 5;
            this.VideoTab_Button.Text = "BẢN TIN";
            this.VideoTab_Button.Click += new System.EventHandler(this.VideoTab_Button_Click);
            // 
            // NewsTab_Button
            // 
            this.NewsTab_Button.Animated = true;
            this.NewsTab_Button.AnimationHoverSpeed = 0.07F;
            this.NewsTab_Button.AnimationSpeed = 0.03F;
            this.NewsTab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NewsTab_Button.BorderColor = System.Drawing.Color.Black;
            this.NewsTab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NewsTab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.NewsTab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NewsTab_Button.ForeColor = System.Drawing.Color.White;
            this.NewsTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("NewsTab_Button.Image")));
            this.NewsTab_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.NewsTab_Button.Location = new System.Drawing.Point(0, 401);
            this.NewsTab_Button.Name = "NewsTab_Button";
            this.NewsTab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.NewsTab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.NewsTab_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.NewsTab_Button.OnHoverImage = null;
            this.NewsTab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.NewsTab_Button.Size = new System.Drawing.Size(130, 130);
            this.NewsTab_Button.TabIndex = 4;
            this.NewsTab_Button.Text = "TIN TỨC";
            this.NewsTab_Button.Click += new System.EventHandler(this.NewsTab_Button_Click);
            // 
            // SearchTab_Button
            // 
            this.SearchTab_Button.Animated = true;
            this.SearchTab_Button.AnimationHoverSpeed = 0.07F;
            this.SearchTab_Button.AnimationSpeed = 0.03F;
            this.SearchTab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SearchTab_Button.BorderColor = System.Drawing.Color.Black;
            this.SearchTab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SearchTab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.SearchTab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SearchTab_Button.ForeColor = System.Drawing.Color.White;
            this.SearchTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("SearchTab_Button.Image")));
            this.SearchTab_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.SearchTab_Button.Location = new System.Drawing.Point(0, 271);
            this.SearchTab_Button.Name = "SearchTab_Button";
            this.SearchTab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.SearchTab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SearchTab_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.SearchTab_Button.OnHoverImage = null;
            this.SearchTab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.SearchTab_Button.Size = new System.Drawing.Size(130, 130);
            this.SearchTab_Button.TabIndex = 3;
            this.SearchTab_Button.Text = "TRA CỨU";
            this.SearchTab_Button.Click += new System.EventHandler(this.SearchTab_Button_Click);
            // 
            // StatisticsTab_Button
            // 
            this.StatisticsTab_Button.Animated = true;
            this.StatisticsTab_Button.AnimationHoverSpeed = 0.07F;
            this.StatisticsTab_Button.AnimationSpeed = 0.03F;
            this.StatisticsTab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.StatisticsTab_Button.BorderColor = System.Drawing.Color.Black;
            this.StatisticsTab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.StatisticsTab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.StatisticsTab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StatisticsTab_Button.ForeColor = System.Drawing.Color.White;
            this.StatisticsTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("StatisticsTab_Button.Image")));
            this.StatisticsTab_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.StatisticsTab_Button.Location = new System.Drawing.Point(0, 141);
            this.StatisticsTab_Button.Name = "StatisticsTab_Button";
            this.StatisticsTab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.StatisticsTab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.StatisticsTab_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.StatisticsTab_Button.OnHoverImage = null;
            this.StatisticsTab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.StatisticsTab_Button.Size = new System.Drawing.Size(130, 130);
            this.StatisticsTab_Button.TabIndex = 2;
            this.StatisticsTab_Button.Text = "THỐNG KÊ";
            this.StatisticsTab_Button.Click += new System.EventHandler(this.StatisticsTab_Button_Click);
            // 
            // ChatTab_Button
            // 
            this.ChatTab_Button.Animated = true;
            this.ChatTab_Button.AnimationHoverSpeed = 0.07F;
            this.ChatTab_Button.AnimationSpeed = 0.03F;
            this.ChatTab_Button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChatTab_Button.BorderColor = System.Drawing.Color.Black;
            this.ChatTab_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ChatTab_Button.FocusedColor = System.Drawing.Color.Empty;
            this.ChatTab_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChatTab_Button.ForeColor = System.Drawing.Color.White;
            this.ChatTab_Button.Image = ((System.Drawing.Image)(resources.GetObject("ChatTab_Button.Image")));
            this.ChatTab_Button.ImageSize = new System.Drawing.Size(52, 52);
            this.ChatTab_Button.Location = new System.Drawing.Point(0, 11);
            this.ChatTab_Button.Name = "ChatTab_Button";
            this.ChatTab_Button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ChatTab_Button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ChatTab_Button.OnHoverForeColor = System.Drawing.Color.White;
            this.ChatTab_Button.OnHoverImage = null;
            this.ChatTab_Button.OnPressedColor = System.Drawing.Color.Black;
            this.ChatTab_Button.Size = new System.Drawing.Size(130, 130);
            this.ChatTab_Button.TabIndex = 1;
            this.ChatTab_Button.Text = "TRÒ CHUYỆN";
            this.ChatTab_Button.Click += new System.EventHandler(this.ChatTab_Button_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(139, 11);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1118, 739);
            this.mainPanel.TabIndex = 1;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "MainWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COVIDealer";
            this.Load += new System.EventHandler(this.MainWindows_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private Guna.UI.WinForms.GunaTileButton ChatTab_Button;
        private Guna.UI.WinForms.GunaTileButton StatisticsTab_Button;
        private Guna.UI.WinForms.GunaTileButton SearchTab_Button;
        private Guna.UI.WinForms.GunaTileButton NewsTab_Button;
        private Guna.UI.WinForms.GunaTileButton VideoTab_Button;
        private System.Windows.Forms.Panel mainPanel;
    }
}

