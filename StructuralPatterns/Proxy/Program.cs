using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = new StringProxy { InputString = "My mother tongue is Russian." };
            str.CountLetters(new char[] { 'a', 'm', 'o' });
            Console.WriteLine(str.InputString);

            Console.ReadKey();
        }
    }
}
