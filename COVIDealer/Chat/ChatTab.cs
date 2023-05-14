using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class ChatTab : UserControl
    {
        public ChatTab()
        {
            InitializeComponent();
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    InputBox.Text += System.Environment.NewLine;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ChatTab_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                richTextBox1.Text += "Quang không biết lý do, ";
            }
        }
    }
}
