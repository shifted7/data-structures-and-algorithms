using System;
using Xunit;
using QueueWithStacks.Classes;

namespace QueueWithStacksTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateEmptyPseudoQueue()
        {
            PseudoQueue testQueue = new PseudoQueue();
            Assert.Null(testQueue.Front);
        }

        [Fact]
        public void TestCanEnqueueToBackOfQueue()
        {
            //Arrange
            PseudoQueue testQueue = new PseudoQueue();
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
            PseudoQueue testQueue = new PseudoQueue();

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
            PseudoQueue testQueue = new PseudoQueue();
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
            PseudoQueue testQueue = new PseudoQueue();
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
            PseudoQueue testQueue = new PseudoQueue();

            //Act
            Exception e = Assert.Throws<Exception>(() => testQueue.Dequeue());
            string expectedMessage = "Cannot dequeue because the queue is empty.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }


    }
}
