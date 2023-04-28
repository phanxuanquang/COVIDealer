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
        private MetroFramework.Controls.MetroComboBox countries_ComboBox;
    }
}