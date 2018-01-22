using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalPatterns.Factories;

namespace CreationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var mark = 2;
            var language = Language.Foreign;

            var student = new StudentFactory(mark, language).CreateStudent();

            student.Greet();

            Console.ReadKey();
        }
    }
}
