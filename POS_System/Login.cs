using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Login : Form
    {
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
           

          
               
                if (username == "admin" && pass == "123")
                {
                txtName = "Admin";
                MessageBox.Show("Lgoin " + txtName + "Success!");
                // Create Dashboard Form
                POS_System.Controls.MainControlForm dashboard = new POS_System.Controls.MainControlForm();

                    dashboard.Show();
                    this.Hide();
                }
                else if(username == "staff" && pass == "123")

                {
                txtName = "Staff";
                MessageBox.Show("Lgoin " + txtName + "Success!");
                    // Create Dashboard Form
                    POS_System.Staff st = new POS_System.Staff();
                    st.Show();
                    this.Hide();
                }
                else
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

