using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter;

namespace Proxy
{
    class StringProxy
    {
        private readonly StringAdapter _adapter;

        public StringProxy()
        {
            _adapter = new StringAdapter();
        }

        public string InputString
        {
            get => _adapter.InputString;
            set => _adapter.InputString = value;
        }

        public void CountLetters(params char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = char.ToUpper(letters[i]);
            }

            string _old = String.Empty;
            string _new = String.Empty;
            _old = InputString;
            
            InputString = InputString.ToUpper();
            _adapter.CountLetters(letters);
            InputString = _old;
        }
    }
}
