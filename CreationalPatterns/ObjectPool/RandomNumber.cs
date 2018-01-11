using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectPool
{
    class RandomNumber
    {
        private BigInteger result;
        private readonly BigInteger _number;

        public RandomNumber()
        {
            var input = (BigInteger)new Random(DateTime.Now.Millisecond).Next(100, 10000);
            _number = Factorial(input);
        }
        public BigInteger Value { get => _number; }
        public bool InUse { get; set; }


        private BigInteger Factorial(BigInteger input)
        {
            BigInteger result = 1;
            for (int i = 2; i <= input; ++i)
                result *= i;
            return result;
        }


    }
}
