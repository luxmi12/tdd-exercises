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

            foreach (var number in GetNumbersToCheckLessThan(limit))
            {
                var divisors = GetPrimeDivisors(limit, primes);

                if (divisors.All(d => IsNotFactor(number, d)))
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        private static IEnumerable<int> GetPrimeDivisors(int limit, IEnumerable<int> primes)
        {
            return primes.TakeWhile(p => p * p <= limit);
        }

        private static bool IsNotFactor(int number, int d)
        {
            return number % d != 0;
        }

        private static IEnumerable<int> GetNumbersToCheckLessThan(int limit)
        {
            return Enumerable.Range(1, limit).Skip(1);
        }
    }
}
