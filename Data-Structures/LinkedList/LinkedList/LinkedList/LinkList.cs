using System;
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
    }
}
