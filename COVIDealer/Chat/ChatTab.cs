using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Xml.Linq;
using COVIDealer.Chat;
using SaaUI;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace COVIDealer
{
    public partial class ChatTab : UserControl
    {
        private readonly DialogFlowService service = new DialogFlowService("user", "testagent-xdib");
        public ChatTab()
        {
            InitializeComponent();
        }

        public async Task<string> getTranslationFrom(String inputString, string inputLanguage, string outputLanguage)
        {

            try
            {
                HttpClient httpClient = new HttpClient();
                var response = await httpClient.GetAsync($"https://clients5.google.com/translate_a/t?client=dict-chrome-ex&sl={inputLanguage}&tl={outputLanguage}&q={Uri.EscapeUriString(inputString)}");
                string result;
                JsonObject.Parse(await response.Content.ReadAsStringAsync()).AsArray().First().AsValue().TryGetValue<string>(out result);
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            if(InputBox.Text != String.Empty)
            {
                MainIcon.Visible = false;
                string requestString = InputBox.Text.Trim();
                string responseString;
                InputBox.Clear();

                string clientText = "Client: " + requestString;
                int length = ChatArea.TextLength;
                ChatArea.AppendText(clientText + Environment.NewLine);
                ChatArea.SelectionStart = length;
                ChatArea.SelectionLength = clientText.Length;
                ChatArea.SelectionColor = Color.Blue;

                try
                {
                    string newRequest = await getTranslationFrom(requestString, "vi", "en");

                    var response = await service.CheckIntent(newRequest, "en");

                    responseString = await getTranslationFrom(response.FulfillmentText, "en", "vi");

                    ChatArea.AppendText("COVIDealer: " + responseString + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ChatArea.Clear();
            InputBox.Clear();
            MainIcon.Visible = true;
            this.Refresh();
        }
    }
}
