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
                new Currency("USD", "Amerikanske Dollar", 1),
                new Currency("DKK", "Danske kroner", 6.776579),
                new Currency("GBP", "Britiske pund", 0.764551),
                new Currency("EUR", "Euro", 0.906779)
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
