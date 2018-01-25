using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument("Country","Belarus");

            var name = "city";
            doc.AddElement(name,"Minsk").AddElement("region","Serebranka").AddElement("street","Rokossovskogo");
            doc.AddElement(name, "Grodno");
            doc.AddElement(name, "Gomel");
            doc.AddElement(name, "Brest");
            doc.AddElement(name, "Mogilev");
            doc.AddElement(name, "Vitebsk");

            doc.ShowDocument();

            Console.ReadKey();
        }
    }
}
