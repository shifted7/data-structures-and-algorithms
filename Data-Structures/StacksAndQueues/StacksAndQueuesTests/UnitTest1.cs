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
    }
}
