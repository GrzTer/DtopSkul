using System;
using System.Windows;
using System.Windows.Media;

namespace ZadanieEzyminacyjne_4___San
{
    public partial class WalidatorKodow : Window
    {
        private string wzorcowyKod;
        private string imieNazwisko;
        private string typBiletu;

        public WalidatorKodow(string kod, string imie, string typ)
        {
            InitializeComponent();
            wzorcowyKod = kod;
            imieNazwisko = imie;
            typBiletu = typ;
        }

        private void btnWaliduj_Click(object sender, RoutedEventArgs e)
        {
            if (txtWprowadzonyKod.Text == wzorcowyKod)
            {
                lblWynikWalidacji.Content = "KOD POPRAWNY. Witamy!";
                lblWynikWalidacji.Foreground = Brushes.Green;
                lblDaneUzytkownika.Content = "Użytkownik: " + imieNazwisko + " - Bilet: " + typBiletu;
            }
            else
            {
                lblWynikWalidacji.Content = "BŁĄD. Nieprawidłowy kod!";
                lblWynikWalidacji.Foreground = Brushes.Red;
                lblDaneUzytkownika.Content = "";
            }
        }

        private void btnPowrot_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}