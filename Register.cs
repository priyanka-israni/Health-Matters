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
using System.Data.OleDb;
using System.Web;

namespace Prototype
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login frm2 = new Login();
            frm2.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string user_reg = txtUsername.Text;
            string pass_reg = txtPassword.Text;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=M:\Task 2\FINAL OUTCOME\Final Version\Login.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Login(username_register, password_register) VALUES (@user_reg, @pass_reg)";
                

                using (OleDbCommand command = new OleDbCommand(query,connection))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Registration Complete!");
                        command.Parameters.AddWithValue(@"username_register", user_reg);
                        command.Parameters.AddWithValue(@"password_register", pass_reg);
                        command.ExecuteNonQuery();

                        Login frm2 = new Login();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match, Try again!");
                        Register frm2 = new Register();
                    }
                }
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            Homepage frm2 = new Homepage();
            frm2.Show();
            this.Hide();
        }
    }
}
