using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using BookStore.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ViewModel
{
    class MainViewModel
    {
        private DbContextOptionsBuilder<BookstoreContext> OptionsBuilder { get; set; }
        private SqlConnectionStringBuilder SqlConnectionStringBldr { get; set; }
        private BookstoreContext BookstoreContext { get; set; }
        public ObservableCollection<Users> GetUsers { get;private set; }
        public ObservableCollection<Books> GetBooks { get; private set; }
        public ObservableCollection<Shifts> GetShifts { get; private set; }
        /// <summary>
        /// Opens conncetion to database
        /// </summary>
        public MainViewModel()
        {
            OptionsBuilder = new DbContextOptionsBuilder<BookstoreContext>();
            SqlConnectionStringBldr = new SqlConnectionStringBuilder();
            SqlConnectionStringBldr.IntegratedSecurity = false;
            //TODO: Load this from options
            //Move this to Model?
            SqlConnectionStringBldr.InitialCatalog = "BookStore";
            SqlConnectionStringBldr.DataSource = @"78.102.64.248,1433\SQLTOM";
            SqlConnectionStringBldr.UserID = "Mot";
            SqlConnectionStringBldr.Password = "mot";
            OptionsBuilder.UseSqlServer(SqlConnectionStringBldr.ConnectionString);
            BookstoreContext = new BookstoreContext(OptionsBuilder.Options);
            GetUsers = new ObservableCollection<Users>();
            GetBooks = new ObservableCollection<Books>();
            GetShifts = new ObservableCollection<Shifts>();
            LoadAllCollections();

        }
        ~MainViewModel()
        {
            BookstoreContext.Dispose();
        }
        private void LoadAllCollections()
        {
            RefreshCollection<Users>(GetUsers);
            RefreshCollection<Books>(GetBooks);
            RefreshCollection<Shifts>(GetShifts);
        }
        private void RefreshCollection<T>(ObservableCollection<T> toRefresh)
        {
            string typeOfCollection = typeof(T).Name;
            switch (typeOfCollection)
            {
                case "Users":
                    foreach(Users user in BookstoreContext.Users)
                    {
                        if(!GetUsers.Contains(user))
                        {
                            GetUsers.Add(user);
                        }
                    }
                    break;
                case "Books":
                    foreach(Books book in BookstoreContext.Books)
                    {
                        if (!GetBooks.Contains(book))
                        {
                            GetBooks.Add(book);
                        } 
                    }
                    break;
                case "Shifts":
                    foreach(Shifts shift in BookstoreContext.Shifts)
                    {
                        if(!GetShifts.Contains(shift))
                        {
                            GetShifts.Add(shift);
                        }
                    }
                    break;
            }
        }
    }
}
