using System;
using Xunit;
using LinkedList;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateNewNode()
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
        public void TestHeadPointsToFirstNode()
        {
            // Arrange
            LinkList newLinkList = new LinkList();
            
            // Act
            newLinkList.Insert(6);
            newLinkList.Insert(4);
            newLinkList.Insert(2);

            // Assert
            Assert.Equal(2, newLinkList.Head.Value);
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

        [Fact]
        public void TestCanInsertNodeBeforeMiddleNodeOfLinkedList()
        {
            // Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(52);
            newLinkList.Insert(53);
            newLinkList.Insert(55);
            newLinkList.Insert(56);
            string expectedString = "{56} -> {55} -> {54} -> {53} -> {52} -> NULL";

            //Act
            newLinkList.InsertBefore(53, 54);
            string resultString = newLinkList.ToString();

            //Assert
            Assert.Equal(expectedString, resultString);
        }

        [Fact]
        public void TestCanInsertNodeBeforeFirstNodeOfLinkedList()
        {
            // Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(62);
            newLinkList.Insert(63);
            newLinkList.Insert(64);
            newLinkList.Insert(65);
            string expectedString = "{66} -> {65} -> {64} -> {63} -> {62} -> NULL";

            // Act
            newLinkList.InsertBefore(65, 66);
            string resultString = newLinkList.ToString();

            // Assert
            Assert.Equal(expectedString, resultString);
        }

        [Fact]
        public void TestCanInsertNodeAfterMiddleNodeOfLinkedList()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(22);
            newLinkList.Insert(23);
            newLinkList.Insert(24);

            //Act
            newLinkList.InsertAfter(23, 901);
            string resultString = newLinkList.ToString();

            //Assert
            Assert.Equal("{24} -> {23} -> {901} -> {22} -> NULL", resultString);
        }

        [Fact]
        public void TestCanInsertNodeAfterLastNodeOfLinkedList()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(34);
            newLinkList.Insert(35);

            //Act
            newLinkList.InsertAfter(34, 904);
            string resultString = newLinkList.ToString();

            //Assert
            Assert.Equal("{35} -> {34} -> {904} -> NULL", resultString);
        }



        [Fact]
        public void TestKthFromEndCanHandleIfKIsGreaterThanLinkedListLength()
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
        public void TestKthFromEndCanHandleIfKIsSameAsLinkedListLength()
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
        public void TestKthFromEndCanHandleKIsNegative()
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
        public void TestKthFromEndCanHandleLinkListLengthOfOne()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(51);

            //Act
            int result = newLinkList.getValueKthFromEnd(0);

            //Assert
            Assert.Equal(51, result);
        }
        
        [Fact]
        public void TestKthFromEndCorrectlyReturnsValue()
        {
            //Arrange
            LinkList newLinkList = new LinkList();
            newLinkList.Insert(2);
            newLinkList.Insert(8);
            newLinkList.Insert(3);
            newLinkList.Insert(1);

            //Act
            int result = newLinkList.getValueKthFromEnd(2);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestMergeListsCorrectlyMergesTwoLinkedLists()
        {
            //Arrange
            LinkList newLinkList1 = new LinkList();
            newLinkList1.Insert(2);
            newLinkList1.Insert(3);
            newLinkList1.Insert(1);
            LinkList newLinkList2 = new LinkList();
            newLinkList2.Insert(4);
            newLinkList2.Insert(9);
            newLinkList2.Insert(5);
            string expectedString = "{1} -> {5} -> {3} -> {9} -> {2} -> {4} -> NULL";

            //Act
            Program.MergeLists(newLinkList1, newLinkList2);


            //Assert
            Assert.Equal(expectedString, newLinkList1.ToString());
        }

        [Fact]
        public void TestMergeListsCorrectlyHandlesEmptyList()
        {
            // Arrange
            LinkList newLinkList1 = new LinkList();
            newLinkList1.Insert(2);
            newLinkList1.Insert(3);
            newLinkList1.Insert(1);
            LinkList newLinkList2 = new LinkList();
            string expectedString = "{1} -> {3} -> {2} -> NULL";

            // Act
            Program.MergeLists(newLinkList1, newLinkList2);

            // Assert
            Assert.Equal(expectedString, newLinkList1.ToString());
        }
    }
}
