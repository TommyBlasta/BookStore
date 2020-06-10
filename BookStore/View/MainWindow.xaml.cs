using System.Windows;
using System;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using BookStore.Model;

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
    }
}
