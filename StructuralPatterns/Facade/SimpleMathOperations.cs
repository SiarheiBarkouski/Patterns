using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SimpleMathOperations
    {
        public int Sum(int a, int b)
        {
            return a+b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Devide(int a, int b)
        {
            return a / b;
        }
    }
}
