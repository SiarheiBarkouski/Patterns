using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IStringAdapter
    {
        string InputString { get; set; }
        List<int> CountLetters(char[] letters);
    }
}
