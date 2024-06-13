using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;

namespace DeliveryFood.Views
{
    public partial class RegisterView : UserControl
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            bool checkLogin = false;
            bool checkPass = false;
            bool checkEmail = false;

            if(textboxLogin.Text.Length >= 4)
            {
                labelLogin.Foreground = Brushes.White;
                checkLogin = true;
            }
            else
            {
                labelLogin.Foreground = Brushes.Red;
            }

            if (textboxPass.Text.Length >= 6)
            {
                labelPassword.Foreground = Brushes.White;
                checkPass = true;
            }
            else
            {
                labelPassword.Foreground = Brushes.Red;
            }

            if (!textboxEmail.Text.Length.Equals(0) && Check_Email())
            {
                labelEmail.Foreground = Brushes.White;
                checkEmail = true;
            }
            else
            {
                labelEmail.Foreground = Brushes.Red;
            }

            if (checkUser.IsChecked.Value)
            {
                checkUser.Foreground = Brushes.Black;
            }
            else
            {
                checkUser.Foreground = Brushes.Red;
            }

            if (checkLogin && checkPass && checkEmail && checkUser.IsChecked.Value)
            {
                Register_True();
            }
        }

        private void Register_True()
        {
            DeliveryModel model = new DeliveryModel();
            var modelUser = new User { Login = textboxLogin.Text, Password = textboxPass.Text, Email = textboxEmail.Text, CheckAuth = false };
            model.Users.Add(modelUser);
            model.SaveChanges();
            checkRegister.Content = "Successful registration";
        }

        public bool Check_Email()
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex rex = new Regex(strRegex);
            if (rex.IsMatch(textboxEmail.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}