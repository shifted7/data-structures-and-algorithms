using System;
using Xunit;
using Tree;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateNodeWithValue()
        {
            Node testNode = new Node(1);
            Assert.Equal(1, testNode.Value);
        }

        [Fact]
        public void TestCanCreateEmptyBinaryTree()
        {
            BinaryTree testTree = new BinaryTree();
            Assert.Null(testTree.Root);
        }

        [Fact]
        public void TestCanAddSingleValueToBinaryTree()
        {
            //Arrange
            BinaryTree testTree = new BinaryTree();
            int value = 5;
            //Act
            testTree.Add(value);
            //Assert
            Assert.Equal(value, testTree.Root.Value);
        }
    }
}
