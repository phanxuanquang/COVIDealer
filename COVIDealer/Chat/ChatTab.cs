using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Xml.Linq;
using COVIDealer.Chat;
using SaaUI;
using System.Windows.Forms.DataVisualization.Charting;

namespace COVIDealer
{
    public partial class ChatTab : UserControl
    {
        SaaUI.SaaChatBubble x = new SaaUI.SaaChatBubble();
        SaaUI.SaaChatBubble y = new SaaUI.SaaChatBubble();
        private readonly DialogFlowService service = new DialogFlowService("user", "covidealer-bot-aqob");
        public ChatTab()
        {
            InitializeComponent();
            x.Width = this.Width / 2;
        }
        private async void SendButton_Click(object sender, EventArgs e)
        {
            if (InputBox.Text != String.Empty)
            {
                var dialogflowQueryResult = await service.CheckIntent(InputBox.Text);
                string responeMessage = dialogflowQueryResult.FulfillmentText;

                string clientText = "Client: " + InputBox.Text;
                int length = ChatArea.TextLength; 
                ChatArea.AppendText(clientText + Environment.NewLine);
                ChatArea.SelectionStart = length;
                ChatArea.SelectionLength = clientText.Length;
                ChatArea.SelectionColor = Color.Red;

                ChatArea.AppendText("COVIDealer: " + responeMessage + Environment.NewLine);
                InputBox.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thắc mắc của bạn để được giải đáp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(this, null);
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
