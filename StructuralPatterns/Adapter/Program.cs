using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringAdapter { InputString = "My mother tongue is Russian." };
            str.CountLetters(new char[] {'a', 'm', 'o'});

            Console.ReadKey();
        }
    }
}
