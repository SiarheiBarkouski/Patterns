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
            var letters = new char[] { 'a', 'm', 'o' };
            var count = str.CountLetters(letters);

            for (int i = 0; i < letters.Length; i++)
                Console.WriteLine($"{letters[i]} - {count[i]} time(s).");


            Console.ReadKey();
        }
    }
}
