using NUnit.Framework;

namespace AlgoritmsStructures.Tests
{
    public class SearchingTests
    {
        private static void testing(int item, int[] arr, int expected)
        {
            Assert.AreEqual(expected, Searching.LinearSearch(arr, item));
            Assert.AreEqual(expected, Searching.BinarySearch(arr, item));
            Assert.AreEqual(expected, Searching.RecursiveBinarySearch(arr, item));
        }

        [Test]
        public static void Tests()
        {
            testing(6, new int[] { 1, 2, 4, 6, 10, 43 }, 3);
            testing(90, new int[] { 1, 2, 4, 6, 10, 43 }, -1);
        }

    }
}