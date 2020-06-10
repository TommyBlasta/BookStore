using System.Windows;
using System;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using BookStore;

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
                Connection connection = new Connection();
                connection.testDtb();
                EntityConnection entity = new EntityConnection();
                entity.AddBook();
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
