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

            var primes = new List<int> {2};

            foreach (var number in Enumerable.Range(3, limit - 2))
            {
                var divisors = primes.TakeWhile(p => p * p < limit);

                if (divisors.Contains(number) || divisors.All(d => number % d != 0))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }
    }
}
