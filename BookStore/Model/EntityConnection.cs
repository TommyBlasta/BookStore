using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BookStore
{
    class EntityConnection
    {
        private DbContextOptionsBuilder<BookstoreContext> optionsBuilder { get; set; }
        private SqlConnectionStringBuilder sqlConnectionStringBldr { get; set; }
        /// <summary>
        /// Opens conncetion to database and maps entity objects
        /// </summary>
        public EntityConnection()
        {
            optionsBuilder = new DbContextOptionsBuilder<BookstoreContext>();
            sqlConnectionStringBldr = new SqlConnectionStringBuilder();
            sqlConnectionStringBldr.IntegratedSecurity = false;
            sqlConnectionStringBldr.InitialCatalog = "BookStore";
            sqlConnectionStringBldr.DataSource = @"78.102.64.248,1433\SQLTOM";
            sqlConnectionStringBldr.UserID = "Mot";
            sqlConnectionStringBldr.Password = "mot";
            optionsBuilder.UseSqlServer(sqlConnectionStringBldr.ConnectionString);
        }
        /// <summary>
        /// Hard code test
        /// </summary>
        public void AddBook()
        {
            try
            {
                using (var dbContext = new BookstoreContext(optionsBuilder.Options))
                {
                    dbContext.Books.Add(new Books
                    {
                        Name = "HP",
                        Author = "JKR",
                        BasePrice = 20.0m,
                        Published = new System.DateTime(1999, 1, 1),
                        Isbn = "testISBN",
                        DateAdded = System.DateTime.Now
                    });
                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
               
        }
    }
 
}
