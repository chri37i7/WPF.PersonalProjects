using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WPF.CurrencyConverter
{
    class ViewModel
    {
        private Repository repository;

        public ViewModel()
        {
            repository = new Repository();

            List<Currency> currencies = repository.GetAll();

            Currencies = new ObservableCollection<Currency>(currencies);
        }

        public ObservableCollection<Currency> Currencies { get; set; }

        public Currency FirstSelectedCurrency { get; set; }
        public Currency SecondSelectedCurrency { get; set; }
    }
}
