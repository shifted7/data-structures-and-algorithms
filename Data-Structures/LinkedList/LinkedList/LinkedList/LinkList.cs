using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class LinkList
    {
        public Node Head { get; set; }
        public Node Current { get; set; }

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

        public void InsertBefore(int searchValue, int newValue)
        {
            Current = Head;
            if(Head == null) // Case: linked list is empty
            {
                throw new Exception("Search value not found in empty linked list.");
            }
            if(Current.Value == searchValue) // Case: first value is search value
            {
                Node newNode = new Node();
                newNode.Value = newValue;
                newNode.Next = Current;
                Head = newNode;
                return;
            }
            while(Current.Next != null)
            {
                if(Current.Next.Value == searchValue)
                {
                    Node newNode = new Node();
                    newNode.Value = newValue;
                    newNode.Next = Current.Next; // Connect new node to the next node, so we don't lose the rest of the list to GC
                    Current.Next = newNode; // Connect current node to the new node
                    break;
                }
                Current = Current.Next;
            }
            if(Current.Next == null)
            {
                throw new Exception("Search value not found.");
            }
        }

        /// <summary>
        /// Inserts a new value into a linked list in position just after a search value, or throws exception if search value not found.
        /// </summary>
        /// <param name="searchValue">The value to look for in the list</param>
        /// <param name="newValue">The new value to insert into the linked list after the search value</param>
        public void InsertAfter(int searchValue, int newValue)
        {
            Current = Head;
            while(Current != null)
            {
                if (Current.Value == searchValue)
                {
                    Node newNode = new Node();
                    newNode.Value = newValue;
                    newNode.Next = Current.Next; // Connect new node to the next node, so we don't lose the rest of the list to GC
                    Current.Next = newNode; // Connect current node to the new node
                    break;
                }
                Current = Current.Next;
            }    
            if(Current == null) // throw exception if we reached the end of the list without finding the search value
            {
                throw new Exception("Search value not found.");
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
