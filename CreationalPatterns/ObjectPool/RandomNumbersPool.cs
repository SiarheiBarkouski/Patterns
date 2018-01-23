using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectPool
{
    class RandomNumbersPool
    {
        private int minSize;
        private int maxSize;
        private readonly IList<RandomNumber> randomNumbers;


        public int MinSize { get => minSize; set => minSize = value; }
        public int MaxSize { get => maxSize; set => maxSize = value; }

        public RandomNumbersPool(int maxSize = 5, int minSize = 1)
        {
            this.maxSize = maxSize;
            randomNumbers = new List<RandomNumber>();
            for (int i = 0; i < maxSize; i++)
            {
                Thread.Sleep(1);
                randomNumbers.Add(new RandomNumber());
            }
        }

        private RandomNumber CreateNumber()
        {
            if (randomNumbers.Count < maxSize)
            {
                var num = new RandomNumber();
                randomNumbers.Add(num);
                return num;
            }
            return null;
        }

        public RandomNumber GetNumber()
        {
            var num = randomNumbers.FirstOrDefault(x => !x.InUse);

            if (num != null)
            {
                num.InUse = true;
                return num;
            }

            if (num == null && randomNumbers.Count == maxSize)
                throw new Exception("No free objects available in the pool.");

            num = CreateNumber();

            num.InUse = true;
            return num;
        }

        public void ReleaseNumber(RandomNumber num)
        {

            if (!randomNumbers.Contains(num))
                throw new ArgumentException("Number doesn't belong to the randomNumbers' pool.");

            num.InUse = false;
        }

        public void DeleteNumber(RandomNumber num)
        {
            if (!randomNumbers.Contains(num))
                throw new ArgumentException("Number doesn't belong to the randomNumbers' pool.");

            if (randomNumbers.Count > minSize)
                randomNumbers.Remove(num);

            throw new Exception("Current objects' count is below minSize.");
        }

        public void RebuildObjects()
        {
            randomNumbers.Clear();
            for (int i = 0; i < maxSize; i++)
            {
                randomNumbers.Add(new RandomNumber());
            }
        }

    }
}
