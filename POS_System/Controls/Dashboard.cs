using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace POS_System.Controls
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            // Flatten panels: add each directly to the main cell (1,1)
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelDashboard, 1, 1);
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelSale, 1, 1);
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelProduct, 1, 1);
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelCustomer, 1, 1);
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelReport, 1, 1);
            this.tableLayoutPanelmainform.Controls.Add(this.tableLayoutPanelSetting, 1, 1);

            // Show only Dashboard at startup
            ShowPanel(tableLayoutPanelDashboard);

     
        }

        // Helper method to show only one panel
        private void ShowPanel(TableLayoutPanel panel)
        {
            tableLayoutPanelDashboard.Visible = false;
            tableLayoutPanelSale.Visible = false;
            tableLayoutPanelProduct.Visible = false;
            tableLayoutPanelCustomer.Visible = false;
            tableLayoutPanelReport.Visible = false;
            tableLayoutPanelSetting.Visible = false;

            panel.Visible = true;
        }

        private void labelDasboard_Click(object sender, EventArgs e)
        {
           

            ShowPanel(tableLayoutPanelDashboard);
        }

        private void labelSale_Click(object sender, EventArgs e)
        {
            ShowPanel(tableLayoutPanelSale);
        }

        private void labelProduct_Click(object sender, EventArgs e)
        {
            ShowPanel(tableLayoutPanelProduct);
        }

        private void labelCustomer_Click(object sender, EventArgs e)
        {
            ShowPanel(tableLayoutPanelCustomer);
        }

        private void labelReport_Click(object sender, EventArgs e)
        {
            ShowPanel(tableLayoutPanelReport);
        }

        private void labelSetting_Click(object sender, EventArgs e)
        {
            ShowPanel(tableLayoutPanelSetting);
        }
        private void labelLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
