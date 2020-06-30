using System.Windows;
using System;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using BookStore;
using BookStore.ErrorHandling;
using BookStore.Model;
using BookStore.ViewModel;
using BookStore.Converters;

namespace BookStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                //Dtb connection tests

                //Connection connection = new Connection();
                //connection.testDtb();
                //EntityConnection entity = new EntityConnection();
                //entity.AddBook();

                //Exception logger test
                //var toThrow = new Exception("test_message");
                //toThrow.Source = "test_source";
                //ExceptionLogger.Log(toThrow);
                //toThrow.Source = "test_source2";
                //ExceptionLogger.Log(toThrow,false);

                //PassHandler tests
                //PasswordHandler.HashAndSaltPass("test1");

                MainViewModel mainView = new MainViewModel();
                var passHandler = new PasswordHandler();
                var result = passHandler.HashAndSaltPass("abcd");
                var result2 = passHandler.ConfirmPassword("Admin", "abcd", result);
                //var byteConverter = new ByteConverter();
                //var result = byteConverter.ToByteArray("023");
                //var result2 = byteConverter.ToString(result);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //var testing = new BooksRepository();
            //testing.RefreshViewPoint();

            //For testing
            var toOpen = new UserMain(new UserInfo("TestUser", Enums.Privilege.Admin));
            toOpen.Show();
            this.Close();
            //TODO Check user credentials in dtb
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            //passTextBox.SecurePassword()
        }
    }
}
