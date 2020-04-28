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
    }
}
