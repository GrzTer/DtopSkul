using System.Diagnostics;
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

namespace CSrepeat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> lista_ocen = new List<double>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Dodaj(object sender, RoutedEventArgs e)
        {
            double suma=0;
            lista_ocen.Add((double.Parse(sredniaBox.Text)));
            foreach (var item in lista_ocen)
            {
                suma += item;
            }
            //for (int i =0; i < lista_ocen.Count; i++)
            //{
            //    suma += lista_ocen[i];
            //}

            sredniaLabel.Content = suma / lista_ocen.Count;
            MessageBox.Show(sredniaLabel.Content.ToString(), "Alert", MessageBoxButton.YesNoCancel, MessageBoxImage.Exclamation);
        }

        private void Przeslij_Click(object sender, RoutedEventArgs e)
        {
            Window1 okno = new Window1(imieBox.Text, nazwiskoBox.Text, klasaBox.Text, double.Parse(sredniaLabel.Content.ToString()));
            okno.Show();
            this.Close();
        }
    }
}