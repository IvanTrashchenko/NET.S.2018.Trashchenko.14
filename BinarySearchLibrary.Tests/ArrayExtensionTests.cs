using System;
using NUnit.Framework;

namespace BinarySearchLibrary.Tests
{
    [TestFixture]
    public class ArrayExtensionTests
    {
        [TestCase(new int[] { 1, 6, 15, 78, 79, 100 }, 78, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 6, 15, 78, 79, 100 }, 1, ExpectedResult = 0)]
        [TestCase(new int[] { }, 15, ExpectedResult = null)]
        public static int? BinarySearch_Int_Interface_Success(int[] array, int item) 
            => array.BinarySearch(item);


        [TestCase(new string[] { "a", "b", "c", "d", "e" }, "d", ExpectedResult = 3)]
        [TestCase(new string[] { "a", "b", "c", "d", "e" }, "", ExpectedResult = null)]
        public static int? BinarySearch_String_Delegate_Success(string[] array, string item) 
            => array.BinarySearch(item, string.Compare);

        [TestCase(null, "d")]
        public void BinarySearch_ThrowsArgumentNullException(string[] array, string item)
        {
            Assert.Throws<ArgumentNullException>(() => array.BinarySearch(item));
        }
    }
}
