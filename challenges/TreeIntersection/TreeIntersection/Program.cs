using System;
using System.Collections.Generic;

namespace TreeIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// For two binary trees, returns a list of values that appear in both trees.
        /// </summary>
        /// <param name="treeA">The first binary tree to traverse for all values</param>
        /// <param name="treeB">The second binary tree to traverse and check against treeA values</param>
        /// <returns>The list of values that appears in both trees, or an empty list if no matches are found.</returns>
        public static List<int> TreeIntersection(BinaryTree treeA, BinaryTree treeB)
        {
            HashMap treeAValues = new HashMap(128);
            TraversePreOrderAddToHashMap(treeA, treeAValues);
            List<int> matchedValues = new List<int>();
            TraversePreOrderMatchValuesHashMap(treeB, treeAValues, matchedValues);
            return matchedValues;
        }

        /// <summary>
        /// Traverses a binary tree and adds all the values it encounters to the hash map.
        /// </summary>
        /// <param name="tree">The tree to traverse, pre-order.</param>
        /// <param name="values">The hashmap containing all the values found in the tree.</param>
        static void TraversePreOrderAddToHashMap(BinaryTree tree, HashMap values)
        {
            if (tree.Root != null)
            {
                values.Add(tree.Root.Value);
                
                BinaryTree leftSubTree = new BinaryTree();
                leftSubTree.Root = tree.Root.Left;
                TraversePreOrderAddToHashMap(leftSubTree, values);

                BinaryTree rightSubTree = new BinaryTree();
                rightSubTree.Root = tree.Root.Right;
                TraversePreOrderAddToHashMap(rightSubTree, values);
            }
        }

        /// <summary>
        /// Traverses a binary tree and adds to a list of the matched values any values that appear in both the tree and the checkValues hash map.
        /// </summary>
        /// <param name="tree">The tree to traverse, pre-order.</param>
        /// <param name="checkValues">The values to check for in the tree. Values are removed from the hash map when they are found for the first time.</param>
        /// <param name="matchedValues">The list to add to, if a match is found.</param>
        static void TraversePreOrderMatchValuesHashMap(BinaryTree tree, HashMap checkValues, List<int> matchedValues)
        {
            if(tree.Root != null)
            {
                if (checkValues.Contains(tree.Root.Value))
                {
                    checkValues.Remove(tree.Root.Value);
                    matchedValues.Add(tree.Root.Value);
                }
                BinaryTree leftSubTree = new BinaryTree();
                leftSubTree.Root = tree.Root.Left;
                TraversePreOrderMatchValuesHashMap(leftSubTree, checkValues, matchedValues);

                BinaryTree rightSubTree = new BinaryTree();
                rightSubTree.Root = tree.Root.Right;
                TraversePreOrderMatchValuesHashMap(rightSubTree, checkValues, matchedValues);
            }
        }
    }
}
