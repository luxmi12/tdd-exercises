using System;
using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise1a
{
    public class PrimeNumbersGenerator
    {
        public IEnumerable<int> Generate(int limit)
        {
            if (limit <= 1)
            {
                return Enumerable.Empty<int>();
            }

            var divisors = new[] {2, 3, 5};
            return Enumerable.Range(2, limit - 1).Where(number =>
                divisors.Contains(number) || divisors.All(d => number % d != 0));
        }
    }
}
