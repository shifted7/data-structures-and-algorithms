using System;
using Xunit;
using LinkedList;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateNewNodeWithValue()
        {
            Node newNode = new Node();
            Assert.NotNull(newNode);
        }
        
        [Fact]
        public void TestCanCreateEmptyLinkList()
        {
            LinkList newLinkList = new LinkList();
            Assert.Null(newLinkList.Head);
        }

        [Fact]
        public void TestCanInsertNewNodeWithValue()
        {
            int value = 5;
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(value);
            Assert.Equal(value, newLinkList.Head.Value);
        }

        [Fact]
        public void TestIncludesCorrectlyReturnsTrueForValueInLinkedList()
        {
            LinkList newLinkList = new LinkList();
            int value = 12;
            newLinkList.Insert(value);
            value = 2;
            newLinkList.Insert(value);
            value = 5340;
            newLinkList.Insert(value);
            Assert.True(newLinkList.Includes(12));

        }

        [Fact]
        public void TestIncludesCorrectlyReturnsFalseForValueNotInLinkedList()
        {
            LinkList newLinkList = new LinkList();
            int value = 12;
            newLinkList.Insert(value);
            value = 2;
            newLinkList.Insert(value);
            value = 5340;
            newLinkList.Insert(value);
            Assert.False(newLinkList.Includes(20));
        }

        [Fact]
        public void TestToStringDisplaysAllValuesInLinkedListCorrectly()
        {
            LinkList newLinkList = new LinkList();
            int value = 65;
            newLinkList.Insert(value);
            value = 0;
            newLinkList.Insert(value);
            value = 6789;
            newLinkList.Insert(value);
            value = 12;
            newLinkList.Insert(value);
            string expectedString = "{12} -> {6789} -> {0} -> {65} -> NULL";
            Assert.Equal(expectedString, newLinkList.ToString());
        }

        [Fact]
        public void TestAppendAddsNodeToEndOfLinkedList()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(1);
            newLinkList.Insert(2);
            newLinkList.Insert(3);
            newLinkList.Insert(4);
            int value = 99;
            Node CurrentNode = newLinkList.Head;

            //Act
            newLinkList.Append(value);
            while(CurrentNode.Next != null) // Loop until the end Node of the linked list
            {
                CurrentNode = CurrentNode.Next;
            }

            //Assert
            Assert.Equal(value, CurrentNode.Value);
        }

        [Fact]
        public void TestCanAppendMultipleNodesToEndOfLinkedList()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(12);
            newLinkList.Insert(13);
            newLinkList.Insert(14);
            newLinkList.Insert(15);
            int[] values = { 82, 83, 84 };

            //Act
            newLinkList.Append(values[0]);
            newLinkList.Append(values[1]);
            newLinkList.Append(values[2]);
            string resultString = newLinkList.ToString();

            //Assert
            Assert.Equal("{15} -> {14} -> {13} -> {12} -> {82} -> {83} -> {84} -> NULL", resultString);
        }

        // Lab 6 Tests commented out - will be updated for lab 6 re-submit
        //[Fact]
        //public void TestCanInsertNodeBeforeMiddleNodeOfLinkedList()
        //{
        //    //Arrange
        //    LinkList newLinkList = new LinkList();
        //    newLinkList.Insert(22);
        //    newLinkList.Insert(23);
        //    newLinkList.Insert(24);

        //    //Act
        //    newLinkList.InsertBefore(1, 901);
        //    string resultString = newLinkList.ToString();

        //    //Assert
        //    Assert.Equal("{24} -> {901} -> {23} -> {22} -> NULL", resultString);
        //}

        //[Fact]
        //public void TestCanInsertNodeBeforeFirstNodeOfLinkedList()
        //{
        //    //Arrange
        //    LinkList newLinkList = new LinkList();
        //    newLinkList.Insert(34);

        //    //Act
        //    newLinkList.InsertBefore(0, 904);
        //    string resultString = newLinkList.ToString();

        //    //Assert
        //    Assert.Equal("{904} -> {34} -> NULL", resultString);
        //}

        //[Fact]
        //public void TestCanInsertNodeAfterMiddleNodeOfLinkedList()
        //{

        //}

        //[Fact]
        //public void TestCanInsertNodeAfterLastNodeOfLinkedList()
        //{

        //}

        [Fact]
        public void TestCanHandleKthFromEndIfKIsGreaterThanLinkedListLength()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(42);
            string expectedMessage = "k exceeds range of linked list";

            //Act
            Exception e = Assert.Throws<Exception>(() => newLinkList.getValueKthFromEnd(3));

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanHandleKthFromEndIfKIsSameAsLinkedListLength()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(43);
            newLinkList.Insert(44);
            newLinkList.Insert(45);
            string expectedMessage = "k exceeds range of linked list";
            
            //Act
            Exception e = Assert.Throws<Exception>(() => newLinkList.getValueKthFromEnd(3));

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanHandleKthFromEndIfKIsNegative()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(48);
            string expectedMessage = "k must be positive";


            //Act
            Exception e = Assert.Throws<Exception>(() => newLinkList.getValueKthFromEnd(-2));

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanHandleKthFromEndIfLinkListLengthIsOne()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(51);

            //Act
            int result = newLinkList.getValueKthFromEnd(0);

            //Assert
            Assert.Equal(51, result);
        }
    }
}
