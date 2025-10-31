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
using Zadanie_egzyminacyjne_3___Bartomiej.Images;

namespace Zadanie_egzyminacyjne_3___Bartomiej
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExhibitionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ExhibitionComboBox.SelectedItem is ComboBoxItem selectedItem && selectedItem.Tag is string imageName)
            {
                try
                {
                    string imagePath = $"pack://aplication:,,,/Image/{imageName}";
                    ExhibitionImage.Source = new BitmapImage(new Uri(imagePath));
                }
                catch {
                    ExhibitionImage.Source = new BitmapImage(new Uri("pack://aplication:,,,/Images/logo.png"));
                }
            }
        }

        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {

            if (ExhibitionComboBox.SelectedItem == null)
            {
                MessageBox.Show("Proszę wybrać wystawę!", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            if (!int.TryParse(QuantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Proszę podać poprawną, dodatnią ilość biletów.", "Błąd danych", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            string exhibitionName = (ExhibitionComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            decimal ticketPrice;
            string ticketTypeName;

            if (NormalnyRadio.IsChecked == true)
            {
                ticketPrice = 20.0m;
                ticketTypeName = "Normalny";
            }
            else
            {
                ticketPrice = 15.0m;
                ticketTypeName = "Ulgowy";
            }

            decimal totalPrice = quantity * ticketPrice;
            string ticketInfo = $"{quantity} x {ticketTypeName}";


            PodsumowanieWindo summaryWindow = new PodsumowanieWindo(exhibitionName, ticketInfo, totalPrice);
            summaryWindow.Owner = this;
            summaryWindow.ShowDialog();
        }
    }
}