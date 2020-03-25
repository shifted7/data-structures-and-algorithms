﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkList
    {
        public Node Head { get; set; }
        private Node Current { get; set; }

        /// <summary>
        /// Inserts a new node with the given value at the beginning of the linked list
        /// </summary>
        /// <param name="value">The value to put into the new node</param>
        public void Insert(int value)
        {
            try
            { 
                Node newNode = new Node();
                newNode.Value = value;
                newNode.Next = Head; // Sets the list's head as the next value first so as to not lose it during garbage collection
                Head = newNode;
            
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Overflow Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception: ");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Checks whether the value exists in the linked list
        /// </summary>
        /// <param name="value">The value to check for</param>
        /// <returns>True or false</returns>
        public bool Includes(int value)
        {
            try
            {
                Current = Head;
                while (Current != null) // Will loop until it finds the value or reaches the end of the linked list without finding it
                {
                    if (Current.Value == value)
                    {
                        return true;
                    }
                    Current = Current.Next;
                }

            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception: ");
                Console.WriteLine(e.Message);
            }
            return false; // Returns false if value not found or exception thrown
        }

        /// <summary>
        /// Returns a string containing all the values in the linked list
        /// </summary>
        /// <returns>String with each value from the list, contained in curly brackets with arrows between each</returns>
        public override string ToString()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                Current = Head;
                while (Current != null) // Will loop through every node in the list
                {
                    sb.Append("{");
                    sb.Append($"{Current.Value}");
                    sb.Append("} -> ");
                    Current = Current.Next;
                }
                sb.Append("NULL"); // Adds NULL as the last value
                return sb.ToString();
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Overflow Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Null Reference Exception: ");
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception:");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General Exception: ");
                Console.WriteLine(e.Message);
            }
            return ""; // Returns empty string if exception thrown
        }

        /// <summary>
        /// Adds a node with the given value to the end of the linked list
        /// </summary>
        /// <param name="value">The value to put at the end of the linked list</param>
        public void Append(int value)
        {
            Current = Head;
            Node newNode = new Node();
            newNode.Value = value;
            if (Head == null) // If the linked list is empty, add the new node as the head
            {
                Head = newNode;
                Current = newNode;
            }
            else
            {
                while(Current.Next != null) // Loops until the end of the list, and Current is the last node before appending
                {
                    Current = Current.Next;
                }
                Current.Next = newNode;
                Current = Head;
            }
        }

        public void InsertBefore(int index, int value)
        {
            Current = Head;
            Node newNode = new Node();
            newNode.Value = value;
            if (Head == null && index==0)
            {
                Head = newNode;
            }
            else
            {
                Node previousNode = null;
                int indexSteps = index;
                while (indexSteps > 0 && Current.Next != null)
                {
                    if(indexSteps == 1)
                    {
                        previousNode = Current;
                    }
                    Current = Current.Next;
                    indexSteps--;
                }
                if(indexSteps == 0)
                {
                    newNode.Next = Current;
                    previousNode.Next = newNode;
                }
            }
            Current = Head;
        }
        
        /// <summary>
        /// Returns the value of the node k nodes ahead of the last node of the linked list
        /// </summary>
        /// <param name="k">A positive integer value for the number of nodes from the end of the linked list</param>
        /// <returns>Integer value at the specified node</returns>
        public int getValueKthFromEnd(int k)
        {
            Current = Head;
            if(Current == null)
            {
                throw new Exception("Could not return value from empty linked list");
            }
            int lengthCounter = 1;
            while(Current.Next != null) // Loop through list to get the length
            {
                Current = Current.Next;
                lengthCounter++;
            }
            if (k > lengthCounter-1)
            {
                throw new Exception("k exceeds range of linked list");
            }
            if(k < 0)
            {
                throw new Exception("k must be positive");
            }
            int nextCounter = lengthCounter - 1 - k; // Set the number of times to jump, starting at beginning of list, which is equivalent to k from the end
            Current = Head;
            while (nextCounter > 0)
            {
                Current = Current.Next;
                nextCounter--;
            }
            return Current.Value;
        }
    }
}
