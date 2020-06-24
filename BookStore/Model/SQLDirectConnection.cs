using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows;

namespace BookStore
{
    class SQLDirectConnection
    {
        private SqlConnectionStringBuilder builder { get; set; }
        private SqlConnection connection { get; set; }
        /// <summary>
        /// Opens connection to dtb
        /// </summary>
        public SQLDirectConnection()
        {
            try
            {
                //TODO Simplify this
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"78.102.64.248,1433\SQLTOM";
                builder.IntegratedSecurity = false;
                builder.UserID = "Mot";
                builder.Password = "mot";
                builder.InitialCatalog = "BookStore";
                MessageBox.Show(builder.ConnectionString);
                connection = new SqlConnection();
                connection.ConnectionString = builder.ConnectionString;
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Tests connection to dtb, sends an INSERT to not important table
        /// </summary>
        public void testDtb()
        {
            try
            {
                //TODO simplify this
                SqlCommand command = new SqlCommand();
                command.CommandText = "INSERT INTO test (Name,Age) VALUES (@name,@age);";
                command.Parameters.AddWithValue("@name", "onlineTest");
                command.Parameters.AddWithValue("@age", 15);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
