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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string operation = "";
        long firstNumber;
        long secondNumber;

        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * Button Function Methods
         */

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10);

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10);

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 1;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 1;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 2;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 2;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 3;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 3;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 4;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 4;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 5;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 5;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 6;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 6;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 7;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 7;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 8;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 8;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber * 10) + 9;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber * 10) + 9;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        /*
         * Maths Button Function Methods
         */

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonDevide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonModulo_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    textBoxDisplayResult.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBoxDisplayResult.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    textBoxDisplayResult.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    textBoxDisplayResult.Text = (firstNumber / secondNumber).ToString();
                    break;
                case "%":
                    textBoxDisplayResult.Text = (firstNumber % secondNumber).ToString();
                    break;
            }
        }

        private void ButtonClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = 0;

            }
            else
            {
                secondNumber = 0;
            }
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
            textBoxDisplayResult.Text = "0";
        }

        private void ButtonBackspace_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber = (firstNumber / 10);

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber = (secondNumber / 10);

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }

        private void buttonPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                firstNumber *= -1;

                textBoxDisplayResult.Text = firstNumber.ToString();
            }
            else
            {
                secondNumber *= -1;

                textBoxDisplayResult.Text = secondNumber.ToString();
            }
        }
    }
}