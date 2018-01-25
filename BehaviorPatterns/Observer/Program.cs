using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectA = new ClassA(1.ToString()) {Value = 100};
            objectA.Observe(new ValueObserver());

            var counter = 0;

            var timer = new Timer(5000);
            timer.Elapsed += (sender, e) =>
            {
                objectA.Value = ++counter;
                Console.WriteLine(objectA.Value);
            };
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.ReadKey();
        }
    }
}
