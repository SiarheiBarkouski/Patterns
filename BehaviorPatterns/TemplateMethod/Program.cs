using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            var school = new School();
            var university = new University();
            
            school.End();
            Console.WriteLine("________________________");
            university.End();


            Console.ReadKey();
        }
    }
}
