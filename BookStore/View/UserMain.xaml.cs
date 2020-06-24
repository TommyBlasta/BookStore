using BookStore.View;
using BookStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookStore
{
    /// <summary>
    /// Interaction logic for UserMain.xaml
    /// </summary>
    public partial class UserMain : Window
    {
        BooksRepository BooksRepo { get; set; }
        public UserMain(UserInfo activeUser)
        {
            BooksRepo = new BooksRepository();
            InitializeComponent();

        }
        private void NavigationToBooks_ButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataViewHolder_Grid.Children.Count > 0)
            {
                DataViewHolder_Grid.Children.Clear();
            }
            DataViewHolder_Grid.Children.Add(new BooksGrid(BooksRepo.BooksViewPoint));
        }
        private void NavigationToItems_ButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataViewHolder_Grid.Children.Count > 0)
            {
                DataViewHolder_Grid.Children.Clear();
            }
            DataViewHolder_Grid.Children.Add(new ItemsGrid());
        }
        private void NavigationToShifts_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
        private void NavigationToUsers_ButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
