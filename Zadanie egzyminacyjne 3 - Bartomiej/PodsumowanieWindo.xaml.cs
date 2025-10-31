using System.Windows;
using System.Windows.Shapes;
using System.IO;

namespace Zadanie_egzyminacyjne_3___Bartomiej.Images
{
    /// <summary>
    /// Logika interakcji dla klasy PodsumowanieWindo.xaml
    /// </summary>
    public partial class PodsumowanieWindo : Window
    {
        private readonly string _exhibitionName;
        private readonly string _ticketInfo;
        private readonly decimal _totalPrice;
        public PodsumowanieWindo(string exhibitionName, string ticketInfo, decimal totalPrice)
        {
            InitializeComponent();

            _exhibitionName = exhibitionName;
            _ticketInfo = ticketInfo;
            _totalPrice = totalPrice;

            ExhibitionText.Text = $"Wystawa: {_exhibitionName}";
            TicketsText.Text = $"Bilety:{_ticketInfo}";
            PriceText.Text = $"Łączna cena: {_totalPrice:F2} PLN";
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "paragon.txt");

                string[] lines =
                                    {
                    "----- Paragon -----",
                    $"Wystawa: {_exhibitionName}",
                    $"Bilety: {_ticketInfo}",
                    $"Łączna cena: {_totalPrice:F2} PLN",
                    "-------------------"
                };

                File.WriteAllLines(filePath, lines);

                MessageBox.Show($"Paragon został zapisany na pulpicie jako 'paragon.txt'.", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisywania paragonu: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}
