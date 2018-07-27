using System;
using System.Collections.Generic;

namespace BinarySearchLibrary
{
    /// <summary>
    /// Class for BinarySearch methods.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Method which performs binary search of specified item in a sorted array.
        /// </summary>
        /// <typeparam name="T">Type of items.</typeparam>
        /// <param name="sortedArray">Sorted array.</param>
        /// <param name="item">Item to find.</param>
        /// <param name="comparer">Comparer of items.</param>
        /// <returns>Index of item of type <see cref="int"/> if it was found; otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        public static int? BinarySearch<T>(this T[] sortedArray, T item, IComparer<T> comparer = null)
        {
            if (sortedArray == null)
            {
                throw new ArgumentNullException($"{nameof(sortedArray)} can not be null.");
            }

            if (sortedArray.Length == 0)
            {
                return null;
            }

            if (comparer == null)
            {
                comparer = Comparer<T>.Default;
            }

            int first = 0;
            int last = sortedArray.Length;

            while (first < last)
            {
                int middle = first + ((last - first) / 2);

                if (comparer.Compare(item, sortedArray[middle]) == 0)
                {
                    return middle;
                }

                if (comparer.Compare(item, sortedArray[middle]) < 0)
                {
                    last = middle;
                }
                else
                {
                    first = middle + 1;
                }
            }

            return null;
        }

        /// <summary>
        /// Method which performs binary search of specified item in a sorted array.
        /// </summary>
        /// <typeparam name="T">Type of items.</typeparam>
        /// <param name="sortedArray">Sorted array.</param>
        /// <param name="item">Item to find.</param>
        /// <param name="comparison">Comparison delegate.</param>
        /// <returns>Index of item of type <see cref="int"/> if it was found; otherwise, null.</returns>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        public static int? BinarySearch<T>(this T[] sortedArray, T item, Comparison<T> comparison) =>
            sortedArray.BinarySearch(item, Comparer<T>.Create(comparison));
    }
}