using BookStore.Interfaces;
using BookStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStore.View
{
    /// <summary>
    /// Interaction logic for BookContentEditor.xaml
    /// </summary>
    public partial class BookContentEditor : UserControl, IContentEditor
    {
        private BookInfo BookInfoFromDB { get; set; }
        private BooksRepository WorkingBooksRepository { get; set; }
        private BooksGrid WorkingBooksGrid { get; set; }
        public BookContentEditor()
        {
            InitializeComponent();
        }
        public BookContentEditor(BookInfo initializationBookInfo, BooksRepository booksRepository, BooksGrid booksGrid)
        {
            WorkingBooksGrid = booksGrid;
            WorkingBooksRepository = booksRepository;
            BookInfoFromDB = initializationBookInfo;
            WorkingBooksGrid.MainListView.SelectionChanged += Update;
            UpdateAllTextBoxes(initializationBookInfo);
            
        }
        private void Id_TextChanged(object sender, TextChangedEventArgs e)
        {
            var source = e.OriginalSource.GetType();
        }
        private void Update(object sender, SelectionChangedEventArgs e)
        {
            UpdateAllTextBoxes(WorkingBooksGrid.MainListView.SelectedItem as BookInfo);
        }
        private void UpdateAllTextBoxes(BookInfo updatedInfo)
        {
            Id_TextBox.Text = updatedInfo?.Id.ToString();
            Name_TextBox.Text = updatedInfo?.Name;
            Author_TextBox.Text = updatedInfo?.Author;
            Isbn_TextBox.Text = updatedInfo?.Isbn;
        }
        public bool Add(ObservableObject bookToAdd)
        {
            if (bookToAdd is BookInfo)
            {
                var book = bookToAdd as BookInfo;
                
            }
            else return false;
            throw new NotImplementedException();
        }

        public bool Remove(ObservableObject bookToRemove)
        {
            throw new NotImplementedException();
        }

        public bool Edit(ObservableObject bookToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
