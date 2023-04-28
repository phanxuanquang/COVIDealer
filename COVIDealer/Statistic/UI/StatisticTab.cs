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
    public partial class StatisticTab : UserControl
    {
        Data data;
        public StatisticTab(Data dataSource)
        {
            InitializeComponent();

            this.data= dataSource;
            covidCase.Text = data.Today.Internal.Cases.ToString("#,##0.###");
            treatedCase.Text = data.Today.Internal.Recovered.ToString("#,##0.###");
            deathCase.Text = data.Today.Internal.Death.ToString("#,##0.###");

            caseButton_Click(this, null);
            Location_Label_Click(this, null);

            for(int i = 0; i<data.Locations.Count; i++)
            {
                statisticTable.Rows.Add(data.Locations[i].Name, data.Locations[i].Cases, data.Locations[i].CasesToday, data.Locations[i].Death);
            }
        }

        private void Location_Label_Click(object sender, EventArgs e)
        {
            if (Location_Label.Text == "► Việt Nam:")
            {
                Location_Label.Text = "► Thế giới:";
                covidCase.Text = data.Total.World.Cases.ToString("#,##0.###");
                treatedCase.Text = data.Total.World.Recovered.ToString("#,##0.###");
                deathCase.Text = data.Total.World.Death.ToString("#,##0.###");
                newCaseLabel.Text = String.Empty;
                newTreatedCaseLabel.Text = String.Empty;
                newDeathCaseLabel.Text = String.Empty;
            }
            else if (Location_Label.Text == "► Thế giới:")
            {
                Location_Label.Text = "► Việt Nam:";
                covidCase.Text = data.Total.Internal.Cases.ToString("#,##0.###");
                treatedCase.Text = data.Total.Internal.Recovered.ToString("#,##0.###");
                deathCase.Text = data.Total.Internal.Death.ToString("#,##0.###");
                newCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", data.Today.Internal.Cases.ToString()); 
                newTreatedCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", data.Today.Internal.Recovered.ToString());
                newDeathCaseLabel.Text = String.Format("{0} ca mới trong 24 giờ qua", data.Today.Internal.Death.ToString());
            }
        }

        private void caseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = caseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            for (int i = 0; i < data.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(data.Overview[i].Date, data.Overview[i].Cases);
            }
        }

        private void treatedCaseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = treatedCaseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            for (int i = 0; i < data.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(data.Overview[i].Date, data.Overview[i].Recovered);
            }
        }

        private void deathCaseButton_Click(object sender, EventArgs e)
        {
            statisticChart.Series["Case"].Points.Clear();
            statisticChart.Titles["Case"].Text = deathCaseButton.Text;
            statisticChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            for (int i = 0; i < data.Overview.Count; i++)
            {
                statisticChart.Series["Case"].Points.AddXY(data.Overview[i].Date, data.Overview[i].Death);
            }
        }
    }
}
