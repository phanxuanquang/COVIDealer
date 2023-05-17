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
        SaaUI.SaaChatBubble x = new SaaUI.SaaChatBubble();
        SaaUI.SaaChatBubble y = new SaaUI.SaaChatBubble();
        public ChatTab()
        {
            InitializeComponent();
            //
            x.Width = this.Width / 2;
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //InputBox.Text += System.Environment.NewLine;
                }
            }
        }

        private void InputBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                x.Width = this.Width / 2;
                x.Body = "jhsdfjhsd";
                chatArea.Controls.Add(x);
            }
            else if (e.Shift)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Do something
                }
            }
        }
    }
}
