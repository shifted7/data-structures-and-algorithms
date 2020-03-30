using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateStackWithEmptyTop()
        {
            Stack testStack = new Stack();
            Assert.True(testStack.Top == null);
        }

        [Fact]
        public void TestCanPushToTopOfStack()
        {
            //Arrange
            Stack testStack = new Stack();
            int testValue = 2;

            //Act
            testStack.Push(testValue);

            //Assert
            Assert.Equal(testValue, testStack.Top.Value);
        }

        [Fact]
        public void TestCanPushMultipleValuesToTopOfStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            testStack.Push(23);
            testStack.Push(24);
            testStack.Push(25);
            testStack.Push(26);
            int expectedValue = 23;

            //Assert
            Assert.Equal(expectedValue, testStack.Top.Next.Next.Next.Value);
        }

        [Fact]
        public void TestCanPopFromTopOfStack()
        {
            //Arrange
            Stack testStack = new Stack();
            testStack.Push(3);
            testStack.Push(4);

            //Act
            testStack.Pop();
            int expectedValue = 3;

            //Assert
            Assert.Equal(expectedValue, testStack.Top.Value);
        }

        [Fact]
        public void TestCanPopFromTopOfStackUntilEmpty()
        {
            //Arrange
            Stack testStack = new Stack();
            testStack.Push(31);
            testStack.Push(32);
            testStack.Push(33);
            testStack.Push(34);

            //Act
            while(testStack.Top != null)
            {
                testStack.Pop();
            }

            //Assert
            Assert.Null(testStack.Top);
        }

        [Fact]
        public void TestPopWillThrowExceptionForEmptyStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            Exception e = Assert.Throws<Exception>(() => testStack.Pop());
            string expectedMessage = "Cannot pop because the stack is empty.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanPeekTopValue()
        {
            //Arrange
            Stack testStack = new Stack();
            testStack.Push(16);

            //Act
            int result = testStack.Peek();
            int expectedValue = 16;

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void TestPeekWillThrowExceptionForEmptyStack()
        {
            //Arrange
            Stack testStack = new Stack();

            //Act
            Exception e = Assert.Throws<Exception>(() => testStack.Peek());
            string expectedMessage = "Cannot peek because the stack is empty.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }
    }
}
