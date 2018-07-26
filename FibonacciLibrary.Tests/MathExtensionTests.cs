using System;
using System.Numerics;
using NUnit.Framework;

namespace FibonacciLibrary.Tests
{
    [TestFixture]
    public class MathExtensionTests
    {
        [Test]
        public void FibonacciGenerator_Success()
        {
            BigInteger[][] expected =
                {
                    new BigInteger[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 },
                    new BigInteger[] { 0 },
                    new BigInteger[] { 0, 1 }
                };

            for (int i = 0; i < 3; i++)
            {
                CollectionAssert.AreEqual(expected[i], MathExtension.FibonacciGenerator(expected[i].Length));
            }
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void FibonacciGenerator_ThrowsArgumentOutOfRangeException(int amount)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => MathExtension.FibonacciGenerator(amount));
        }
    }
}