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
        
        [Fact]
        public void TestBinarySearchCorrectlyDoesNotFind()
        {
            int[] sortedArray = { 11, 22, 33, 44, 55, 66, 77 };
            int key = 90;
            Assert.Equal(-1, Program.BinarySearch(sortedArray, key));
        }

        [Fact]
        public void TestBinarySearchCorrectlyHandlesEmptyArray()
        {
            int[] sortedArray = { };
            int key = 5;
            Assert.Equal(-1, Program.BinarySearch(sortedArray, key));
        }


    }
}
