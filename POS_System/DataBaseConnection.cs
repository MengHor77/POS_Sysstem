using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace POS_System
{
    internal class DataBaseConnection
    {
        string connectionString = "encrypt=false; server=localhost\\SQLEXPRESS; database=POS_SystemDB; trusted_connection=true";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show(" Database connected successfully!");
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(" SQL Error: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️Error: " + ex.Message);
                return false;
            }
        }


    }
}
