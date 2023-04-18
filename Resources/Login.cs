using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;

namespace Prototype.Resources
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Task 2\FINAL OUTCOME\Final Version\Login.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))

            {
                connection.Open();
                string user_reg = txtUsername.Text;
                string pass_reg = txtPassword.Text;
                string query = "SELECT COUNT (*) FROM Login WHERE username_register=@user_reg AND password_register=@pass_reg";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue(@"username_register", user_reg);
                    command.Parameters.AddWithValue(@"password_register", pass_reg);
                    int count = (int)command.ExecuteScalar();
                    
                    if (count > 0)
                    {
                        MessageBox.Show("Succesful!");
                        Personal_Health_Track frm2 = new Personal_Health_Track();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Unseccesful! Try again");
                    }
                }
            }

            /*
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Success!");

                Personal_Health_Track frm2 = new Personal_Health_Track();
                frm2.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
            */
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register frm2 = new Register();
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
