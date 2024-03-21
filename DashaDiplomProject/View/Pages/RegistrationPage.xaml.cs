using DashaDiplomProject.Class;
using DashaDiplomProject.View.Windows;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.EnterLoginPage());
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (EmailTb.Text == "Email")
                mes += "Введите Email\n";
            if (NameTb.Text == "Имя")
                mes += "Введите Имя\n";
            if (PasswordPb.Password == "0000")
                mes += "Введите пароль\n";
            if(!string.IsNullOrEmpty(mes))
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else
            {
                MainScreenApp mainScreenWindow = new MainScreenApp();
                mainScreenWindow.Show();

                Window mainWindow = Window.GetWindow(this);
                mainWindow.Close();
            }
        }

        private void PasswordPb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPb.Password == "")
            {
                PasswordPb.Password = "0000";
            }

        }

        private void PasswordPb_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordPb.Password = "";
        }

        private void EmailTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTb.Text == "")
            {
                EmailTb.Text = "Email";
            }
        }

        private void EmailTb_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTb.Text = string.Empty;
        }

        private void NameTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text == "")
            {
                NameTb.Text = "Имя";
            }
        }

        private void NameTb_GotFocus(object sender, RoutedEventArgs e)
        {
            NameTb.Text = string.Empty;
        }
    }
}
