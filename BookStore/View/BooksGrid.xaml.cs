using BookStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for BooksGrid.xaml
    /// </summary>
    public partial class BooksGrid : UserControl
    {
        ObservableCollection<BookInfo> BooksRepository { get; set; }
        public BooksGrid(ObservableCollection<BookInfo> booksRepository)
        {
            BooksRepository = booksRepository;
            InitializeComponent();
            MainListView.ItemsSource = BooksRepository;

        }
    }
}
