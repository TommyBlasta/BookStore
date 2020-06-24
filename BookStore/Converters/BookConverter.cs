using BookStore.Data;
using BookStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace BookStore.Converters
{
    class BookConverter
    {
        public BookInfo ToInfo(Books book)
        {
            return new BookInfo()
            {
                Id = book.Id,
                AddedBy = book.AddedBy,
                Author = book.Author,
                Name = book.Name,
                Isbn = book.Isbn,
                Published = book.Published,
                DateAdded = book.DateAdded,
                BasePrice = book.BasePrice
            };
        }
        public Books ToBook(BookInfo bookInfo)
        {
            return new Books()
            {
                Id = bookInfo.Id,
                AddedBy = bookInfo.AddedBy,
                Author = bookInfo.Author,
                Name = bookInfo.Name,
                Isbn = bookInfo.Isbn,
                Published = bookInfo.Published,
                DateAdded = bookInfo.DateAdded,
                BasePrice = bookInfo.BasePrice
            };
        }
    }
}
