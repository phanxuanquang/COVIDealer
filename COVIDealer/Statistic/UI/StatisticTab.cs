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
            covidCase.Text = data.Total.Internal.Cases.ToString("#,##0.###");
            treatedCase.Text = data.Total.Internal.Recovered.ToString("#,##0.###");
            deathCase.Text = data.Total.Internal.Death.ToString("#,##0.###");
        }

        private void Location_Label_Click(object sender, EventArgs e)
        {
            if (Location_Label.Text == "► Việt Nam:")
            {
                Location_Label.Text = "► Thế giới:";
                covidCase.Text = data.Total.World.Cases.ToString("#,##0.###");
                treatedCase.Text = data.Total.World.Recovered.ToString("#,##0.###");
                deathCase.Text = data.Total.World.Death.ToString("#,##0.###");
            }
            else if (Location_Label.Text == "► Thế giới:")
            {
                Location_Label.Text = "► Việt Nam:";
                covidCase.Text = data.Total.Internal.Cases.ToString("#,##0.###");
                treatedCase.Text = data.Total.Internal.Recovered.ToString("#,##0.###");
                deathCase.Text = data.Total.Internal.Death.ToString("#,##0.###");
            }
        }
    }
}
