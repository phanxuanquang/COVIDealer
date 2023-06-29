namespace COVIDealer
{
    partial class ChatTab
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
            this.components = new System.ComponentModel.Container();
            this.ChatArea = new System.Windows.Forms.RichTextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButton = new Guna.UI2.WinForms.Guna2Button();
            this.InputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendButton = new Guna.UI2.WinForms.Guna2Button();
            this.MainIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatArea
            // 
            this.ChatArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatArea.BackColor = System.Drawing.Color.White;
            this.ChatArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChatArea.Location = new System.Drawing.Point(0, 0);
            this.ChatArea.Name = "ChatArea";
            this.ChatArea.ReadOnly = true;
            this.ChatArea.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatArea.Size = new System.Drawing.Size(1677, 1058);
            this.ChatArea.TabIndex = 21;
            this.ChatArea.Text = "";
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Animated = true;
            this.ResetButton.BorderRadius = 3;
            this.ResetButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.ResetButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ResetButton.CheckedState.Parent = this.ResetButton;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.CustomImages.Parent = this.ResetButton;
            this.ResetButton.FillColor = System.Drawing.Color.Crimson;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.HoverState.Parent = this.ResetButton;
            this.ResetButton.Image = global::COVIDealer.Properties.Resources.Reset;
            this.ResetButton.Location = new System.Drawing.Point(1586, 1071);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.ShadowDecoration.Parent = this.ResetButton;
            this.ResetButton.Size = new System.Drawing.Size(87, 51);
            this.ResetButton.TabIndex = 24;
            this.toolTip.SetToolTip(this.ResetButton, "Xóa nội dung trò chuyện");
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Animated = true;
            this.InputBox.AutoScroll = true;
            this.InputBox.BackColor = System.Drawing.Color.Gainsboro;
            this.InputBox.BorderRadius = 5;
            this.InputBox.BorderThickness = 2;
            this.InputBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputBox.DefaultText = "";
            this.InputBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.InputBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.InputBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.DisabledState.Parent = this.InputBox;
            this.InputBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.InputBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.InputBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.FocusedState.Parent = this.InputBox;
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.HoverState.Parent = this.InputBox;
            this.InputBox.IconLeft = global::COVIDealer.Properties.Resources.Text_Input;
            this.InputBox.Location = new System.Drawing.Point(9, 1071);
            this.InputBox.Margin = new System.Windows.Forms.Padding(9);
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.PlaceholderText = "Thắc mắc của bạn . . .";
            this.InputBox.SelectedText = "";
            this.InputBox.ShadowDecoration.Parent = this.InputBox;
            this.InputBox.Size = new System.Drawing.Size(1469, 51);
            this.InputBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputBox.TabIndex = 20;
            this.toolTip.SetToolTip(this.InputBox, "Nhập câu hỏi của bạn vào đây để Chatbot có thể trả lời.");
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Animated = true;
            this.SendButton.BorderRadius = 3;
            this.SendButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.SendButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SendButton.CheckedState.Parent = this.SendButton;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.CustomImages.Parent = this.SendButton;
            this.SendButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.HoverState.Parent = this.SendButton;
            this.SendButton.Image = global::COVIDealer.Properties.Resources.Send;
            this.SendButton.Location = new System.Drawing.Point(1491, 1071);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendButton.Name = "SendButton";
            this.SendButton.ShadowDecoration.Parent = this.SendButton;
            this.SendButton.Size = new System.Drawing.Size(87, 51);
            this.SendButton.TabIndex = 19;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MainIcon
            // 
            this.MainIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainIcon.Image = global::COVIDealer.Properties.Resources.Main_Icon;
            this.MainIcon.Location = new System.Drawing.Point(386, 158);
            this.MainIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainIcon.Name = "MainIcon";
            this.MainIcon.Size = new System.Drawing.Size(750, 769);
            this.MainIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainIcon.TabIndex = 22;
            this.MainIcon.TabStop = false;
            // 
            // ChatTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MainIcon);
            this.Controls.Add(this.ChatArea);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatTab";
            this.Size = new System.Drawing.Size(1677, 1137);
            ((System.ComponentModel.ISupportInitialize)(this.MainIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SendButton;
        private Guna.UI2.WinForms.Guna2TextBox InputBox;
        private System.Windows.Forms.RichTextBox ChatArea;
        private System.Windows.Forms.PictureBox MainIcon;
        private Guna.UI2.WinForms.Guna2Button ResetButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
