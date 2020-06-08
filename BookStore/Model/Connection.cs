using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace BookStore
{
    class Connection
    {
        public SqlConnectionStringBuilder builder { get; set; }
        public Connection()
        {
            builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = @"192.168.0.105,1433\SQLTOM";
            builder.IntegratedSecurity = false;
            builder.UserID = "ruf";
            builder.Password = "ruf";
            
        }
    }
}
