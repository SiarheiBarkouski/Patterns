﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new RandomNumbersPool(3,1);
            RandomNumber first = null;

            try
            {
                Console.WriteLine((first = x.GetNumber()).Value);
                Console.WriteLine(x.GetNumber().Value);
                Console.WriteLine(x.GetNumber().Value);
                Console.WriteLine(x.GetNumber().Value);
         
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                x.ReleaseNumber(first);
                Console.WriteLine(x.GetNumber().Value);
                Console.WriteLine(x.GetNumber().Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
