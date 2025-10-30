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
    public partial class UcDashboard : UserControl
    {
        public UcDashboard()
        {
            InitializeComponent();
            AddLabels();


        }


        private void AddLabels()
        {
            // Label 1
            Label lblTotalSales = new Label();
            lblTotalSales.Text = "Total Sales: $1250";
            lblTotalSales.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            lblTotalSales.Location = new Point(50, 50); // X, Y position
            lblTotalSales.AutoSize = true;

            // Label 2
            Label lblTotalCustomers = new Label();
            lblTotalCustomers.Text = "Total Customers: 120";
            lblTotalCustomers.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            lblTotalCustomers.Location = new Point(50, 90);
            lblTotalCustomers.AutoSize = true;

            // Add labels to UserControl
            this.Controls.Add(lblTotalSales);
            this.Controls.Add(lblTotalCustomers);
        }


    }
}
