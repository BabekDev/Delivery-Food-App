using DeliveryFood.ViewModels;
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

namespace DeliveryFood
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AuthViewModel();
            DeliveryModel model = new DeliveryModel();
            btnAuth.Foreground = Brushes.White;
            btnReg.Foreground = Brushes.Gray;

            contentControl2.Visibility = Visibility.Hidden;
            contentControl2.IsEnabled = false;
        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AuthViewModel();
            btnAuth.Foreground = Brushes.White;
            btnReg.Foreground = Brushes.Gray;
        }

        private void btnReg_Click_1(object sender, RoutedEventArgs e)
        {
            DataContext = new RegisterViewModel();
            btnReg.Foreground = Brushes.White;
            btnAuth.Foreground = Brushes.Gray;
        }

        private void Auth_True()
        {
            btnAuth.IsEnabled = false;
            btnAuth.Visibility = Visibility.Hidden;
            btnReg.IsEnabled = false;
            btnReg.Visibility = Visibility.Hidden;

            contentControl.IsEnabled = false;
            contentControl.Visibility = Visibility.Hidden;

            contentControl2.Visibility = Visibility.Visible;
            contentControl2.IsEnabled = true;

            DataContext = new MainViewModel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btnAuth.IsEnabled = false;
            btnAuth.Visibility = Visibility.Hidden;
            btnReg.IsEnabled = false;
            btnReg.Visibility = Visibility.Hidden;

            contentControl.IsEnabled = false;
            contentControl.Visibility = Visibility.Hidden;

            contentControl2.Visibility = Visibility.Visible;
            contentControl2.IsEnabled = true;

            DataContext = new MainViewModel();
        }
    }
}
