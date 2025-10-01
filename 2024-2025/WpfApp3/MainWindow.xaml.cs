using System;
using System.IO;
using System.Windows;

namespace TextChangerApp
{
    public partial class MainWindow : Window
    {
        private const string INPUT_FILE_NAME = "Lorem.txt";
        private const string OUTPUT_FILE_NAME = "Output.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, INPUT_FILE_NAME);
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    InputTextBox.Text = fileContent;
                }
                else
                {
                    MessageBox.Show($"Plik {INPUT_FILE_NAME} nie został znaleziony.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas otwierania pliku: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, OUTPUT_FILE_NAME);
                File.WriteAllText(filePath, OutputTextBox.Text);
                MessageBox.Show($"Plik został zapisany jako {OUTPUT_FILE_NAME}", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zapisywania pliku: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReplaceText(object sender, RoutedEventArgs e)
        {
            try
            {
                string inputText = InputTextBox.Text;
                string searchText = SearchTextBox.Text;
                string replaceText = ReplaceTextBox.Text;

                string outputText = inputText;
                if (!string.IsNullOrEmpty(searchText))
                {
                    outputText = inputText.Replace(searchText, replaceText);
                }
                
                OutputTextBox.Text = outputText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd podczas zamiany tekstu: {ex.Message}", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
