using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.CurrencyConverter
{
    class Currency
    {
        // Constructor
        public Currency(string currencyCode, string currencyName, double dollarExchangeRate)
        {
            CurrencyCode = currencyCode;
            CurrencyName = currencyName;
            DollarExchangeRate = dollarExchangeRate;
        }   

        // Properties
        //
        // Using auto-implementation because Visual Studio likes it :D!
        //
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public double DollarExchangeRate { get; set; }

        public override string ToString()
        {
            return CurrencyName;
        }
    }
}
