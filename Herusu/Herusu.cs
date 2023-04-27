using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Herusu
{
    public partial class Herusu : Form
    {
        public Herusu()
        {
            InitializeComponent();

        }
        bool first = true;
        private void SendButton_Click(object sender, EventArgs e)
        {
            //var YOUR_API_KEY = "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"; 
            //var userInput = InputTextBox.Text;
            //ChatSpace.AppendText("User: " + userInput + Environment.NewLine);
            //var client = new RestClient("https://api.openai.com/v1");
            //var request = new RestRequest("engines/text-davinci-003/completions", Method.Post);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddHeader("Authorization", $"Bearer {YOUR_API_KEY}");
            //request.AddJsonBody(new { prompt = userInput, max_tokens = 4000, temperature = 0 });
            //var response = client.Execute(request);
            //var responseData = JObject.Parse(response.Content);
            //string output = responseData["choices"][0]["text"].ToString();
            //ChatSpace.AppendText("OpenAI: " + output + Environment.NewLine);
            //InputTextBox.Text = String.Empty;
            string input = InputTextBox.Text;
            showRequestToChatSpace();
            string apiKey = "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";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
            var content = new StringContent("{\"model\": \"text-davinci-003\", \"prompt\": \"" + input + "\", \"temperature\": 0, \"max_tokens\":4000}", Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://api.openai.com/v1/completions", content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            dynamic responseJson = JsonConvert.DeserializeObject(responseString);
            string completion = responseJson.choices[0].text;
            ChatSpace.Text += completion + "\n";
            
        }                                                                                      

        string getRespond(string request)
        {
            string answer = "Nothing";
            return String.Format("Herusu: {0} \n", answer);
        }

        void showRequestToChatSpace()
        {
           ChatSpace.Text += String.Format("Client: {0} \nHerusu: ", InputTextBox.Text);
           InputTextBox.Text = String.Empty;
        }
    }
}
