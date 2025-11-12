using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ZadanieEzyminacyjne_4___San;

namespace ZadanieEzyminacyjne_4___San
{
    public partial class MainWindow : Window
    {
        private string kodDostepu;
        private string imieNazwisko;
        private string typBiletu;

        public MainWindow()
        {
            InitializeComponent();
            AktualizujCene();
            ZmianaTypuBiletu();
            lblKodDostepu.Content = "BRAK";
        }

        private void AktualizujCene()
        {
            int cena = cmbTypBiletu.SelectedItem is ComboBoxItem item && item.Content.ToString() == "Standardowy" ? 50 : 150;
            if (chkLunch.IsChecked == true) cena += 30;
            lblCena.Content = $"{cena}.00 zł";
        }

        private void ZmianaTypuBiletu()
        {
            try
            {
                string typ = (cmbTypBiletu.SelectedItem as ComboBoxItem)?.Content.ToString();
                if (typ == "Standardowy")
                {
                    imgTypBiletu.Source = new BitmapImage(new Uri("standard.png", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    imgTypBiletu.Source = new BitmapImage(new Uri("vip.png", UriKind.RelativeOrAbsolute));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd ładowania obrazu: " + ex.Message);
            }
        }

        private void cmbTypBiletu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AktualizujCene();
            ZmianaTypuBiletu();
        }

        private void chkLunch_CheckedChanged(object sender, RoutedEventArgs e)
        {
            AktualizujCene();
        }

        private void btnGenerujBilet_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImieNazwisko.Text))
            {
                MessageBox.Show("Wprowadź imię i nazwisko!");
                return;
            }

            imieNazwisko = txtImieNazwisko.Text;
            typBiletu = (cmbTypBiletu.SelectedItem as ComboBoxItem)?.Content.ToString();
            kodDostepu = GenerujKod();
            lblKodDostepu.Content = kodDostepu;
            MessageBox.Show("Wygenerowano kod dostępu: " + kodDostepu);
            ZapiszDoPliku();
        }

        private string GenerujKod()
        {
            Random rand = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] kod = new char[6];
            for (int i = 0; i < 6; i++)
            {
                kod[i] = chars[rand.Next(chars.Length)];
            }
            return new string(kod);
        }

        private void ZapiszDoPliku()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pliki tekstowe (*.txt)|*.txt";
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    sw.WriteLine("--- KARTA WSTĘPU ---");
                    sw.WriteLine("Uczestnik: " + imieNazwisko);
                    sw.WriteLine("Typ biletu: " + typBiletu);
                    sw.WriteLine("Opcja Lunch: " + (chkLunch.IsChecked == true ? "Tak" : "Nie"));
                    sw.WriteLine("Cena końcowa: " + lblCena.Content.ToString().Replace(".00 zł", " zł"));
                    sw.WriteLine("KOD DOSTĘPU: " + kodDostepu);
                }
            }
        }

        private void btnPrzejdzDoWalidacji_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imieNazwisko))
            {
                MessageBox.Show("Brak imienia i nazwiska!");
                return;
            }
            if (string.IsNullOrEmpty(kodDostepu))
            {
                MessageBox.Show("Nie wygenerowano biletu!");
                return;
            }
            //WalidatorKodow window2 = new WalidatorKodow(kodDostepu, imieNazwisko, typBiletu);
            //window2.Show();
        }
    }
}