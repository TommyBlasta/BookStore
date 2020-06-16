using System.Windows;
using System;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using BookStore;
using BookStore.ErrorHandling;
using BookStore.Model;
using BookStore.ViewModel;

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
                MessageBox.Show(mainView.GetUsers.ToString());
                
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            //passTextBox.SecurePassword()
        }
    }
}
