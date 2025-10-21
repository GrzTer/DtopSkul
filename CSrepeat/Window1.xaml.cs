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

namespace CSrepeat
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string imie, string nazwisko, string klasa, double srednia)
        {
            InitializeComponent();
            Imie.Content = imie;
            Nazwisko.Content = nazwisko;
            Klasa.Content = klasa;
            Srednia.Content = srednia;
        }
    }
}
