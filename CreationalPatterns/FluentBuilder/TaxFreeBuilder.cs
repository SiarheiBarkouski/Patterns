using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class TaxFreeBuilder
    {
        private string _personalData;
        private string _address;
        private string _cheque;

        public TaxFreeBuilder BuildPersonalData(string firstname, string lastname,string passportlNumber)
        {
            _personalData = $"Name: {firstname} {lastname}\n" +
                            $"Passport number: {passportlNumber}";
            return this;
        }

        public TaxFreeBuilder BuildAddress(string coutry, string city, string street, int houseNumber)
        {
            _address = $"Address: {coutry}, {city}, {street}, {houseNumber}";
            return this;
        }

        public TaxFreeBuilder BuildCheque(IEnumerable<Product> products)
        {
            _cheque = "_________\n" +
                      "Products\n";
            foreach (var item in products)
            {
                _cheque += $"{item.Name}: {item.Price}\n";
            }
            return this;
        }

        public string GetTaxFreeBlanque()
        {
            return _personalData + "\n" +
                   _address + "\n" +
                   _cheque;
        }
    }
}
