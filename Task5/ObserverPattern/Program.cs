using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CollectionInt();
            var observer = new CollectionIntObserver();

            list.Subscribe(observer);


            for (int i = 0; i < 7; i++)
            {
                list.AddItem(i * 13);
            }

            foreach (var item in list)            
                Console.WriteLine(item);

            list.AddItem(22);
            list.AddItem(7);
            list.AddItem(1);

            foreach (var item in list)
                Console.WriteLine(item);



            Console.ReadKey();
        }
    }
}
