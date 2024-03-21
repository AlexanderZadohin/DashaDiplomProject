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
    /// Логика взаимодействия для EnterLoginPage.xaml
    /// </summary>
    public partial class EnterLoginPage : Page
    {
        public EnterLoginPage()
        {
            InitializeComponent();


        }

        private void RegistrationBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.Pages.RegistrationPage());
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (EmailTb.Text == "Email")
                mes += "Введите Email\n";
            if (PasswordPb.Password == "0000")
                mes += "Введите пароль\n";
            if (!string.IsNullOrEmpty(mes))
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            else
            {
                #region Проверка входа пользователя
                //UserApp userApp = App.context.UserApp.FirstOrDefault(u =>
                //    u.Password == PassworPb.Password && u.Email == EmailTb.Text);
                //if (userApp != null)
                //{
                //    MainScreenApp mainScreenWindow = new MainScreenApp();
                //    mainScreenWindow.Show();

                //    Window mainWindow = Window.GetWindow(this);
                //    mainWindow.Close();
                //}
                #endregion
                
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
    }
}
