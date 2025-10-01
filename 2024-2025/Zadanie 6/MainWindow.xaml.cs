using System.Text.RegularExpressions;
using System.Windows;

namespace Zadanie_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            string name = Name_tb.Text;
            string surname = Surname_tb.Text;
            string yearText = Year_tb.Text;
            string monthText = Month_tb.Text;
            string dayText = Day_tb.Text;
            string email = Email_tb.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(yearText) || string.IsNullOrWhiteSpace(monthText) ||
                string.IsNullOrWhiteSpace(dayText) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Wszystkie pola muszą być wypełnione.");
                return;
            }

            if (!int.TryParse(yearText, out int year) || !int.TryParse(monthText, out int month) || !int.TryParse(dayText, out int day))
            {
                MessageBox.Show("Podaj poprawne dane w roku, miesiącu lub dniu urodzenia.");
                return;
            }

            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;

            if (age < 20 || (age == 20 && DateTime.Now.Month < month) || (age == 20 && DateTime.Now.Month == month && DateTime.Now.Day < day))
            {
                MessageBox.Show("Musisz mieć ukończone 20 lat.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Podaj poprawny adres e-mail.");
                return;
            }

            var confirmationWindow = new ConfirmWindow(name, surname, year, month, day, email);
            confirmationWindow.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            return emailRegex.IsMatch(email);
        }
    }
}
