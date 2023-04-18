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
    public partial class Personal_Health_Track : Form
    {
        public Personal_Health_Track()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVaccineInfo_Click(object sender, EventArgs e)
        {
            Vaccination frm2 = new Vaccination();
            frm2.Show();
            this.Hide();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }

        private void btnStepCaloriesTotal_Click(object sender, EventArgs e)
        {
            //user will enter the number of steps done
            //the application will display the calories burnt in the same textbox. this is done by mutipling the number of steps and 0.4 (calories burnt in one step)
            var xText = textBox1.Text;
            var x = 0;
            if (!int.TryParse(xText, out x))
            {
                return;
            }
            var y = 0.4;
            var answer = x * y;
            textBox1.Text = answer.ToString();

            //the application will display the user if they have achieved their steps goal on the right side of the page.
            if (answer >= 4000)
            {
                txtStepGoal.Text = "Step Goal Achieved!";
                txtStepGoal.Show();
            }
            else
            {
                txtStepGoal.Text = "Step Goal NOT Achieved!";
                txtStepGoal.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //user will enter the number of excerise hours done
            //the application will display the calories burnt in the same textbox. this is done by mutipling the number of steps and 410 (calories burnt in one hour)
            var xText = textBox3.Text;
            var x = 0;
            if (!int.TryParse(xText, out x))
            {
                return;
            }
            var y = 410;
            var answer = x * y;
            textBox3.Text = answer.ToString();

            //the application will display the user if they have achieved their excerise goal on the right side of the page.
            if (answer >= 800)
            {
                txtExceriseGoal.Text = "Exercise Goal Achieved!";
                txtExceriseGoal.Show();
            }
            else
            {
                txtExceriseGoal.Text = "Exercise Goal NOT Achieved!";
                txtExceriseGoal.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
