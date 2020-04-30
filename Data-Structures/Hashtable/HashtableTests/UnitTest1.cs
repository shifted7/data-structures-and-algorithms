using Hashtable;
using System;
using System.Linq;
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

        [Fact]
        public void TestCanHashKeys()
        {
            //Arrange
            HashTable testHashTable = new HashTable(128);
            //Act
            string testKeyA = "Andrew";
            int testHashA = testHashTable.Hash(testKeyA);
            string testKeyB = "Werdna";
            int testHashB = testHashTable.Hash(testKeyB);


            //Assert
            Assert.NotEqual(testHashA, testHashB);
        }

        [Fact]
        public void TestCanAddStringValueToHashTable()
        {
            //Arrange
            HashTable testHashTable = new HashTable(128);
            //Act
            string testKey = "Andrew";
            string testValue = "Casper";
            testHashTable.Add(testKey, testValue);
            int expectedHash = testHashTable.Hash(testKey);
            string result = testHashTable.Contents[expectedHash].First.Value.Value;

            //Assert
            Assert.Equal(testValue, result);
        }
    }
}
