using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        double lastNumber, result;
        string selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("1");
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("2");
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("3");
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("4");
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("5");
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("6");
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("7");
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("8");
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("9");
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick("0");
        }

        private void NumberButtonClick(string number)
        {
            if (Numb.Text == "0")
            {
                Numb.Text = number;
            }
            else
            {
                Numb.Text += number;
            }
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            OperatorButtonClick("+");
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            OperatorButtonClick("-");
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            OperatorButtonClick("*");
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            OperatorButtonClick("/");
        }

        private void OperatorButtonClick(string operatorSymbol)
        {
            if (double.TryParse(Numb.Text, out lastNumber))
            {
                selectedOperator = operatorSymbol;
                Numb.Text = "0";
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Numb.Text = "0";
            lastNumber = 0;
            result = 0;
            selectedOperator = string.Empty;
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;

            if (double.TryParse(Numb.Text, out newNumber))
            {
                switch (selectedOperator)
                {
                    case "+":
                        result = lastNumber + newNumber;
                        break;
                    case "-":
                        result = lastNumber - newNumber;
                        break;
                    case "*":
                        result = lastNumber * newNumber;
                        break;
                    case "/":
                        if (newNumber != 0)
                        {
                            result = lastNumber / newNumber;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                            result = 0;
                        }
                        break;
                    default:
                        MessageBox.Show("Please select an operator.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break;
                }

                Numb.Text = result.ToString();
                selectedOperator = string.Empty;
            }
            else
            {
                MessageBox.Show("Invalid input!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
