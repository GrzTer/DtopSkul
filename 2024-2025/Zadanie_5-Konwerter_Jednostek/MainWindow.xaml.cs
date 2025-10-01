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

namespace Zadanie_5_Konwerter_Jednostek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBoxIn.Items.Add("Celsius");
            ComboBoxIn.Items.Add("Fahrenheit");
            ComboBoxIn.Items.Add("Meters");
            ComboBoxIn.Items.Add("Inches");

            ComboBoxOut.Items.Add("Celsius");
            ComboBoxOut.Items.Add("Fahrenheit");
            ComboBoxOut.Items.Add("Meters");
            ComboBoxOut.Items.Add("Inches");

            ComboBoxIn.SelectedIndex = 0;
            ComboBoxOut.SelectedIndex = 1;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            double inValue;
            bool isValid = Double.TryParse(TextBoxIn.Text, out inValue);
            if (!isValid)
            {
                MessageBox.Show("Podaj poprawną wartośc");
                return;
            }
            string inBox = ComboBoxIn.SelectedItem.ToString();
            string outBox = ComboBoxOut.SelectedItem.ToString();
            double reslt = 0;
            if ((inBox == "Celsius" && outBox == "Fahrenheit") || (inBox == "Fahrenheit" && outBox == "Celsius"))
            {
                if (inBox == "Celsius")
                {
                    reslt = (inValue * 9 / 5) + 32;
                }
                else if (inBox == "Fahrenheit")
                {
                    reslt = (inValue - 32) * 5 / 9;
                }
            }
            else if ((inBox == "Meters" && outBox == "Inches") || (inBox == "Inches" && outBox == "Meters"))
            {
                if (inBox == "Meters")
                {
                    reslt = inValue * 39.3701;
                }
                if (inBox == "Inches")
                {
                    reslt = inValue / 39.3701;
                }
            }
            TextBoxOut.Text = reslt.ToString();
        }
    }
}