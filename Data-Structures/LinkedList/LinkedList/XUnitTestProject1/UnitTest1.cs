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
    }
}
