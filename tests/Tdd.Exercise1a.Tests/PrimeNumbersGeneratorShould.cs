using NUnit.Framework;

namespace Tdd.Exercise1a.Tests
{
    [TestFixture]
    public class PrimeNumbersGeneratorShould
    {
        [TestCase((uint)0)]
        [TestCase((uint)1)]
        public void ReturnEmptyListWhenMaxBoundIsLessOrEqualTo1(uint maxBound)
        {
            var actual = PrimeNumbersGenerator.Generate(maxBound);

            Assert.That(actual, Is.Empty);
        }

        [TestCase((uint)5, new[] { 2, 3, 5 })]
        [TestCase((uint)10, new[] { 2, 3, 5, 7 })]
        [TestCase((uint)20, new[] { 2, 3, 5, 7, 11, 13, 17, 19 })]
        public void ReturnPrimeNumbersUntilMaxBound(uint maxBound, int[] expected)
        {
            var actual = PrimeNumbersGenerator.Generate(maxBound);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}