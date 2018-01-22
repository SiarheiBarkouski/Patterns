using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class DifficultMathOperations
    {
        private static readonly Func<int, long> CountFactorial = x => x == 0 ? 1 : CountFactorial(x - 1) * x; 

        public double GetLog(int a)
        {
            return Math.Log(a);
        }

        public double GetSqrt(int a)
        {
            return Math.Sqrt(a);
        }

        public long GetFactorial(int a)
        {
            if (a > 100) throw new ArgumentOutOfRangeException("Argument is too big.");
            return CountFactorial(a);
        }
    }
}
