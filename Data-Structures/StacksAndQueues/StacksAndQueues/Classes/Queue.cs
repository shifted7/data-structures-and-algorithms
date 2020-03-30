using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }

        /// <summary>
        /// Adds a value to the rear of the queue.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>The node containing the added value.</returns>
        public Node Enqueue(int value)
        {
            Node node = new Node(value);
            if (IsEmpty())
            {
                Front = node;
                Rear = node;
            }
            else
            {
                Rear.Next = node;
                Rear = node;
            }
            return node;
        }

        /// <summary>
        /// Removes the node at the front of the queue, and returns it or throws an exception if the queue is empty.
        /// </summary>
        /// <returns>The removed node.</returns>
        public Node Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot dequeue because the queue is empty.");
            }
            Node dequeuedNode = Front;
            Front = Front.Next;
            dequeuedNode.Next = null;
            return dequeuedNode;
        }

        /// <summary>
        /// Returns the value at the front of the queue, throwing an exception if the queue is empty.
        /// </summary>
        /// <returns>The value at the front of the queue.</returns>
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Cannot peek because the queue is empty.");
            }
            return Front.Value;
        }

        /// <summary>
        /// Returns whether the queue is empty by checking the front node.
        /// </summary>
        /// <returns>True if empty, false otherwise.</returns>
        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}
