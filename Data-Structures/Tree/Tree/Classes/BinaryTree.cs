using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public Node Root { get; set; }
        Node Current;
        
        /// <summary>
        /// Returns a list of all the values in the tree, pre-ordered (Root, then left, then right). Throws exception for empty tree.
        /// </summary>
        /// <param name="root">The root node of the tree for which to return all values.</param>
        /// <returns>List of pre-ordered values.</returns>
        public List<int> PreOrder(Node root)
        {
            if (root == null)
            {
                throw new Exception("Cannot return the pre-ordered collection of elements for an empty tree.");
            }
            List<int> result = new List<int>();
            result.Add(root.Value);
            if (root.Left != null)
            {
                result.AddRange(PreOrder(root.Left));
            }
            if (root.Right != null)
            {
                result.AddRange(PreOrder(root.Right));
            }
            return result;
        }

        /// <summary>
        /// Returns a list of all the values in the tree, in order (Left, then root, then right). Throws exception for empty tree.
        /// </summary>
        /// <param name="root">The root node of the tree for which to return all values.</param>
        /// <returns>List of in-order values.</returns>
        public List<int> InOrder(Node root)
        {
            if (root == null)
            {
                throw new Exception("Cannot return the in-order collection of elements for an empty tree.");
            }
            List<int> result = new List<int>();
            if (root.Left != null)
            {
                result.AddRange(InOrder(root.Left));
            }

            result.Add(root.Value);

            if (root.Right != null)
            {
                result.AddRange(InOrder(root.Right));
            }
            return result;
        }

        /// <summary>
        /// Returns a list of all the values in the tree, post-ordered (Left, then right, then root). Throws exception for empty tree.
        /// </summary>
        /// <param name="root">The root node of the tree for which to return all values.</param>
        /// <returns>List of pre-ordered values.</returns>
        public List<int> PostOrder(Node root)
        {
            if (root == null)
            {
                throw new Exception("Cannot return the post-ordered collection of elements for an empty tree.");
            }
            List<int> result = new List<int>();
            if (root.Left != null)
            {
                result.AddRange(PostOrder(root.Left));
            }
            if (root.Right != null)
            {
                result.AddRange(PostOrder(root.Right));
            }
            
            result.Add(root.Value);
            return result;
        }

        public List<int> GetValuesBreadthFirst()
        {
            if (Root == null)
            {
                throw new Exception("Cannot get values of an empty tree.");
            }
            List<int> values = new List<int>();
            NodeQueue breadthQueue = new NodeQueue();
            breadthQueue.Enqueue(Root);
            Node front;
            while (breadthQueue.Front != null)
            {
                front = breadthQueue.Dequeue();
                values.Add(front.Value);
                if (front.Left != null)
                {
                    breadthQueue.Enqueue(front.Left);
                }
                if (front.Left != null)
                {
                    breadthQueue.Enqueue(front.Right);
                }
            }
            return values;

        }
    }
}
