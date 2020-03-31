using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        MyStack FrontStack;
        MyStack RearStack;
        public Node Front { get; set; }
        public Node Rear { get; set; }
        public PseudoQueue()
        {
            FrontStack = new MyStack();
            RearStack = new MyStack();
            RearStack.Top = FrontStack.Top;
            Front = FrontStack.Top;
            Rear = RearStack.Top;
        }

        /// <summary>
        /// Adds a value to the rear of the queue.
        /// </summary>
        /// <param name="value">The value to add.</param>
        /// <returns>The node containing the added value.</returns>
        public Node Enqueue(int value)
        {
            if (IsEmpty())
            {
                RearStack.Push(value);
                Rear = RearStack.Top;
                FrontStack.Top = RearStack.Top;
                Front = FrontStack.Top;
            }
            else
            {
                RearStack.Push(value);
                RearStack.Top.Next.Next = RearStack.Top;
                RearStack.Top.Next = null;
                Rear = RearStack.Top;
            }
            return Rear;
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
            Node poppedNode = FrontStack.Pop();
            Front = FrontStack.Top;
            return poppedNode;
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

        public bool IsEmpty()
        {
            return Front == null;
        }
    }
}
