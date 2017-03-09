using System;
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
            get
            {
                yield return 2;

                for (var number = 3; ; number += 2)
                {
                    if (IsPrime(number))
                    {
                        yield return number;
                    }
                }
            }
        }

        private static bool IsPrime(int value)
        {
            var squareRoot = (int)Math.Sqrt(value);

            for (var divisor = 3; divisor <= squareRoot; divisor += 2)
            {
                if (value % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
