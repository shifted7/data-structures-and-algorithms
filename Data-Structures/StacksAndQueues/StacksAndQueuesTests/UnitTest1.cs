using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {
        // ------------------------------------ Stack Tests ------------------------------------------

        [Fact]
        public void TestCanCreateEmptyStack()
        {
            Stack testStack = new Stack();
            Assert.Null(testStack.Top);
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
            while (testStack.Top != null)
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
        public void TestCanPeekTopValueOfStack()
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

        // ------------------------------------ Queue Tests ------------------------------------------

        [Fact]
        public void TestCanCreateEmptyQueue()
        {
            Queue testQueue = new Queue();
            Assert.Null(testQueue.Front);
        }

        [Fact]
        public void TestCanEnqueueToBackOfQueue()
        {
            //Arrange
            Queue testQueue = new Queue();
            int testValue = 40;

            //Act
            testQueue.Enqueue(testValue);

            //Assert
            Assert.Equal(testValue, testQueue.Front.Value);
        }

        [Fact]
        public void TestCanEnqueueMultipleValuesToRearOfQueue()
        {
            //Arrange
            Queue testQueue = new Queue();

            //Act
            testQueue.Enqueue(42);
            testQueue.Enqueue(43);
            testQueue.Enqueue(44);
            testQueue.Enqueue(45);
            int expectedValue = 45;

            //Assert
            Assert.Equal(expectedValue, testQueue.Front.Next.Next.Next.Value);
        }

        [Fact]
        public void TestCanDequeueFromFrontOfQueue()
        {
            //Arrange
            Queue testQueue = new Queue();
            testQueue.Enqueue(50);
            testQueue.Enqueue(51);

            //Act
            Node dequeuedNode = testQueue.Dequeue();
            int expectedValue = 50;

            //Assert
            Assert.Equal(expectedValue, dequeuedNode.Value); //Checking the value of the node that was removed.
        }

        [Fact]
        public void TestCanDequeueFromFrontOfQueueUntilEmpty()
        {
            //Arrange
            Queue testQueue = new Queue();
            testQueue.Enqueue(55);
            testQueue.Enqueue(56);
            testQueue.Enqueue(57);
            testQueue.Enqueue(58);

            //Act
            while (testQueue.Front != null)
            {
                testQueue.Dequeue();
            }

            //Assert
            Assert.Null(testQueue.Front);
        }

        [Fact]
        public void TestDequeueWillThrowExceptionForEmptyQueue()
        {
            //Arrange
            Queue testQueue = new Queue();

            //Act
            Exception e = Assert.Throws<Exception>(() => testQueue.Dequeue());
            string expectedMessage = "Cannot dequeue because the queue is empty.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanPeekFrontValueOfQueue()
        {
            //Arrange
            Queue testQueue = new Queue();
            testQueue.Enqueue(60);

            //Act
            int result = testQueue.Peek();
            int expectedValue = 60;

            //Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void TestPeekWillThrowExceptionForEmptyQueue()
        {
            //Arrange
            Queue testQueue = new Queue();

            //Act
            Exception e = Assert.Throws<Exception>(() => testQueue.Peek());
            string expectedMessage = "Cannot peek because the queue is empty.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }
    }
}
