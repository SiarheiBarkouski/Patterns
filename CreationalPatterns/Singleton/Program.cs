using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = Logger.GetInstance();

            logger.WriteLog("Hello world.");

            Console.WriteLine(File.ReadAllText(logger.Filepath));

            Console.ReadKey();
        }
    }
}
