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

        [Theory]
        [InlineData(2, new[] {2})]
        [InlineData(3, new[] {2, 3})]
        public void GenerateListUpUntilLimit(int limit, int[] expected)
        {
            var generator = new PrimeNumbersGenerator();

            Assert.Equal(expected, generator.Generate(limit));
        }
    }
}
