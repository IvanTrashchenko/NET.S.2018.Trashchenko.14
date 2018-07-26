using System;
using System.Collections.Generic;
using System.Numerics;

namespace FibonacciLibrary
{
    /// <summary>
    /// Class of FibonacciGenerator method.
    /// </summary>
    public static class MathExtension
    {
        #region FibonacciGenerator method

        /// <summary>
        /// Method for generating a sequence of Fibonacci numbers.
        /// </summary>
        /// <param name="amount">Amount of Fibonacci numbers.</param>
        /// <returns>Sequence of type IEnumerable - BigInteger.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when amount value is less or equal to zero.</exception>
        public static IEnumerable<BigInteger> FibonacciGenerator(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(amount)} must be positive.");
            }

            return GenerateSequence(amount);
        }

        #endregion

        #region Private methods

        private static IEnumerable<BigInteger> GenerateSequence(int amount)
        {
            BigInteger current = 0;
            BigInteger next = 1;

            for (int i = 0; i < amount; i++)
            {
                yield return current;
                BigInteger temp = next;
                next += current;
                current = temp;
            }
        }

        #endregion
    }
}
