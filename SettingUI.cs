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
    public partial class SettingUI : Form
    {
        public SettingUI()
        {
            InitializeComponent();
        }

        private void btn_AccessibilityTools_Click(object sender, EventArgs e)
        {
            SettingsAT frm2 = new SettingsAT();
            frm2.Show();
            this.Hide();
        }

        private void btn_UserInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_CustomerSupport_Click(object sender, EventArgs e)
        {
            SettingCS frm2 = new SettingCS();
            frm2.Show();
            this.Hide();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            SettingsF frm2 = new SettingsF();
            frm2.Show();
            this.Hide();
        }
    }
}
