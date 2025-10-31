using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie_egzyminacyjne_2___Ja
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<City> Cities = new ObservableCollection<City>();
        public MainWindow()
        {
            InitializeComponent();

            if (Cities.Count == 0)
            {
                Cities.Add(new City { Name = "Warszawa", Offset = 2 });
            }

            CitiesListBox.ItemsSource = Cities;
            CitiesListBox.SelectedIndex = 0;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddCityWindow { Owner = this };
            if (addWindow.ShowDialog() == true)
            {
                Cities.Add(addWindow.NewCity);
            }
        }

        private void CitiesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}