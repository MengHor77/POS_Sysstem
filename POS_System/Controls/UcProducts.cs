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

namespace POS_System.Controls
{
    public partial class UcProducts : UserControl
    {
        DataBaseConnection db = new DataBaseConnection();
        public UcProducts()
        {
            InitializeComponent();
            this.Load += UcProduct_Load;
        }

        private void UcProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dataGridViewProduct.Rows.Clear();
            SqlConnection connection = db.GetConnection();
            connection.Open();
            string selectQuery = "SELECT product_id, product_name, category_id, price, stock FROM [Products]";
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    dataGridViewProduct.Rows.Add(reader["product_id"].ToString(),
                        reader["product_name"].ToString(),
                        reader["category_id"].ToString(),
                        reader["stock"].ToString(),
                        reader["price"]);
                }
            }
            else
            {
                MessageBox.Show("Product doesn't have in Stock");
            }
        }

        
    }
}
