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
    public partial class SettingsF : Form
    {
        public SettingsF()
        {
            InitializeComponent();
        }

        private void btn_AccessibilityTools_Click(object sender, EventArgs e)
        {
            SettingsAT frm2 = new SettingsAT();
            frm2.Show();
        }

        private void btn_UserInfo_Click(object sender, EventArgs e)
        {
            SettingUI frm2 = new SettingUI();
            frm2.Show();
        }

        private void btn_CustomerSupport_Click(object sender, EventArgs e)
        {
            SettingUI frm2 = new SettingUI();
            frm2.Show();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            
        }
    }
}
