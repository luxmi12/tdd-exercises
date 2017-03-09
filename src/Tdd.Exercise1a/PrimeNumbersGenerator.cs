using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise1a
{
    public static class PrimeNumbersGenerator
    {
        public static IEnumerable<int> Generate(uint maxBound)
        {
            if (maxBound <= 1)
            {
                return Enumerable.Empty<int>();
            }

            return PrimeNumbers.TakeWhile(number => number <= maxBound);
        }

        private static IEnumerable<int> PrimeNumbers
        {
            get { return new List<int> {2, 3, 5, 7}; }
        }
    }
}
