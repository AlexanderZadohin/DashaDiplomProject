using DashaDiplomProject.Class;
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
using System.Windows.Shapes;

namespace DashaDiplomProject.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainScreenApp.xaml
    /// </summary>
    public partial class MainScreenApp : Window
    {
        public MainScreenApp()
        {
            InitializeComponent();

            ClassFrame.FrameBody = BodyFramePage;
            BodyFramePage.Navigate(new View.Pages.MainPageBody());

        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFramePage.Navigate(new View.Pages.MainPageBody());

            HomeImg.Source = new BitmapImage(new Uri("/Resources/ActiveHomeIcon.png", UriKind.Relative));
            BaggageImg.Source = new BitmapImage(new Uri("/Resources/BaggageIcon.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/ProfileIcon.png", UriKind.Relative));
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFramePage.Navigate(new View.Pages.ProfilePage());

            HomeImg.Source = new BitmapImage(new Uri("/Resources/HomeIcon.png", UriKind.Relative));
            BaggageImg.Source = new BitmapImage(new Uri("/Resources/BaggageIcon.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/ActiveProfileIcon.png", UriKind.Relative));
        }

        private void HistoryBuyBtn_Click(object sender, RoutedEventArgs e)
        {
            BodyFramePage.Navigate(new View.Pages.OrderHistoryPage());

            HomeImg.Source = new BitmapImage(new Uri("/Resources/HomeIcon.png", UriKind.Relative));
            BaggageImg.Source = new BitmapImage(new Uri("/Resources/ActiveBaggageIcpn.png", UriKind.Relative));
            ProfileImg.Source = new BitmapImage(new Uri("/Resources/ProfileIcon.png", UriKind.Relative));
        }
    }
}
