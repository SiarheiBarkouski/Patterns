using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new MathSystemFacade();

            Console.WriteLine(x.Sqrt(225));
            Console.WriteLine(x.Factorial(5));

            Console.ReadKey();

        }
    }
}
