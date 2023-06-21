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
        bool isChatGPTOn;
        public ChatTab()
        {
            InitializeComponent();
            isChatGPTOn = false;
        }

        string getChatGPTResponseFrom(string input)
        {
            var YOUR_API_KEY = "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";
            var client = new RestClient("https://api.openai.com/v1");
            var request = new RestRequest("engines/text-davinci-003/completions", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Bearer {YOUR_API_KEY}");
            request.AddJsonBody(new { prompt = input, max_tokens = 4000, temperature = 0 });
            var response = client.Execute(request);
            var responseData = JObject.Parse(response.Content);
            return responseData["choices"][0]["text"].ToString().Trim();
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

                if (!isChatGPTOn)
                {
                    var response = await service.CheckIntent(requestString);
                    responseString = response.FulfillmentText;
                    ChatArea.AppendText("COVIDealer: " + responseString + Environment.NewLine);
                }
                else
                {
                    responseString = getChatGPTResponseFrom("Hãy nhớ rằng tất cả lời nói của tôi đều liên quan đến bệnh COVID-19. " + requestString);
                    ChatArea.AppendText("ChatGPT: " + responseString + Environment.NewLine);
                }
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

        private void ChatGPTMode_Click(object sender, EventArgs e)
        {
            if (isChatGPTOn)
            {
                isChatGPTOn = false;
                MessageBox.Show("ChatGPT đã được tắt. Từ giờ, COVIDealer sẽ là người giải đáp thắc mắc của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isChatGPTOn = true;
                MessageBox.Show("ChatGPT đã được bật. Từ giờ, ChatGPT sẽ là người giải đáp thắc mắc của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
