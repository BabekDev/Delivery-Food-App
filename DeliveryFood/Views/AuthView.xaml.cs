using System.Windows;
using System.Windows.Controls;

namespace DeliveryFood.Views
{
    public partial class AuthView : UserControl
    {
        private DeliveryModel deliveryModel;
        public AuthView()
        {
            InitializeComponent();
            deliveryModel = new DeliveryModel();
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in deliveryModel.Users)
            {
                if (item.Login.Equals(textboxLogin.Text) && item.Password.Equals(textboxPass.Text))
                {
                    checkAuth.Content = "Successful authorization";
                }
                else
                {
                    checkAuth.Content = "Wrong login or password";
                }
            }
        }

        private void btnPass_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
