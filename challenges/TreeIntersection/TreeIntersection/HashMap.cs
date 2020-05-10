using System.Collections.Generic;

namespace TreeIntersection
{
    public class HashMap
    {
        public int Size { get; }
        public LinkedList<int>[] Contents { get; set; }
        public HashMap(int size)
        {
            Contents = new LinkedList<int>[size];
            Size = Contents.Length;
        }

        public int Hash(int value)
        {
            return value % Size; // VERY BAD HASH FUNCTION but good enough for this code challenge
        }

        public int Add(int value)
        {
            int hash = Hash(value);
            var bucket = Contents[hash]; // The bucket we're planning to put our value
            if (bucket == null) // If the bucket doesn't have a linkedlist yet, create one
            {
                bucket = new LinkedList<int>();
                Contents[hash] = bucket;
            }
            bucket.AddFirst(value);
            return hash;
        }
        
        /// <summary>
        /// Checks whether the given value is in the hash table.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>True if the value is in the hash set, false otherwise.</returns>
        public bool Contains(int value)
        {
            int hash = Hash(value);
            if (Contents[hash] != null)
            {
                foreach (var val in Contents[hash])
                {
                    if (val == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int Remove(int value)
        {
            int hash = Hash(value);
            var bucket = Contents[hash]; // The bucket we're planning to put our value
            if (bucket != null) // If the bucket doesn't have a linkedlist yet, create one
            {
                Contents[hash] = null;
            }
            return value;
        }
    }
}