global using AppHealth.Pages;
using AppHealth.Peges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace AppHealth
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClickOpenPage(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(btnOpenProfile))
                MainFrame.NavigationService.Navigate(new ProfilePage());

            if (sender.Equals(btnOpenStatistics))
                MainFrame.NavigationService.Navigate(new StatisticsPage());

            //if (sender.Equals(btnOpenPhisicalSpatistics))
            //    MainFrame.NavigationService.Navigate();

            if (sender.Equals(btnOpenFoodStatistics))
                MainFrame.NavigationService.Navigate(new FoodPage());

        }
    }
}
