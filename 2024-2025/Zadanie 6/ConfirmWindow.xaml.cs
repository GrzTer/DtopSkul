using System.Windows;

namespace Zadanie_6
{
    public partial class ConfirmWindow : Window
    {
        public ConfirmWindow(string name, string surname, int year, int month, int day, string email)
        {
            InitializeComponent();
            NameLabel.Content = name;
            SurnameLabel.Content = surname;
            YearLabel.Content = year.ToString();
            MonthLabel.Content = month.ToString();
            DayLabel.Content = day.ToString();
            EmailLabel.Content = email;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Formularz został poprawnie uzupełniony.");
            Application.Current.Shutdown();
        }
    }
}
