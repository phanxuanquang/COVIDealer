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
            this.chatArea = new System.Windows.Forms.FlowLayoutPanel();
            this.treatedCaseButton = new Guna.UI2.WinForms.Guna2Button();
            this.InputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // chatArea
            // 
            this.chatArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatArea.AutoScroll = true;
            this.chatArea.BackColor = System.Drawing.Color.White;
            this.chatArea.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chatArea.Location = new System.Drawing.Point(0, 0);
            this.chatArea.Name = "chatArea";
            this.chatArea.Size = new System.Drawing.Size(1118, 689);
            this.chatArea.TabIndex = 0;
            // 
            // treatedCaseButton
            // 
            this.treatedCaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.treatedCaseButton.Animated = true;
            this.treatedCaseButton.BorderRadius = 3;
            this.treatedCaseButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.treatedCaseButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.treatedCaseButton.CheckedState.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treatedCaseButton.CustomImages.Parent = this.treatedCaseButton;
            this.treatedCaseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.treatedCaseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatedCaseButton.ForeColor = System.Drawing.Color.White;
            this.treatedCaseButton.HoverState.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Location = new System.Drawing.Point(1057, 695);
            this.treatedCaseButton.Name = "treatedCaseButton";
            this.treatedCaseButton.ShadowDecoration.Parent = this.treatedCaseButton;
            this.treatedCaseButton.Size = new System.Drawing.Size(58, 38);
            this.treatedCaseButton.TabIndex = 19;
            this.treatedCaseButton.Text = "GỬI";
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Animated = true;
            this.InputBox.BorderRadius = 3;
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
            this.InputBox.Location = new System.Drawing.Point(4, 695);
            this.InputBox.Margin = new System.Windows.Forms.Padding(6);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.PlaceholderText = "Thắc mắc của bạn . . .";
            this.InputBox.SelectedText = "";
            this.InputBox.ShadowDecoration.Parent = this.InputBox;
            this.InputBox.Size = new System.Drawing.Size(1048, 38);
            this.InputBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputBox.TabIndex = 20;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown_1);
            // 
            // ChatTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.treatedCaseButton);
            this.Controls.Add(this.chatArea);
            this.DoubleBuffered = true;
            this.Name = "ChatTab";
            this.Size = new System.Drawing.Size(1118, 739);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel chatArea;
        private Guna.UI2.WinForms.Guna2Button treatedCaseButton;
        private Guna.UI2.WinForms.Guna2TextBox InputBox;
    }
}
