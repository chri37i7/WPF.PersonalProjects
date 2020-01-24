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
                new Currency("USD", "Amerikanske dollar", 1),
                new Currency("DKK", "Danske kroner", 6.776579),
                new Currency("GBP", "Britiske pund", 0.764551),
                new Currency("EUR", "Euro", 0.906779),
                new Currency("CAD", "Canadiske dollar", 1.314871),
                new Currency("JPY", "Japansk yen", 109.185264),
                new Currency("CHF", "Schweizerfranc", 0.970397),
                new Currency("AUD", "Australske dollar", 1.466241),
                new Currency("INR", "Indisk rupee", 71.317054),
                new Currency("SGD", "Singaporeansk dollar", 1.352199)
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
