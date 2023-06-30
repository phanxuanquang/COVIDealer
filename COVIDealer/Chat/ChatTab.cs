using COVIDealer.Chat;
using System;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (InputBox.Text != String.Empty)
            {
                MainIcon.Visible = false;
                string requestString = InputBox.Text.Trim();
                string responseString = String.Empty;
                InputBox.Clear();

                string clientText = "Client: " + requestString;
                int length = ChatArea.TextLength;
                ChatArea.AppendText(clientText + Environment.NewLine + Environment.NewLine);
                ChatArea.SelectionStart = length;
                ChatArea.SelectionLength = clientText.Length;
                ChatArea.SelectionColor = Color.Blue;

                try
                {
                    string engRequest = await getTranslationFrom(requestString, "vi", "en");

                    var engResponse = await service.CheckIntent(engRequest, "en");

                    responseString = await getTranslationFrom(engResponse.FulfillmentText, "en", "vi");

                    ChatArea.AppendText("𝐂𝐎𝐕𝐈𝐃𝐞𝐚𝐥𝐞𝐫: " + responseString + Environment.NewLine + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    string errorMessage = await getTranslationFrom(ex.Message, "en", "vi");
                    MessageBox.Show($"Lỗi phân tích câu hỏi. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thắc mắc của bạn để được giải đáp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
