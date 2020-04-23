using System;
using Xunit;
using QuickSort;

namespace QuickSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanSwapTwoElements()
        {
            int[] testArray = new int[] { 1, 2 };
            int[] expectedArray = new int[] { 2, 1 };
            Program.Swap(testArray, 1, 0);
            Assert.Equal(expectedArray, testArray);
        }
        
        [Fact]
        public void TestCanPartitionSampleArray()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] expectedArray = new int[] { 8, 4, 15, 42, 16, 23 };
            Program.Partition(testArray, 0, testArray.Length-1);
            Assert.Equal(expectedArray, testArray);
        }

        [Fact]
        public void TestPartitionSampleArrayReturnsCorrectIndex()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
            // int[] expectedArray = new int[] { 8, 4, 15, 42, 16, 23 };
            int resultIndex = Program.Partition(testArray, 0, testArray.Length - 1);
            Assert.Equal(2, resultIndex);
        }

        [Fact]
        public void TestQuickSortCanSortArrayOfTwoElements()
        {
            int[] testArray = new int[] { 5, 3 };
            int[] expectedArray = new int[] { 3, 5 };
            Program.QuickSort(testArray, 0, testArray.Length - 1);
            Assert.Equal(expectedArray, testArray);
        }

        [Fact]
        public void TestQuickSortCanSortSampleArray()
        {
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] expectedArray = new int[] { 4, 8, 15, 16, 23, 42 };
            Program.QuickSort(testArray, 0, testArray.Length - 1);
            Assert.Equal(expectedArray, testArray);
        }
    }
}
