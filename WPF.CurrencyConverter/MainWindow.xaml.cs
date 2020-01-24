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
using System.Text.RegularExpressions;

namespace WPF.CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
        }
        public void TextBoxNumberInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            double.TryParse(textBoxNumberInput.Text, out double numberInput);

            if(viewModel.FirstSelectedCurrency != null && viewModel.SecondSelectedCurrency != null)
            {
                if(viewModel.FirstSelectedCurrency == viewModel.SecondSelectedCurrency)
                {
                    double result = 1 * numberInput;

                    textBlockCalculationResult.Text = $"{result.ToString("0.##")} {viewModel.SecondSelectedCurrency.CurrencyCode}";
                }
                else
                {
                    if(viewModel.FirstSelectedCurrency.DollarExchangeRate < viewModel.SecondSelectedCurrency.DollarExchangeRate)
                    {
                        double result = (viewModel.FirstSelectedCurrency.DollarExchangeRate / viewModel.SecondSelectedCurrency.DollarExchangeRate) * numberInput;

                        textBlockCalculationResult.Text = $"{result.ToString("0.##")} {viewModel.SecondSelectedCurrency.CurrencyCode}";

                        // 1 USD / 6,78 DKK = 0,147492625 USD
                    }
                    else if(viewModel.FirstSelectedCurrency.DollarExchangeRate > viewModel.SecondSelectedCurrency.DollarExchangeRate)
                    {
                        double result = (viewModel.FirstSelectedCurrency.DollarExchangeRate * viewModel.SecondSelectedCurrency.DollarExchangeRate) * numberInput;

                        textBlockCalculationResult.Text = $"{result.ToString("0.##")} {viewModel.SecondSelectedCurrency.CurrencyCode}";

                        // 1 USD / 6,78 DKK = 0,147492625 USD
                    }
                }
            }
        }

        public void Button_SwapCurrency_Click(object sender, RoutedEventArgs e)
        {
            // Objects for swapping SelectedItem
            Currency firstSelectedCurrency = firstComboBox.SelectedItem as Currency;
            Currency secondSelectedCurrency = secondComboBox.SelectedItem as Currency;

            // Swap SelectedItem
            firstComboBox.SelectedItem = secondSelectedCurrency;
            secondComboBox.SelectedItem = firstSelectedCurrency;
        }

        private void FirstComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Currency selectedCurrency = firstComboBox.SelectedItem as Currency;

            viewModel.FirstSelectedCurrency = selectedCurrency;
        }

        private void SecondComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Currency selectedCurrency = secondComboBox.SelectedItem as Currency;

            viewModel.SecondSelectedCurrency = selectedCurrency;
        }
    }
}
