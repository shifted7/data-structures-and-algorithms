using System;
using Xunit;
using MultiBracketValidation.Classes;
using MultiBracketValidation;

namespace MultiBracketValidationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateNodeWithCharacter()
        {
            //Arrange
            string input = "(";
            
            //Act
            Node testNode = new Node(input);

            //Assert
            Assert.Equal(input, testNode.Char);
        }

        [Fact]
        public void TestCanCreateEmptyStack()
        {
            //Arrange
            //Act
            Stack testStack = new Stack();

            //Assert
            Assert.Null(testStack.Top);
        }

        [Fact]
        public void TestCanPushNodeIntoEmptyStack()
        {
            //Arrange
            Stack testStack = new Stack();
            string testChar = "t";

            //Act
            testStack.Push(testChar);

            //Assert
            Assert.Equal(testChar, testStack.Top.Char);
        }

        [Fact]
        public void TestCanPushMultipleNodesIntoStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            testStack.Push("t");
            testStack.Push("e");
            testStack.Push("s");
            testStack.Push("t");

            //Assert
            Assert.Equal("e", testStack.Top.Next.Next.Char);
        }

        [Fact]
        public void TestIsEmptyCorrectlyReturnsTrueForEmptyStack()
        {
            //Arrange
            //Act
            Stack testStack = new Stack();

            //Assert
            Assert.True(testStack.IsEmpty());
        }
        [Fact]
        public void TestIsEmptyCorrectlyReturnsFalseForNotEmptyStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            testStack.Push("O");

            //Assert
            Assert.False(testStack.IsEmpty());
        }

        [Fact]
        public void TestCanPopNodeFromTopOfStack()
        {
            //Arrange
            Stack testStack = new Stack();
            testStack.Push("T");
            testStack.Push("e");
            testStack.Push("s");
            testStack.Push("t");

            //Act
            testStack.Pop();

            //Assert
            Assert.Equal("T", testStack.Top.Next.Next.Char);
        }

        [Fact]
        public void TestPopCorrectlyThrowsExceptionForEmptyStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            Exception e = Assert.Throws<Exception>(() => testStack.Pop());
            string expectedMessage = "Cannot pop from the top of an empty stack.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsTrueForSequentialBracketPairs()
        {
            //Arrange
            string inputString = "()[]{}";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsFalseForMissingCloseBracket()
        {
            //Arrange
            string inputString = "()[{}";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsFalseForInitialCloseBracket()
        {
            //Arrange
            string inputString = ")";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsTrueForNestedBrackets()
        {
            //Arrange
            string inputString = "(([{()}]))";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsTrueForExtraCharacters()
        {
            //Arrange
            string inputString = "{}{Code}[Fellows](())";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestMultiBracketValidationCorrectlyReturnsFalseForInterweavingBrackets()
        {
            //Arrange
            string inputString = "{(})";

            //Act
            bool result = Program.MultiBracketValidation(inputString);

            //Assert
            Assert.False(result);
        }
    }
}
