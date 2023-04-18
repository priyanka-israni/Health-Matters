using Prototype.Resources;
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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        string APIKey = "7988f559a25d21d423a203d02f30b5ac";
        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", txtCity.Text, APIKey);
                var json = web.DownloadString(url);
                weatherInfo.Root info = JsonConvert.DeserializeObject<weatherInfo.Root>(json);

                pictureBox5.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon + ".png";

                txtTemprature.Text = "Temperature: " + Math.Round(info.main.temp).ToString();

                txtPressure.Text = "Pressure: " + info.main.pressure.ToString();

                txtHumidity.Text = "Humidity: " + info.main.humidity.ToString();

                txtSpeed.Text = "Speed: " + info.wind.speed.ToString();

                txtLocation.Text = "Location: " + info.sys.country;

                txtDescription.Text = "Weather description: " + info.weather[0].description.ToString();
            }
        }

        /* Tuesdays notes
         * https://openweathermap.org/img/w/
         * math.Round = round decimal to 1 decimal number
         * weather application in c# using open weather map API
        */
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            frm2.Show();
            this.Hide();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {
            /*
            //drop down list
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(170, 90);
            mybox.Size = new Size(235, 40);
            //ComboBoxStyle DropDownStyle = ComboBoxStyle.DropDown;
            mybox.Items.Add("Farnborough");
            mybox.Items.Add("Reading");

            this.Controls.Add(mybox);
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsAT frm2 = new SettingsAT();
            frm2.Show();
            this.Hide();
        }

        private void btn_HealthAdiveForToday_Click(object sender, EventArgs e)
        {
            Heath_Advice_for_Today frm2 = new Heath_Advice_for_Today();
            frm2.Show();
            this.Hide();
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_MonitorAirQualityData_Click(object sender, EventArgs e)
        {
            Monitor_Air_Quality frm2 = new Monitor_Air_Quality();
            frm2.Show();
            this.Hide();
        }

        private void btn_AllergiesAndConditions_Click(object sender, EventArgs e)
        {
            Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies frm2 = new Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies();
            frm2.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
