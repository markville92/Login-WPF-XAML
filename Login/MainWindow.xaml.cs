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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string user_name;
        public MainWindow()
            
        {
            InitializeComponent();
            
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            user_name = UsernameLogin.Text;
        }

        private void DarkMode_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLbl.Foreground = Brushes.White;
            LoginWindow.Background = Brushes.Black;
            NameLbl.Foreground = Brushes.White;
            PasswordLbl.Foreground = Brushes.White;
            LoginButton.Foreground = Brushes.White;
            LoginButton.Background = Brushes.Black;
            LightMode.Foreground = Brushes.Black;
            LightMode.Background = Brushes.White;
            DarkMode.Background = Brushes.Black;
            DarkMode.Foreground = Brushes.White;
            ExitButton.Foreground = Brushes.White;
            ExitButton.Background = Brushes.Black;
        }

        private void LightMode_Click(object sender, RoutedEventArgs e)
        {
            WelcomeLbl.Foreground = Brushes.Black;
            LoginWindow.Background = Brushes.White;
            NameLbl.Foreground = Brushes.Black;
            PasswordLbl.Foreground = Brushes.Black;
            LoginButton.Foreground = Brushes.Black;
            LoginButton.Background = Brushes.White;
            LightMode.Foreground = Brushes.Black;
            LightMode.Background = Brushes.White;
            DarkMode.Background = Brushes.Black;
            DarkMode.Foreground = Brushes.White;
            ExitButton.Foreground = Brushes.Black;
            ExitButton.Background = Brushes.White;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (UsernameLogin.Text != "" && PasswordBox.Password != "")
            {
                MessageBox.Show($"Congratulations, you're logged in as: " + user_name, "Successfully logged in!");
                WelcomeLbl.Content = $"Welcome " + user_name + "!";
                LoginButton.Visibility = Visibility.Hidden;
                PasswordBox.Visibility = Visibility.Hidden;
                UsernameLogin.Visibility = Visibility.Hidden;
                NameLbl.Content = "";
                PasswordLbl.Content = "";
                ExitButton.Visibility = Visibility.Visible;
            }

            else
            {
                MessageBox.Show("You did not enter a valid username and/or password! Try Again!", "Login failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow.Close();
            MessageBox.Show($"Thanks for using this program, " + user_name + ". Have a Wonderful Day!", "Thank You");
        }
    }
}
