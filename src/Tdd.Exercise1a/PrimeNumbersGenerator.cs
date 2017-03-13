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

            return Enumerable.Range(2, limit - 1).Where(number =>
                number == 2 || number == 3 || number % 2 != 0 && number % 3 != 0);
        }
    }
}
