using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product() {Name = "Jeans", Price = 1000},
                new Product() {Name = "Watch", Price = 5000},
                new Product() {Name = "Jacket", Price = 3000}
            };

            var taxFree = new TaxFreeBuilder().BuildPersonalData("Alex", "Ford", "HJUIKG68765UH213")
                                              .BuildAddress("Belarus", "Minsk", "Nemiga", 5)
                                              .BuildCheque(products)
                                              .GetTaxFreeBlanque();
            Console.WriteLine(taxFree);
            Console.ReadKey();
        }
    }
}
