using System;
using Xunit;
using MergeSort;

namespace MergeSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanMergeTwoArraysWithOneElementEach()
        {
            int[] testLeft = new int[] { 2 };
            int[] testRight = new int[] { 1 };
            int[] testArray = new int[] { 2, 1 };
            Program.Merge(testLeft, testRight, testArray);
            int[] expectedArray = new int[] { 1, 2 };
            Assert.Equal(expectedArray, testArray);
        }
    }
}
