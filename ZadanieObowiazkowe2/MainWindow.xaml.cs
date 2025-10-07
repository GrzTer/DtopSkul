using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace ZadanieObowiazkowe2
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<City> Cities = new ObservableCollection<City>();
        private const string FilePath = "miasta.json";

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(FilePath))
            {
                try
                {
                    string json = File.ReadAllText(FilePath);
                    Cities = JsonSerializer.Deserialize<ObservableCollection<City>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się wczytać pliku miast: " + ex.Message);
                }
            }

            if (Cities.Count == 0)
            {
                Cities.Add(new City { Name = "Warszawa", Offset = 2 });
            }

            CitiesListBox.ItemsSource = Cities;
            CitiesListBox.SelectedIndex = 0;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            Timer_Tick(null, null);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CitiesListBox.SelectedItem is not City selectedCity) return;

            DateTime cityTime = DateTime.UtcNow.AddHours(selectedCity.Offset);

            HourHand.RenderTransform = new RotateTransform(cityTime.Hour % 12 * 30 + cityTime.Minute * 0.5);
            MinuteHand.RenderTransform = new RotateTransform(cityTime.Minute * 6 + cityTime.Second * 0.1);
            SecondHand.RenderTransform = new RotateTransform(cityTime.Second * 6);
        }

        private void CitiesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Timer_Tick(null, null);
        }

        private void AddCity_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddCityWindow { Owner = this };
            if (addWindow.ShowDialog() == true)
            {
                Cities.Add(addWindow.NewCity);
                SaveCities();
            }
        }

        private void DeleteCity_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button)?.DataContext is City cityToRemove)
            {
                Cities.Remove(cityToRemove);
                SaveCities();
            }
        }

        private void SaveCities()
        {
            try
            {
                string json = JsonSerializer.Serialize(Cities);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać pliku miast: " + ex.Message);
            }
        }
    }
}