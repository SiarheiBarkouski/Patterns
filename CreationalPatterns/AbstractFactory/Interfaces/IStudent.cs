using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Interfaces
{
    interface IStudent
    {
        string Fio { get; set; }
        int Age { get; set; }

        void Greet();
    }
}
