using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows;

namespace BookStore
{
    class Connection
    {
        public SqlConnectionStringBuilder builder { get; set; }
        public SqlConnection connection { get; set; }
        public Connection()
        {
            try
            {


                builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"78.102.64.248,1433\SQLTOM";
                builder.IntegratedSecurity = false;
                builder.UserID = "Mot";
                builder.Password = "mot";
                builder.InitialCatalog = "BookStore";
                connection = new SqlConnection();
                connection.ConnectionString = builder.ConnectionString;
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void testDtb()
        {
            try
            {
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
