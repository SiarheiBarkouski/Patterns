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

            var list1 = new TemplateMethod.Iterator.List<School>(new School { Number = 100 },
                                                                new School { Number = 506 },
                                                                new School { Number = 904 });
            
            Console.WriteLine("----------------------\nIterator1:");
            var iterator1 = list1.CreateIterator();

            do
                Console.WriteLine($"Our school number is {iterator1.Current.Number}");
            while (iterator1.MoveNext());


            Console.WriteLine();


            var list2 = new TemplateMethod.Iterator.List<University>(new University { Name = "BSU" },
                                                                     new University { Name = "BNTU" },
                                                                     new University { Name = "BSEU" });
            
            Console.WriteLine("----------------------\nIterator2:");
            var iterator2 = list2.CreateIterator();

            do
                Console.WriteLine($"Our university is {iterator2.Current.Name}");
            while (iterator2.MoveNext());
            
            Console.ReadKey();
        }
    }
}
