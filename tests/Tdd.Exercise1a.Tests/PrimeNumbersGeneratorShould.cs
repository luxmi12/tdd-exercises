using System;
using Xunit;
using Tdd.Exercise1a;

namespace Tdd.Exercise1a.Tests
{
    public class PrimeNumbersGeneratorShould
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void GenerateEmptyListUpUntilOne(int limit)
        {
            var generator = new PrimeNumbersGenerator();

            Assert.Empty(generator.Generate(limit));
        }
    }
}
