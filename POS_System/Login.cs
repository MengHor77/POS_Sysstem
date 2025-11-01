using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace POS_System
{
    public partial class Login : Form
    {
        DataBaseConnection db = new DataBaseConnection();
        public Login()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string pass = textBoxPassword.Text.Trim();
            string txtName = "";
            bool loginSuccess = false;

            //db.TestConnection();
            SqlConnection connection = db.GetConnection();
            connection.Open();
            string selectQuery = "SELECT username, password, role FROM [Users]";
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string dbUsername = reader["username"].ToString();
                string dbPassword = reader["password"].ToString();
                string dbRole = reader["role"].ToString();

                if (username.Equals(dbUsername, StringComparison.OrdinalIgnoreCase) && pass == dbPassword)
                {
                    loginSuccess = true;
                    if (dbRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        txtName = "Admin";
                        MessageBox.Show("Login " + txtName + " Success!");
                        POS_System.Controls.MainControlForm dashboard = new POS_System.Controls.MainControlForm();
                        dashboard.Show();
                        this.Hide();
                    }
                    else if (dbRole.Equals("Cashier", StringComparison.OrdinalIgnoreCase))
                    {
                        txtName = "Cashier";
                        MessageBox.Show("Login " + txtName + " Success!");
                        POS_System.Staff st = new POS_System.Staff();
                        st.Show();
                        this.Hide();
                    }
                    break;
                }
            }

            if (!loginSuccess)
            {
                MessageBox.Show("Invalid username or password.");
            }
           
        
               

        }
        private void checkBoxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            // If checkbox is checked, show password; otherwise, hide it
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowpassword.Checked;
        }


    }
}

