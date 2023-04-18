using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Prototype
{
    public partial class Monitor_Air_Quality : Form
    {
        public Monitor_Air_Quality()
        {
            InitializeComponent();
        }

        private void Monitor_Air_Quality_Load(object sender, EventArgs e)
        {
            /*
            //drop list
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(170, 90);
            mybox.Size = new Size(235, 45);
            mybox.Items.Add("Reading");
            mybox.Items.Add("Farnborough");

            this.Controls.Add(mybox);
            */
        }

        private void btn_AllergiesAndConditions_Click(object sender, EventArgs e)
        {
            Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies frm2 = new Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies();
            frm2.Show();
            this.Hide();
        }

        private void btn_HealthAdiveForToday_Click(object sender, EventArgs e)
        {
            Heath_Advice_for_Today frm2 = new Heath_Advice_for_Today();
            frm2.Show();
            this.Hide();
        }

        private void btn_MonitorAirQualityData_Click(object sender, EventArgs e)
        {
            Monitor_Air_Quality frm2 = new Monitor_Air_Quality();
            frm2.Show();
            this.Hide();
        }

        private void lbl_HealthAdviceGroup_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Register frm2 = new Register();
            frm2.Show();
            this.Hide();
        }

        string APIKey = "7988f559a25d21d423a203d02f30b5ac";
        public void air()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", txtCity.Text, APIKey);
                var json = web.DownloadString(url);
                weatherInfo.Root info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                double lat = info.coord.lat;
                double lon = info.coord.lon;

                string url1 = string.Format("http://api.openweathermap.org/data/2.5/air_pollution?lat={0}&lon={1}&appid={2}", lat, lon, APIKey);
                var json1 = web.DownloadString(url1);
                AirQuality.Root info1 = JsonConvert.DeserializeObject<AirQuality.Root>(json1);

                int airQ = info1.list[0].main.aqi;
                lblAir.Text = airQ.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            air();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            Homepage fmr2 = new Homepage();
            fmr2.Show();
            this.Hide();
        }
    }
}
