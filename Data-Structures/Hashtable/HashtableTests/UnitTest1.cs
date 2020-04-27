using Hashtable;
using System;
using Xunit;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateHashTableOfSize128()
        {
            //Arrange
            //Act
            HashTable testHashTable = new HashTable(128);

            //Assert
            Assert.Equal(128, testHashTable.Size);
        }
    }
}
