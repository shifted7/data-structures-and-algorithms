using System;
using Xunit;
using LeftJoin;
using System.Collections.Generic;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestLeftJoinCanReturnSingleResultFromSingleEntryHashTables()
        {
            HashTable testHashTableA = new HashTable(1);
            testHashTableA.Add("testKey", "testValueA");

            HashTable testHashTableB = new HashTable(1);
            testHashTableB.Add("testKey", "testValueB");

            var result = Program.LeftJoin(testHashTableA, testHashTableB);
            string[] expectedEntry = new string[] { "testKey", "testValueA", "testValueB" };

            Assert.Contains(expectedEntry, result);
        }

        [Fact]
        public void TestLeftJoinCorrectlyDoesNotReturnValuesForNonMatchingKeys()
        {
            HashTable testHashTableA = new HashTable(1);
            testHashTableA.Add("color", "red");
            testHashTableA.Add("name", "Andrew");

            HashTable testHashTableB = new HashTable(1);
            testHashTableB.Add("shape", "circle");
            testHashTableB.Add("animal", "cat");

            var result = Program.LeftJoin(testHashTableA, testHashTableB);
            string[] expectedEntry = new string[] { "name", "Andrew", null };

            Assert.Contains(expectedEntry, result);
        }

        [Fact]
        public void TestLeftJoinCanHandleMultipleMatchingKeys()
        {
            HashTable testHashTableA = new HashTable(1);
            testHashTableA.Add("color", "red");
            testHashTableA.Add("name", "Andrew");
            testHashTableA.Add("city", "Seattle");
            testHashTableA.Add("shape", "square");
            testHashTableA.Add("animal", "dog");

            HashTable testHashTableB = new HashTable(1);
            testHashTableB.Add("shape", "circle");
            testHashTableB.Add("animal", "cat");
            testHashTableB.Add("city", "Seattle");


            var result = Program.LeftJoin(testHashTableA, testHashTableB);
            string[] expectedEntry = new string[] { "city", "Seattle", "Seattle" };

            Assert.Contains(expectedEntry, result);
        }
    }
}
