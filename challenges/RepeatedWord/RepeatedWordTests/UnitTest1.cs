using System;
using Xunit;
using RepeatedWord;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanFindRepeatedSingleCharacters()
        {
            //Arrange
            string testText = "a a";
            string expectedResult = "a";
            //Act
            string result = Program.RepeatedWord(testText);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestCanReturnNullForEmptyString()
        {
            //Arrange
            string testText = "";
            //Act
            string result = Program.RepeatedWord(testText);
            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestCanReturnNullForAllUniqueWords()
        {
            //Arrange
            string testText = "The birds went south during winter.";
            //Act
            string result = Program.RepeatedWord(testText);
            //Assert
            Assert.Null(result);
        }
        
        [Fact]
        public void TestRepeatedWordReturnsFirstMatch()
        {
            //Arrange
            string testText = "The Wheel of Time turns, and Ages come and pass, leaving memories that become legend. Legend fades to myth, and even myth is long forgotten when the Age that gave it birth comes again. ... There are neither beginnings nor endings to the Wheel of Time. But it was a beginning.";
            //Act
            string result = Program.RepeatedWord(testText);
            string expectedResult = "and";
            //Assert
            Assert.Equal(expectedResult, result);
        }
    }

}
