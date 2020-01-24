using System;
using System.Collections.Generic;
using System.Text;

namespace WPF.CurrencyConverter
{
    class Repository
    {
        private List<Currency> currencies;

        public Repository()
        {
            currencies = new List<Currency>()
            {
                new Currency("USD", "Amerikanske dollar", 1.000000),
                new Currency("DKK", "Danske kroner", 0.147556),
                new Currency("GBP", "Britiske pund", 1.307648),
                new Currency("EUR", "Euro", 1.102683),
                new Currency("CAD", "Canadiske dollar", 0.760784),
                new Currency("JPY", "Japansk yen", 0.009150),
                new Currency("CHF", "Schweizerfranc", 1.029519),
                new Currency("AUD", "Australske dollar", 0.682304),
                new Currency("INR", "Indisk rupee", 0.014022),
                new Currency("SGD", "Singaporeansk dollar", 0.740036)
            };
        }

        public List<Currency> GetAll()
        {
            return currencies;
        }

        public void Add(Currency currency)
        {
            currencies.Add(currency);
        }
    }
}
