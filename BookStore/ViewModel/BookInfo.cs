using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.ViewModel
{
    public class BookInfo : ObservableObject
    {
        private int id;
        private string name;
        private string author;
        private string isbn;
        private DateTime? published;
        private DateTime? dateAdded;
        private decimal? basePrice;
        private int? addedBy;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Author
        {
            get => author;
            set
            {
                author = value;
                OnPropertyChanged(nameof(Author));
            }
        }
        public string Isbn
        {
            get => isbn;
            set
            {
                isbn = value;
                OnPropertyChanged(nameof(Isbn));
            }
        }
        public DateTime? Published
        {
            get => published;
            set
            {
                published = value;
                OnPropertyChanged(nameof(Published));
            }
        }
        public DateTime? DateAdded
        {
            get => dateAdded;
            set
            {
                dateAdded = value;
                OnPropertyChanged(nameof(DateAdded));
            }
        }
        public decimal? BasePrice
        {
            get => basePrice;
            set
            {
                basePrice = value;
            }
        }
        public int? AddedBy 
        { 
            get => addedBy;
            set
            {
                addedBy = value;
                OnPropertyChanged(nameof(AddedBy));
            }
            
        }
    }
}
