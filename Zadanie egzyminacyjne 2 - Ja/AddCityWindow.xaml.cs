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
using System.Windows.Shapes;

namespace Zadanie_egzyminacyjne_2___Ja
{
    /// <summary>
    /// Logika interakcji dla klasy AddCityWindow.xaml
    /// </summary>
    public partial class AddCityWindow : Window
    {
        public City NewCity { get; set; }
        public AddCityWindow()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(NameTextBox.Text) || !int.TryParse(OffsetTextBox.Text, out int offset))
            {
                MessageBox.Show("Wprowadź poprawne dane", "Bład", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            NewCity = new City { Name = NameTextBox.Text, Offset = offset };
            this.DialogResult = true;
        }
    }
}
