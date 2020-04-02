using System;
using System.Collections.Generic;
using System.Text;

namespace MultiBracketValidation.Classes
{
    public class Stack
    {
        public Node Top { get; set; }
        Node Current { get; set; }
        
        /// <summary>
        /// Adds the inputted string to the top of the stack in a new node, and returns the new node
        /// </summary>
        /// <param name="input">A string to add to the stack.</param>
        /// <returns>The newly added node that contains the new string</returns>
        public Node Push(string input)
        {
            Current = Top;
            Node pushedNode = new Node(input);
            pushedNode.Next = Top;
            Top = pushedNode;
            Current = Top;
            return pushedNode;
        }

        /// <summary>
        /// Removes the top node from the stack, and returns it.
        /// </summary>
        /// <returns>The popped node.</returns>
        public Node Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot pop from the top of an empty stack.");
            }
            Node poppedNode = Top;
            Top = Top.Next;
            poppedNode.Next = null; // Break connection back to stack
            return poppedNode;
        }

        /// <summary>
        /// Checks the top value on the stack, or returns null if the stack is empty.
        /// </summary>
        /// <returns>The top value, or null if there is no top value.</returns>
        public string Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return Top.Char;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
