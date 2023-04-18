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
    public partial class SettingsAT : Form
    {
        public SettingsAT()
        {
            InitializeComponent();
        }

        private void btn_AccessibilityTools_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_UserInfo_Click(object sender, EventArgs e)
        {
            SettingUI frm2 = new SettingUI();
            frm2.Show();
            this.Hide();
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

        private void SettingsAT_Load(object sender, EventArgs e)
        {
            //drop down list
            ComboBox mybox = new ComboBox();
            mybox.Location = new Point(80, 320);
            mybox.Size = new Size(150, 40);
            //ComboBoxStyle DropDownStyle = ComboBoxStyle.DropDown;
            mybox.Items.Add("Light mode");
            mybox.Items.Add("Dark mode");

            this.Controls.Add(mybox);


            //drop down list
            ComboBox mybox2 = new ComboBox();
            mybox2.Location = new Point(330, 320);
            mybox2.Size = new Size(150, 40);
            //ComboBoxStyle DropDownStyle = ComboBoxStyle.DropDown;
            mybox2.Items.Add("10");
            mybox2.Items.Add("12");
            mybox2.Items.Add("13");
            mybox2.Items.Add("14");

            this.Controls.Add(mybox2);


            //drop down list
            ComboBox mybox3 = new ComboBox();
            mybox3.Location = new Point(590, 320);
            mybox3.Size = new Size(150, 40);
            //ComboBoxStyle DropDownStyle = ComboBoxStyle.DropDown;
            mybox3.Items.Add("English");
            mybox3.Items.Add("French");
            mybox3.Items.Add("German");

            this.Controls.Add(mybox3);
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }
    }
}
