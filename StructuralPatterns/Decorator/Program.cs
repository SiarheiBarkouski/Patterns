using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new AmericanProduct
            {
                Name = "Jeans",
                Price = 10000,
                Number = 930
            };

            var y = new SwitzerlandProduct
            {
                Name = "Bag",
                Price = 3000,
                Number = 175
            };

            x.ShowProduct();
            Console.WriteLine();
            y.ShowProduct();
            Console.ReadKey();
        }
    }
}
