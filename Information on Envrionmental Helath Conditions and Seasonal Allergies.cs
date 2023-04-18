using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies : Form
    {
        public Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies()
        {
            InitializeComponent();
        }

        private void Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies_Load(object sender, EventArgs e)
        {
            
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

        private void btn_AllergiesAndConditions_Click(object sender, EventArgs e)
        {
            Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies fmr2 = new Information_on_Envrionmental_Helath_Conditions_and_Seasonal_Allergies();
            fmr2.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsAT frm2 = new SettingsAT();
            frm2.Show();
            this.Hide();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }
    }
}
