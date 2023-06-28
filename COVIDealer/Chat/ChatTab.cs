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
        private readonly DialogFlowService service = new DialogFlowService("user", "covidealer-bot-aqob");
        public ChatTab()
        {
            InitializeComponent();
        }
        private async void SendButton_Click(object sender, EventArgs e)
        {
            if(InputBox.Text != String.Empty)
            {
                MainIcon.Visible = false;
                string requestString = InputBox.Text;
                string responseString;
                InputBox.Clear();

                string clientText = "Client: " + requestString;
                int length = ChatArea.TextLength;
                ChatArea.AppendText(clientText + Environment.NewLine);
                ChatArea.SelectionStart = length;
                ChatArea.SelectionLength = clientText.Length;
                ChatArea.SelectionColor = Color.FromArgb(57, 133, 248);

                var response = await service.CheckIntent(requestString);
                responseString = response.FulfillmentText;
                ChatArea.AppendText("COVIDealer: " + responseString + Environment.NewLine);
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
            else if (e.KeyCode == Keys.Escape)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    InputBox.Clear();
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ChatArea.Clear();
            InputBox.Clear();
            MainIcon.Visible = true;
            this.Refresh();
        }
    }
}
