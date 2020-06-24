using BookStore.Converters;
using BookStore.Data;
using BookStore.ErrorHandling;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BookStore.ViewModel
{
    public class BooksRepository
    {
        private EntityConnection ConnectionInfo { get; set; }
        public ObservableCollection<BookInfo> BooksViewPoint { get; set; }
        public BooksRepository()
        {
            try
            {
                ConnectionInfo = new EntityConnection();
                BooksViewPoint = new ObservableCollection<BookInfo>();
                using (var DbContext = ConnectionInfo.GetContext())
                {
                    var converter = new BookConverter();
                    foreach (var Book in DbContext.Books)
                    {
                        BooksViewPoint.Add(converter.ToInfo(Book));
                    }

                }
            }
            catch(Exception ex)
            {
                ExceptionLogger.Log(ex);
            }
        }
        /// <summary>
        /// Inserts Book into the database and the local view.
        /// </summary>
        /// <param name="bookInfo">BookInfo of the book to insert.</param>
        public bool InsertBook(BookInfo bookInfo)
        {
            //if BooksViewPoint has an element with same Id
            if(BooksViewPoint.Where(x => x.Id == bookInfo.Id).Count() > 0)
            {
                return false;
            }
            //if Database contains the Id already
            else if(ConnectionInfo.GetContext().Books.Where(x => x.Id == bookInfo.Id).Count() > 0)
            {
                return false;
            }
            else
            {
                try
                {
                    var converter = new BookConverter();
                    //adds to ViewPoint
                    BooksViewPoint.Add(bookInfo);
                    using (var dbContext = ConnectionInfo.GetContext())
                    {
                        //adds to DB
                        dbContext.Books.Add(converter.ToBook(bookInfo));
                        dbContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    ExceptionLogger.Log(ex);
                }
            }
            return false;
        }
        /// <summary>
        /// Loads Book from the database.
        /// </summary>
        /// <param name="Id">Id of the Book to load.</param>
        /// <returns></returns>
        public BookInfo ReadBook(int Id)
        {
            try
            {
                var converter = new BookConverter();
                return converter.ToInfo(ConnectionInfo.GetContext()
                    .Books.Where(x => x.Id == Id)
                    .Select(x => x)
                    .Single()
                    );
            }
            catch (Exception ex)
            {
                ExceptionLogger.Log(ex);
                return null;
            }
           
        }
        /// <summary>
        /// Tries to update the given Book in database and local view. Uses the updated BookInfo as source of new information to change.
        /// </summary>
        /// <param name="toUpdate">BookInfo to update.</param>
        /// <param name="updated">BookInfo containing the updated information.</param>
        /// <returns>Returns true if successful.</returns>
        public bool UpdateBook(BookInfo toUpdate, BookInfo updated)
        {
            if(toUpdate.Id != updated.Id)
            {
                return false;
            }
            foreach(PropertyInfo propertyInfo in this.GetType().GetProperties())
            {

            }
            return false;
        }
        public void RefreshViewPoint()
        {
            using (var DbContext = ConnectionInfo.GetContext())
            {
                var converter = new BookConverter();
                foreach (var Book in DbContext.Books)
                {
                    if(!BooksViewPoint.Contains(converter.ToInfo(Book)))
                        BooksViewPoint.Add(converter.ToInfo(Book));
                }
            }
            return;
        }
    }
}
