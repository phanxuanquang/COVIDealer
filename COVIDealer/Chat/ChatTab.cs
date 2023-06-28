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
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={inputLanguage}&tl={outputLanguage}&dt=t&q={HttpUtility.UrlEncode(inputString)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            string translatedText = String.Empty;

            using (HttpClient client = new HttpClient())
            {
                 translatedText = await client.GetStringAsync(url);
            }

            //string translatedText = webclient.DownloadString(url);
            try
            {
                //return translatedText.Substring(4, translatedText.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return translatedText;
            }
            catch
            {
                return "Có lỗi phát sinh. Vui lòng thử lại.";
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
                ChatArea.SelectionColor = Color.FromArgb(57, 133, 248);

                try
                {
                    string newRequest = await getTranslationFrom(requestString, "vi", "en");

                    //var response = await service.CheckIntent(newRequest, "en");
                    //var response = await service.CheckIntent(requestString, "en");

                    //responseString = await getTranslationFrom(response.FulfillmentText, "en", "vi");

                    ChatArea.AppendText("COVIDealer: " + newRequest + Environment.NewLine);
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
