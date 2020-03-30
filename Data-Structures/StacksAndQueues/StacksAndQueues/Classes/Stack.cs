using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        
        /// <summary>
        /// Adds a new node to the top of the stack containing the given value.
        /// </summary>
        /// <param name="value">The value to add to the stack</param>
        /// <returns>The added node</returns>
        public Node Push(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            Top = node;
            return node;
        }
        
        /// <summary>
        /// Removes the top node from the stack
        /// </summary>
        /// <returns>The removed node</returns>
        public Node Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot pop because the stack is empty.");
            }
            Node poppedNode = Top;
            Top = Top.Next;
            return poppedNode;
        }

        /// <summary>
        /// Returns the top value of the stack, throwing an exception if the stack is empty.
        /// </summary>
        /// <returns>The value of the top node of the stack</returns>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot peek because the stack is empty.");
            }
            return Top.Value;
        }

        /// <summary>
        /// Checks whether the stack is empty by checking for a top node
        /// </summary>
        /// <returns>True if empty, else false</returns>
        public bool IsEmpty()
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
