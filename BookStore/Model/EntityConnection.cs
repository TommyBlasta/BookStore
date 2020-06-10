using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BookStore.Model
{
    class EntityConnection
    {
        public DbContextOptionsBuilder<BookstoreContext> optionsBuilder { get; set; }
        public SqlConnectionStringBuilder sqlConnectionStringBldr { get; set; }
    
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
