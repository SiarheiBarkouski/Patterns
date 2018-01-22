using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectA = new ClassA(1.ToString()) {Value = 100};
            objectA.Observe(new ValueObserver());

            Console.WriteLine(100);
            Console.ReadKey();
            Console.WriteLine(200);
            objectA.Value = 200;
            Console.ReadKey();
            Console.WriteLine(300);
            objectA.Value = 300;
            Console.ReadKey();
            Console.WriteLine(400);
            objectA.Value = 400;
            Console.ReadKey();
            Console.WriteLine(500);
            objectA.Value = 500;
            Console.ReadKey();
            Console.WriteLine(600);
            objectA.Value = 600;
        }
    }
}
