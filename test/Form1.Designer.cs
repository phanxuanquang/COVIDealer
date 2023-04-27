namespace test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendButton = new Button();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new MetroSet_UI.Controls.MetroSetRichTextBox();
            countries_ComboBox = new MetroFramework.Controls.MetroComboBox();
            SuspendLayout();
            // 
            // SendButton
            // 
            SendButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendButton.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            SendButton.Location = new Point(1010, 737);
            SendButton.Name = "SendButton";
            SendButton.Size = new Size(174, 66);
            SendButton.TabIndex = 1;
            SendButton.Text = "SEND";
            SendButton.UseVisualStyleBackColor = true;
            SendButton.Click += SendButton_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.Location = new Point(12, 737);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(992, 66);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.AutoWordSelection = true;
            richTextBox1.BorderColor = Color.FromArgb(155, 155, 155);
            richTextBox1.DisabledBackColor = Color.FromArgb(204, 204, 204);
            richTextBox1.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            richTextBox1.DisabledForeColor = Color.FromArgb(136, 136, 136);
            richTextBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.HoverColor = Color.FromArgb(102, 102, 102);
            richTextBox1.IsDerivedStyle = true;
            richTextBox1.Lines = null;
            richTextBox1.Location = new Point(12, 41);
            richTextBox1.MaxLength = 32767;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = false;
            richTextBox1.Size = new Size(1172, 690);
            richTextBox1.Style = MetroSet_UI.Enums.Style.Light;
            richTextBox1.StyleManager = null;
            richTextBox1.TabIndex = 3;
            richTextBox1.ThemeAuthor = "Narwin";
            richTextBox1.ThemeName = "MetroLite";
            richTextBox1.WordWrap = true;
            // 
            // countries_ComboBox
            // 
            countries_ComboBox.FlatStyle = FlatStyle.Flat;
            countries_ComboBox.FormattingEnabled = true;
            countries_ComboBox.ItemHeight = 23;
            countries_ComboBox.Location = new Point(12, 6);
            countries_ComboBox.Name = "countries_ComboBox";
            countries_ComboBox.Size = new Size(181, 29);
            countries_ComboBox.Sorted = true;
            countries_ComboBox.TabIndex = 4;
            countries_ComboBox.UseSelectable = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 815);
            Controls.Add(countries_ComboBox);
            Controls.Add(richTextBox1);
            Controls.Add(richTextBox2);
            Controls.Add(SendButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Form1_Shown;
            ResumeLayout(false);
        }

        #endregion
        private Button SendButton;
        private RichTextBox richTextBox2;
        private MetroSet_UI.Controls.MetroSetRichTextBox richTextBox1;
        private MetroFramework.Controls.MetroComboBox countries_ComboBox;
    }
}