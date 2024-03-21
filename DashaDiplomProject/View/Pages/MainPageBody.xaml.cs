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

namespace DashaDiplomProject.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageBody.xaml
    /// </summary>
    public partial class MainPageBody : Page
    {
        public MainPageBody()
        {
            InitializeComponent();
        }

        private void ChooseHolidayLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new View.Pages.TravelCityPage());
        }
    }
}
