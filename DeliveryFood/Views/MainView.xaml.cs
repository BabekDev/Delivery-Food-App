using System.Windows;
using System.Windows.Controls;

namespace DeliveryFood.Views
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;

            switch (index)
            {
                case 0:
                    DataContext = new BurgerView();
                    break;
                case 1:
                    DataContext = new BeerView();
                    break;
                case 2:
                    DataContext = new HMealsView();
                    break;
                case 3:
                    DataContext = new DrinkView();
                    break;
                case 4:
                    DataContext = new DesertView();
                    break;
                case 5:
                    DataContext = new LanchView();
                    break;
                case 6:
                    DataContext = new BasketView();
                    break;
                default:
                    break;
            }
        }
    }
}
