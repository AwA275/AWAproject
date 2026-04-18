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
using AWAproject.Pages;
using AWAproject.DB_connect;

namespace AWAproject.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ListPage()
        {
            //вывод списка
            InitializeComponent();
            Listlw.ItemsSource = DB_connect.ConnectionClass.db.Materials.ToList();
        }

        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());

        }

        private void Btn_redact_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RedactPage());
        }

        private void Cmb_Sort_Money_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
