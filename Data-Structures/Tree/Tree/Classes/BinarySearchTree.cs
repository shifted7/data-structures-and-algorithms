using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }
        Node Current;

        /// <summary>
        /// Adds value to the binary search tree, placing a new node in the tree by comparing the new value to the values on existing nodes. Smaller or equal values go left.
        /// </summary>
        /// <param name="value">The value to add to the tree.</param>
        /// <returns>The new node after being added to the tree.</returns>
        public Node Add(int value)
        {
            if (Root == null)
            {
                Node node = new Node(value);
                Root = node;
                Current = Root;
                return node;
            }
            if (value <= Current.Value)
            {
                if (Current.Left == null)
                {
                    Node node = new Node(value);
                    Current.Left = node;
                    Current = Root;
                    return node;
                }
                else
                {
                    Current = Current.Left;
                    return Add(value);
                }
            }
            else
            {
                if (Current.Right == null)
                {
                    Node node = new Node(value);
                    Current.Right = node;
                    Current = Root;
                    return node;
                }
                else
                {
                    Current = Current.Right;
                    return Add(value);
                }
            }
        }
        
        /// <summary>
        /// Checks whether the tree contains the given value. Returns false for an empty tree.
        /// </summary>
        /// <param name="value">The value to search the tree for.</param>
        /// <returns>True if the tree contains at least one instance of the value. False otherwise.</returns>
        public bool Contains(int value)
        {
            if (Root == null)
            {
                return false; // Case: Empty tree
            }
            if(Current.Value == value)
            {
                return true; // Case: value found
            }
            else if(value < Current.Value)
            {
                if(Current.Left != null)
                {
                    Current = Current.Left;
                    return Contains(value); // Case: value is less, and there is a left value still to check.
                }
                else
                {
                    return false; // Case: value is less, and there isn't a left value.
                }

            }
            else if(value > Current.Value)
            {
                if(Current.Right != null)
                {
                    Current = Current.Right;
                    return Contains(value); // Case: value is greater, and there is a right value still to check.
                }
                else
                {
                    return false; // Case: value is greater, and there isn't a right value.
                }

            }
            return false; // Required for completeness: non-existing case.
        }
    }
}
