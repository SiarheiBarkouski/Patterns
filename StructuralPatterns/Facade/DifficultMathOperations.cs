using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DifficultMathOperations
    {
        private static readonly Func<int, long> _factorial = x => x == 0 ? 1 : _factorial(x - 1) * x; 

        public double Log(int a)
        {
            return Math.Log(a);
        }

        public double Sqrt(int a)
        {
            return Math.Sqrt(a);
        }

        public long Factorial(int a)
        {
            if (a > 100) throw new ArgumentOutOfRangeException("Argument is too big.");
            return _factorial(a);
        }
    }
}
