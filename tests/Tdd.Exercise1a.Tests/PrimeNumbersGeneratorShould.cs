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
    }
}