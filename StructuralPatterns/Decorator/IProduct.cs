using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IProduct
    {
        string Name { get; set; }

        double Price { get; set; }

        int Number { get; set; }

        string Currency { get; set; }

        void ShowProduct();
    }
}
