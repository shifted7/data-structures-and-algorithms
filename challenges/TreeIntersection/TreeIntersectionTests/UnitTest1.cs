using System;
using Xunit;
using TreeIntersection;
using System.Collections.Generic;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanFindIntersectionOfTreesWithOneNode()
        {
            BinaryTree testTreeA = new BinaryTree();
            testTreeA.Root = new Node(5);
            BinaryTree testTreeB = new BinaryTree();
            testTreeB.Root = new Node(5);

            List<int> result = Program.TreeIntersection(testTreeA, testTreeB);

            Assert.Contains(5, result);
        }

        [Fact]
        public void TestTreeIntersectionReturnsEmptyListForNoMatchingValues()
        {
            BinaryTree testTreeA = new BinaryTree();
            testTreeA.Root = new Node(8);
            testTreeA.Root.Left = new Node(12);
            BinaryTree testTreeB = new BinaryTree();
            testTreeB.Root = new Node(10);
            testTreeB.Root.Right = new Node(15);

            List<int> result = Program.TreeIntersection(testTreeA, testTreeB);

            Assert.Empty(result);
        }

        [Fact]
        public void TestTreeIntersectionReturnsMatchingValuesForMultilevelTrees()
        {
            BinaryTree testTreeA = new BinaryTree();
            testTreeA.Root = new Node(16);
            testTreeA.Root.Left = new Node(20);
            testTreeA.Root.Right = new Node(28);
            BinaryTree testTreeB = new BinaryTree();
            testTreeB.Root = new Node(16);
            testTreeB.Root.Right = new Node(20);
            testTreeB.Root.Right.Right = new Node(29);

            List<int> result = Program.TreeIntersection(testTreeA, testTreeB);
            List<int> expectedResult = new List<int>();
            expectedResult.Add(16);
            expectedResult.Add(20);

            Assert.Equal(expectedResult, result);
        }
    }
}
