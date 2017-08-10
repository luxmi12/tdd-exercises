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

            return CalculatePrimes(limit);
        }

        private static IEnumerable<int> CalculatePrimes(int limit)
        {
            var primes = new List<int>();

            foreach (var number in GetNumbersToCheck(limit))
            {
                var divisors = primes.TakeWhile(p => p * p <= limit);

                if (divisors.All(d => number % d != 0))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        private static IEnumerable<int> GetNumbersToCheck(int limit)
        {
            return Enumerable.Range(1, limit).Skip(1);
        }
    }
}
