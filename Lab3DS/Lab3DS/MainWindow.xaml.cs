using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab3DS.bibliotekaDataSetTableAdapters;

namespace Lab3DS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksTableAdapter books = new BooksTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            BooksGrd.ItemsSource = books.GetDataBy();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BooksGrd.Columns[0].Visibility = Visibility.Collapsed;
            BooksGrd.Columns[2].Visibility = Visibility.Collapsed;
            BooksGrd.Columns[3].Visibility = Visibility.Collapsed;
            BooksGrd.Columns[4].Visibility = Visibility.Collapsed;
        }
    }
}
