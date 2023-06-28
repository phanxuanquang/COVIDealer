namespace COVIDealer
{
    partial class InputKeyForm
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
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.InputBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Animated = true;
            this.SaveButton.BorderRadius = 3;
            this.SaveButton.CheckedState.FillColor = System.Drawing.Color.Green;
            this.SaveButton.CheckedState.ForeColor = System.Drawing.Color.White;
            this.SaveButton.CheckedState.Parent = this.SaveButton;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.CustomImages.Parent = this.SaveButton;
            this.SaveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(133)))), ((int)(((byte)(248)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.HoverState.Parent = this.SaveButton;
            this.SaveButton.Location = new System.Drawing.Point(134, 118);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.ShadowDecoration.Parent = this.SaveButton;
            this.SaveButton.Size = new System.Drawing.Size(275, 51);
            this.SaveButton.TabIndex = 20;
            this.SaveButton.Text = "LƯU";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.InputBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InputBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InputBox.HoverState.Parent = this.InputBox;
            this.InputBox.IconLeft = global::COVIDealer.Properties.Resources.Text_Input;
            this.InputBox.Location = new System.Drawing.Point(25, 44);
            this.InputBox.Margin = new System.Windows.Forms.Padding(8);
            this.InputBox.Name = "InputBox";
            this.InputBox.PasswordChar = '\0';
            this.InputBox.PlaceholderText = "Nhập API Key của OpenAI tại đây";
            this.InputBox.SelectedText = "";
            this.InputBox.ShadowDecoration.Parent = this.InputBox;
            this.InputBox.Size = new System.Drawing.Size(487, 46);
            this.InputBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.InputBox.TabIndex = 21;
            // 
            // InputKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 202);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SaveButton);
            this.Name = "InputKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập API Key của OpenAI";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2TextBox InputBox;
    }
}