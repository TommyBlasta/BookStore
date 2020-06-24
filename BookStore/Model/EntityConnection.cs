using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using BookStore.Model;
using BookStore.Data;

namespace BookStore
{
    public class EntityConnection
    {
        private DbContextOptionsBuilder<BookstoreContext> OptionsBuilder { get; set; }
        private SqlConnectionStringBuilder SqlConnectionStringBldr { get; set; }
        /// <summary>
        /// Opens conncetion to database
        /// </summary>
        public EntityConnection()
        {
            OptionsBuilder = new DbContextOptionsBuilder<BookstoreContext>();
            SqlConnectionStringBldr = new SqlConnectionStringBuilder
            {
                //TODO move to ini file
                //For TCP/IP connection testing is false, should be true
                IntegratedSecurity = false,
                InitialCatalog = "BookStore",
                DataSource = @"78.102.64.248,1433\SQLTOM",
                UserID = "Mot",
                Password = "mot"
            };
            OptionsBuilder.UseSqlServer(SqlConnectionStringBldr.ConnectionString);
        }
        /// <summary>
        ///Returns the BookstoreContext for the underlying database 
        /// </summary>
        /// <returns>BookstoreContext of the connected dtb</returns>
        public BookstoreContext GetContext()
        {
            return new BookstoreContext(OptionsBuilder.Options);
        }
        /// <summary>
        /// Hard code test for entry INSERT
        /// </summary>
        //public void AddBook()
        //{
        //    try
        //    {
        //        using (var dbContext = new BookstoreContext(OptionsBuilder.Options))
        //        {
        //            dbContext.Books.Add(new Books
        //            {
        //                Name = "HP",
        //                Author = "JKR",
        //                BasePrice = 20.0m,
        //                Published = new System.DateTime(1999, 1, 1),
        //                Isbn = "testISBN",
        //                DateAdded = System.DateTime.Now
        //            });
        //            dbContext.SaveChanges();
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
               
        //}
    }
 
}
