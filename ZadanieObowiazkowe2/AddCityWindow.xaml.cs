using System.Windows;

namespace ZadanieObowiazkowe2
{
    public partial class AddCityWindow : Window
    {
        public City NewCity { get; private set; }

        public AddCityWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || !int.TryParse(OffsetTextBox.Text, out int offset))
            {
                MessageBox.Show("Wprowadź poprawne dane!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            NewCity = new City { Name = NameTextBox.Text, Offset = offset };
            this.DialogResult = true;
        }
    }
}