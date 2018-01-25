using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public string Currency { get; set; }

        public virtual void ShowProduct()
        {
            Console.WriteLine($"{Name}: #{Number}\n{Price:C2}");

        }
    }
}
