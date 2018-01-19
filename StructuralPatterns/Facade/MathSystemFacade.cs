using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class MathSystemFacade
    {
        private readonly SimpleMathOperations _simple;
        private readonly DifficultMathOperations _difficult;

        public MathSystemFacade()
        {
            _simple = new SimpleMathOperations();
            _difficult = new DifficultMathOperations();
        }

        public int Sum(int a, int b)
        {
            return _simple.Sum(a,b);
        }

        public int Subtract(int a, int b)
        {
            return _simple.Subtract(a, b);
        }

        public int Multiply(int a, int b)
        {
            return _simple.Multiply(a, b);
        }

        public int Devide(int a, int b)
        {
            return _simple.Devide(a, b);
        }

        public double Log(int a)
        {
            return _difficult.Log(a);
        }

        public double Sqrt(int a)
        {
            return _difficult.Sqrt(a);
        }

        public long Factorial(int a)
        {
            return _difficult.Factorial(a);
        }


    }
}
