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

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainPge.xaml
    /// </summary>
    public partial class MainPge : Page
    {
        public MainPge()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // gost page = new gost();
            NavigationService.Navigate(new gost());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Create window = new Create();
            window.Show();
            gost page = new gost();
            NavigationService.Navigate(page);
        }
    }
}
