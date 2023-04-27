using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://disease.sh/v3/covid-19/countries");
            var countries = JsonConvert.DeserializeObject<Country[]>(await response.Content.ReadAsStringAsync());
            foreach (var country in countries)
            {
                countries_ComboBox.Items.Add(country.Name);
            }
            countries_ComboBox.Text = countries_ComboBox.Items[0].ToString();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://disease.sh/v3/covid-19/countries/" + countries_ComboBox.Text);
            var countries = JsonConvert.DeserializeObject<Country>(await response.Content.ReadAsStringAsync());
            richTextBox1.Text += countries.Population + "\n";
        }
    }
}