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
    public partial class SettingCS : Form
    {
        public SettingCS()
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
            SettingUI frm2 = new SettingUI();
            frm2.Show();
            this.Hide();
        }

        private void btn_CustomerSupport_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            SettingsF frm2 = new SettingsF();
            frm2.Show();
            this.Hide();
        }

        private void SettingCS_Load(object sender, EventArgs e)
        {
            //drop down list
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(305, 280);
            mybox.Size = new Size(350, 40);
            //ComboBoxStyle DropDownStyle = ComboBoxStyle.DropDown;
            mybox.Items.Add("Can I view weather for more location?");
            mybox.Items.Add("What can I use it for?");
            mybox.Items.Add("Can I still use the app without logging in?");
            mybox.Items.Add("Who can view it?");

            this.Controls.Add(mybox);

            //if (mybox == mybox.Items())
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }
    }
}
