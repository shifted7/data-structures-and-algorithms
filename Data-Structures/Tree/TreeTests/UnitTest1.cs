using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;

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
            Node testNode = new Node(value);
            //Act
            testTree.Root = testNode;
            //Assert
            Assert.Equal(value, testTree.Root.Value);
        }

        [Fact]
        public void TestCanAddLeftAndRightNodesToRootOfBinaryTree()
        {
            //Arrange
            BinaryTree testTree = new BinaryTree();
            Node testRoot = new Node(0);
            Node testLeft = new Node(5);
            Node testRight = new Node(5);

            //Act
            testTree.Root = testRoot;
            testTree.Root.Left = testLeft;
            testRoot.Right = testRight;

            //Assert
            Assert.Equal(testTree.Root.Left.Value, testTree.Root.Right.Value);
        }

        [Fact]
        public void TestCanReturnCollectionFromPreOrderTraversalOfBinaryTree()
        {
            BinaryTree testTree = new BinaryTree();
            Node testRoot = new Node(0);
            Node testLeft = new Node(1);
            Node testLeftLeft = new Node(2);
            Node testLeftRight = new Node(3);
            Node testRight = new Node(4);
            Node testRightLeft = new Node(5);
            List<int> expectedCollection = new List<int>();
            
            expectedCollection.Add(0);
            expectedCollection.Add(1);
            expectedCollection.Add(2);
            expectedCollection.Add(3);
            expectedCollection.Add(4);
            expectedCollection.Add(5);

            testTree.Root = testRoot;
            testTree.Root.Left = testLeft;
            testTree.Root.Left.Left = testLeftLeft;
            testTree.Root.Left.Right = testLeftRight;
            testTree.Root.Right = testRight;
            testTree.Root.Right.Left = testRightLeft;
            List<int> resultCollection = testTree.PreOrder(testTree.Root);

            Assert.Equal(expectedCollection, resultCollection);
        }

        [Fact]
        public void TestPreOrderWillCorrectlyThrowExceptionForEmptyTree()
        {
            BinaryTree testTree = new BinaryTree();
            
            Exception e = Assert.Throws<Exception>(() => testTree.PreOrder(testTree.Root));
            string expectedMessage = "Cannot return the pre-ordered collection of elements for an empty tree.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanReturnCollectionFromInOrderOfBinaryTree()
        {
            BinaryTree testTree = new BinaryTree();
            Node testLeftLeft = new Node(0);
            Node testLeft = new Node(1);
            Node testLeftRight = new Node(2);
            Node testRoot = new Node(3);
            Node testRightLeft = new Node(4);
            Node testRight = new Node(5);
            List<int> expectedCollection = new List<int>();

            expectedCollection.Add(0);
            expectedCollection.Add(1);
            expectedCollection.Add(2);
            expectedCollection.Add(3);
            expectedCollection.Add(4);
            expectedCollection.Add(5);

            testTree.Root = testRoot;
            testTree.Root.Left = testLeft;
            testTree.Root.Left.Left = testLeftLeft;
            testTree.Root.Left.Right = testLeftRight;
            testTree.Root.Right = testRight;
            testTree.Root.Right.Left = testRightLeft;
            List<int> resultCollection = testTree.InOrder(testTree.Root);

            Assert.Equal(expectedCollection, resultCollection);
        }

        [Fact]
        public void TestInOrderWillCorrectlyThrowExceptionForEmptyTree()
        {
            BinaryTree testTree = new BinaryTree();

            Exception e = Assert.Throws<Exception>(() => testTree.InOrder(testTree.Root));
            string expectedMessage = "Cannot return the in-order collection of elements for an empty tree.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanReturnCollectionFromPostOrderOfBinaryTree()
        {
            BinaryTree testTree = new BinaryTree();
            Node testLeftLeft = new Node(0);
            Node testLeftRight = new Node(1);
            Node testLeft = new Node(2);
            Node testRightLeft = new Node(3);
            Node testRight = new Node(4);
            Node testRoot = new Node(5);
            List<int> expectedCollection = new List<int>();

            expectedCollection.Add(0);
            expectedCollection.Add(1);
            expectedCollection.Add(2);
            expectedCollection.Add(3);
            expectedCollection.Add(4);
            expectedCollection.Add(5);

            testTree.Root = testRoot;
            testTree.Root.Left = testLeft;
            testTree.Root.Left.Left = testLeftLeft;
            testTree.Root.Left.Right = testLeftRight;
            testTree.Root.Right = testRight;
            testTree.Root.Right.Left = testRightLeft;
            List<int> resultCollection = testTree.PostOrder(testTree.Root);

            Assert.Equal(expectedCollection, resultCollection);
        }

        [Fact]
        public void TestPostOrderWillCorrectlyThrowExceptionForEmptyTree()
        {
            BinaryTree testTree = new BinaryTree();

            Exception e = Assert.Throws<Exception>(() => testTree.PostOrder(testTree.Root));
            string expectedMessage = "Cannot return the post-ordered collection of elements for an empty tree.";

            //Assert
            Assert.Equal(expectedMessage, e.Message);
        }

        [Fact]
        public void TestCanCreateEmptyBinarySearchTree()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            Assert.Null(testBinarySearchTree.Root);
        }

        [Fact]
        public void TestCanAddNodeToBinarySearchTree()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(22);
            Assert.Equal(22, testBinarySearchTree.Root.Value);
        }

        [Fact]
        public void TestCanAddMultipleNodesToBinarySearchTree()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(35);
            testBinarySearchTree.Add(33);
            testBinarySearchTree.Add(34);
            testBinarySearchTree.Add(36);

            Assert.Equal(34, testBinarySearchTree.Root.Left.Right.Value);
        }

        [Fact]
        public void TestContainsCorrectlyReturnsTrueForRootValue()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            testBinarySearchTree.Add(44);
            Assert.True(testBinarySearchTree.Contains(44));
        }

        [Fact]
        public void TestContainsCorrectlyReturnsFalseForEmptyBinarySearchTree()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            Assert.False(testBinarySearchTree.Contains(55));
        }

        [Fact]
        public void TestContainsCorrectlyReturnsTrueForLeafValue()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();
            
            testBinarySearchTree.Add(65);
            testBinarySearchTree.Add(63);
            testBinarySearchTree.Add(62);
            testBinarySearchTree.Add(64);
            testBinarySearchTree.Add(68);
            testBinarySearchTree.Add(67);
            testBinarySearchTree.Add(69);
            testBinarySearchTree.Add(70);

            Assert.True(testBinarySearchTree.Contains(70));
        }

        [Fact]
        public void TestContainsCorrectlyReturnsFalseForNotPresentValue()
        {
            BinarySearchTree testBinarySearchTree = new BinarySearchTree();

            testBinarySearchTree.Add(65);
            testBinarySearchTree.Add(63);
            testBinarySearchTree.Add(62);
            testBinarySearchTree.Add(64);
            testBinarySearchTree.Add(68);
            testBinarySearchTree.Add(67);
            testBinarySearchTree.Add(69);
            testBinarySearchTree.Add(70);

            Assert.False(testBinarySearchTree.Contains(71));
        }
    }
}
