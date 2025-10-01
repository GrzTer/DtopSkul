//using System;
//using System.Windows;
//using System.Windows.Controls;

//namespace WpfApp1
//{
//    public partial class MainWindow : Window
//    {
//        double lastNumber, result;
//        string selectedOperator;

//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            var button = (Button)sender;

//            if (Numb.Text == "0")
//                Numb.Text = button.Content.ToString();
//            else
//                Numb.Text += button.Content.ToString();
//        }

//        private void Operator_Click(object sender, RoutedEventArgs e)
//        {
//            var button = (Button)sender;
//            selectedOperator = button.Content.ToString();
//            lastNumber = double.Parse(Numb.Text);
//            Numb.Text = "0";
//        }

//        private void Clear_Click(object sender, RoutedEventArgs e)
//        {
//            Numb.Text = "0";
//            lastNumber = 0;
//            result = 0;
//        }

//        private void Equals_Click(object sender, RoutedEventArgs e)
//        {
//            double newNumber;
//            if (double.TryParse(Numb.Text, out newNumber))
//            {
//                switch (selectedOperator)
//                {
//                    case "+":
//                        result = lastNumber + newNumber;
//                        break;
//                    case "-":
//                        result = lastNumber - newNumber;
//                        break;
//                    case "*":
//                        result = lastNumber * newNumber;
//                        break;
//                    case "/":
//                        result = (newNumber != 0) ? lastNumber / newNumber : 0;
//                        break;
//                }
//                Numb.Text = result.ToString();
//            }
//        }
//    }
//}
