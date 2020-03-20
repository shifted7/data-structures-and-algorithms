using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBinarySearchCanFindAValue()
        {
            int[] sortedArray = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            Assert.Equal(2, Program.BinarySearch(sortedArray, key));
        }
    }
}
