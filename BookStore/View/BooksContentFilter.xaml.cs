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
    /// Interaction logic for BooksContentFilter.xaml
    /// </summary>
    public partial class BooksContentFilter : UserControl
    {
        ObservableCollection<BookInfo> BooksListView { get; set; }
        public BooksContentFilter(ObservableCollection<BookInfo> listView)
        {
            BooksListView = listView;
            InitializeComponent();
        }
    }
}
