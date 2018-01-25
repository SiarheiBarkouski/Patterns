using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class StringAdapter : IStringAdapter
    {
        public string InputString { get; set; }
        
        public List<int> CountLetters(params char[] letters)
        {
            var resultArray = new List<int>();

            foreach (var item in letters)
            {
                resultArray.Add(InputString.Count(t => t.Equals(item)));
            }
            return resultArray;
        }
    }
}
