using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Controls
{
    public partial class MainControlForm : Form
    {
        // Declare UserControls
        private UcDashboard ucDashboard = new UcDashboard();
        private UcSales ucSales = new UcSales();
        private UcProducts ucProducts = new UcProducts();
        private UcCustomers ucCustomers = new UcCustomers();
        private UcReports ucReports = new UcReports();
        private UcSettings ucSettings = new UcSettings();

       

        public MainControlForm()
        {
            InitializeComponent();


            // Dock UserControls to fill panelContent
            ucDashboard.Dock = DockStyle.Fill;
            ucSales.Dock = DockStyle.Fill;
            ucProducts.Dock = DockStyle.Fill;
            ucCustomers.Dock = DockStyle.Fill;
            ucReports.Dock = DockStyle.Fill;
            ucSettings.Dock = DockStyle.Fill;

            // Add all UserControls to panelContent
            panelContent.Controls.Add(ucDashboard);
            panelContent.Controls.Add(ucSales);
            panelContent.Controls.Add(ucProducts);
            panelContent.Controls.Add(ucCustomers);
            panelContent.Controls.Add(ucReports);
            panelContent.Controls.Add(ucSettings);

            // Show only Dashboard at startup
            ShowControl(ucDashboard);

          



        }
        private void labelDashboard_Click(object sender, EventArgs e)
        {

            ShowControl(ucDashboard);
        }

       

        private void ShowControl(UserControl uc)
        {
            // Hide all
            ucDashboard.Visible = false;
            ucSales.Visible = false;
            ucProducts.Visible = false;
            ucCustomers.Visible = false;
            ucReports.Visible = false;
            ucSettings.Visible = false;

            // Show selected
            uc.Visible = true;
            
            
        }
        private void labelLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void labelSales_Click(object sender, EventArgs e)
        {
            ShowControl(ucSales);
            labelSales.BackColor = Color.White;
            labelDashboard.BackColor = Color.Transparent;
            labelProducts.BackColor = Color.Transparent;
            labelCustomers.BackColor = Color.Transparent;
            labelReports.BackColor = Color.Transparent;
            labelSettings.BackColor = Color.Transparent;
        }

        private void labelProducts_Click(object sender, EventArgs e)
        {
            ShowControl(ucProducts);
            labelProducts.BackColor = Color.White;
            labelReports.BackColor = Color.Transparent;
            labelSettings.BackColor = Color.Transparent;
            labelDashboard.BackColor = Color.Transparent;
            labelCustomers.BackColor = Color.Transparent;
            labelSales.BackColor = Color.Transparent;
        }

        private void labelCustomers_Click(object sender, EventArgs e)
        {
            ShowControl(ucCustomers);
            labelCustomers.BackColor = Color.White;
            labelProducts.BackColor = Color.Transparent;
            labelReports.BackColor = Color.Transparent;
            labelSettings.BackColor = Color.Transparent;
            labelDashboard.BackColor = Color.Transparent;
            labelSales.BackColor = Color.Transparent;
        }

        private void labelReports_Click(object sender, EventArgs e)
        {
            ShowControl(ucReports);
            labelReports.BackColor = Color.White;
            labelCustomers.BackColor = Color.Transparent;
            labelProducts.BackColor = Color.Transparent;
            labelSettings.BackColor = Color.Transparent;
            labelDashboard.BackColor = Color.Transparent;
            labelSales.BackColor = Color.Transparent;
        }

        private void labelSettings_Click(object sender, EventArgs e)
        {
            ShowControl(ucSettings);
            labelSettings.BackColor = Color.White;
            labelDashboard.BackColor = Color.Transparent;
            labelProducts.BackColor = Color.Transparent;
            labelCustomers.BackColor = Color.Transparent;
            labelReports.BackColor = Color.Transparent;
            labelSales.BackColor = Color.Transparent;
        }

       
    }
}
