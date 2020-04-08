using System;
using Xunit;

namespace FizzBuzzTree
{
    public class UnitTest1
    {
        [Fact]
        public void TestCanCreateEmptyNode()
        {
            Node testNode = new Node();
            Assert.Null(testNode.Value);
        }

        [Fact]
        public void TestCanCreateEmptyTree()
        {
            Tree testTree = new Tree();
            Assert.Null(testTree.Root);
        }

        [Fact]
        public void TestFizzBuzzTreeCorrectlyChangesSingleNodeTree()
        {

        }
    }
}
