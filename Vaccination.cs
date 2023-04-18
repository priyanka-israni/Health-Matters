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
    public partial class Vaccination : Form
    {
        public Vaccination()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personal_Health_Track frm2 = new Personal_Health_Track();
            frm2.Show();
            this.Hide();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }
    }
}
