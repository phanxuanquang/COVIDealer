using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVIDealer
{
    public partial class StatisticTab : UserControl
    {
        StatisticData statisticData;
        public StatisticTab()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void Location_Label_Click(object sender, EventArgs e)
        {
            if (Location_Label.Text == "► Việt Nam:")
            {
                Location_Label.Text = "► Thế giới:";
                covidCase.Text = statisticData.Total.World.Cases.ToString("#,##0.###");
                treatedCase.Text = statisticData.Total.World.Recovered.ToString("#,##0.###");
                deathCase.Text = statisticData.Total.World.Death.ToString("#,##0.###");
                newCaseLabel.Text = String.Empty;
                newTreatedCaseLabel.Text = String.Empty;
                newDeathCaseLabel.Text = String.Empty;
            }
            else if (Location_Label.Text == "► Thế giới:")
            {
                Location_Label.Text = "► Việt Nam:";
                covidCase.Text = statisticData.Total.Internal.Cases.ToString("#,##0.###");
                treatedCase.Text = statisticData.Total.Internal.Recovered.ToString("#,##0.###");
                deathCase.Text = statisticData.Total.Internal.Death.ToString("#,##0.###");
                newCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", statisticData.Today.Internal.Cases.ToString()); 
                newTreatedCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", statisticData.Today.Internal.Recovered.ToString());
                newDeathCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", statisticData.Today.Internal.Death.ToString());
            }
        }

        private void caseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = caseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            for (int i = 0; i < statisticData.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(statisticData.Overview[i].Date, statisticData.Overview[i].Cases);
            }
        }

        private void treatedCaseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = treatedCaseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            for (int i = 0; i < statisticData.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(statisticData.Overview[i].Date, statisticData.Overview[i].Recovered);
            }
        }

        private void deathCaseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = deathCaseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            for (int i = 0; i < statisticData.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(statisticData.Overview[i].Date, statisticData.Overview[i].Death);
            }
        }

        private async void StatisticTab_Load(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://static.pipezero.com/covid/data.json");
            statisticData = JsonConvert.DeserializeObject<StatisticData>(await response.Content.ReadAsStringAsync());

            covidCase.Text = statisticData.Today.Internal.Cases.ToString("#,##0.###");
            treatedCase.Text = statisticData.Today.Internal.Recovered.ToString("#,##0.###");
            deathCase.Text = statisticData.Today.Internal.Death.ToString("#,##0.###");

            caseButton_Click(this, null);
            Location_Label_Click(this, null);

            for (int i = 0; i < statisticData.Locations.Count; i++)
            {
                statisticTable.Rows.Add(statisticData.Locations[i].Name, statisticData.Locations[i].Cases, statisticData.Locations[i].CasesToday, statisticData.Locations[i].Death);
            }
        }
    }
}
