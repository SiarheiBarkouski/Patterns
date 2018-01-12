using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class StringAdapter : IStringAdapter
    {
        private string _inputString;

        public StringAdapter()
        {
            _inputString = String.Empty;
        }

        public string InputString
        {
            get => _inputString;
            set => _inputString = value;
        }
        public void CountLetters(char[] letters)
        {
            int counter = 0;
            Console.WriteLine("__________\n" + _inputString);
            for (int i = 0; i < letters.Length; i++)
            {
                counter += _inputString.Count(t => t.Equals(letters[i]));
                Console.WriteLine($"'{letters[i]}' enters {counter} times.");
                counter = 0;
            }
        }
    }
}
