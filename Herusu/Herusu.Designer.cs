namespace Herusu
{
    partial class Herusu
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
            this.ChatSpace = new System.Windows.Forms.RichTextBox();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChatSpace
            // 
            this.ChatSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatSpace.BackColor = System.Drawing.Color.White;
            this.ChatSpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChatSpace.Font = new System.Drawing.Font("Open Sans Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            this.ChatSpace.Location = new System.Drawing.Point(13, 10);
            this.ChatSpace.Name = "ChatSpace";
            this.ChatSpace.ReadOnly = true;
            this.ChatSpace.Size = new System.Drawing.Size(735, 545);
            this.ChatSpace.TabIndex = 0;
            this.ChatSpace.Text = "";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.BackColor = System.Drawing.Color.White;
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputTextBox.Font = new System.Drawing.Font("Open Sans Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.InputTextBox.Location = new System.Drawing.Point(12, 565);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(631, 115);
            this.InputTextBox.TabIndex = 1;
            this.InputTextBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(649, 565);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(99, 115);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Herusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 691);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ChatSpace);
            this.Name = "Herusu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herusu Chatbot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ChatSpace;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Button SendButton;
    }
}

