using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            var main = new MainPage("Vehicles");
            var trucks = main.AddPage("Trucks");
            var cars = main.AddPage("Cars");
            var bicycles = main.AddPage("Bicycles");

            trucks.AddPage("MAZ");
            trucks.AddPage("Volvo");
            trucks.AddPage("ZIL");

            Console.WriteLine(main.ShowWebSite());

            Console.ReadKey();
        }
    }
}
