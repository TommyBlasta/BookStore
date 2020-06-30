using BookStore.Enums;
using BookStore.ErrorHandling;
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

        Enums.ContentTab CurrentContentTab { get; set; }
        BooksRepository BooksRepo { get; set; }
        public UserInfo ActiveUser {get;set;}
        private Dictionary<Type,UserControl> ActiveControls { get; set; }

        public UserMain(UserInfo activeUser)
        {
            try
            {
                //Properties init
                ActiveUser = activeUser;
                ActiveControls = new Dictionary<Type, UserControl>();
                //Data initialization
                //TODO Add All repos
                BooksRepo = new BooksRepository();
                //XAML components init
                InitializeComponent();
                //Creating custom controls
                ActiveControls.Add(typeof(BooksGrid), new BooksGrid(BooksRepo.BooksViewPoint));
                ActiveControls.Add(typeof(BookContentEditor), new BookContentEditor());
                ActiveControls.Add(typeof(BooksContentFilter), new BooksContentFilter(BooksRepo.BooksViewPoint));
                //Set Books tab as active
                CurrentContentTab = Enums.ContentTab.Books;
                //
                DataViewHolder_Grid.Children.Add(ActiveControls.GetValueOrDefault(typeof(BooksGrid)));
                //set books filter as active
                ContentFilter_Grid.Children.Add(ActiveControls.GetValueOrDefault(typeof(BooksContentFilter)));
                //set books editor as active
                ContentEditor_Grid.Children.Add(new BookContentEditor());
            }
            catch(Exception ex)
            {
                ExceptionLogger.Log(ex);
            }
        }
        private void ChangeWindowContext(ContentTab contentTabToChangeTo)
        {
            switch (contentTabToChangeTo)
            {
                case ContentTab.Books:
                    DataViewHolder_Grid.Children.Clear();
                    ContentFilter_Grid.Children.Clear();
                    ContentEditor_Grid.Children.Clear();
                    DataViewHolder_Grid.Children.Add(ActiveControls.GetValueOrDefault(typeof(BooksGrid)));
                    ContentFilter_Grid.Children.Add(ActiveControls.GetValueOrDefault(typeof(BooksContentFilter)));
                    ContentEditor_Grid.Children.Add(new BookContentEditor());
                    break;
                case ContentTab.Items:
                    throw new NotImplementedException();
                    break;
                case ContentTab.Shifts:
                    throw new NotImplementedException();
                    break;
                case ContentTab.Users:
                    throw new NotImplementedException();
                    break;
            }
        }
        private void NavigationToBooks_ButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentContentTab = Enums.ContentTab.Books;
            if (DataViewHolder_Grid.Children.Count > 0)
            {
                DataViewHolder_Grid.Children.Clear();
            }
            DataViewHolder_Grid.Children.Add(new BooksGrid(BooksRepo.BooksViewPoint));
        }
        private void NavigationToItems_ButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentContentTab = Enums.ContentTab.Items;
            if(DataViewHolder_Grid.Children.Count > 0)
            {
                DataViewHolder_Grid.Children.Clear();
            }
            DataViewHolder_Grid.Children.Add(new ItemsGrid());
        }
        private void NavigationToShifts_ButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentContentTab = Enums.ContentTab.Shifts;

        }
        private void NavigationToUsers_ButtonClick(object sender, RoutedEventArgs e)
        {
            CurrentContentTab = Enums.ContentTab.Users;
        }
    }
}
