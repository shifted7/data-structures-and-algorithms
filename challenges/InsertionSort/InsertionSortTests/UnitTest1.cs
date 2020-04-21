using System;
using Xunit;
using InsertionSort;

namespace InsertionSortTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertionSortCanSortArrayOfLengthTwo()
        {
            //Arrange
            int[] testArray = new int[] { 2, 1 };
            int[] expectedArray = new int[] { 1, 2 };
            
            //Act
            Program.InsertionSort(testArray);
            
            //Assert
            Assert.Equal(expectedArray, testArray);
        }

        [Fact]
        public void TestInsertionSortCanHandleEmptyArray()
        {
            //Arrange
            int[] testArray = new int[] { };
            int[] expectedArray = new int[] { };

            //Act
            Program.InsertionSort(testArray);

            //Assert
            Assert.Equal(expectedArray, testArray);
        }

        [Fact]
        public void TestInsertionSortCanHandleArrayOfLengthOne()
        {
            //Arrange
            int[] testArray = new int[] { 3 };
            int[] expectedArray = new int[] { 3 };

            //Act
            Program.InsertionSort(testArray);

            //Assert
            Assert.Equal(expectedArray, testArray);
        }

        [Fact]
        public void TestInsertionSortCanSortSampleArrayA()
        {
            //Arrange
            int[] testArray = new int[] { 8, 4, 23, 42, 16, 15 };
            int[] expectedArray = new int[] { 4, 8, 15, 16, 23, 42 };

            //Act
            Program.InsertionSort(testArray);

            //Assert
            Assert.Equal(expectedArray, testArray);
        }
    }
}
