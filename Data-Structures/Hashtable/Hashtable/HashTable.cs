using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class HashTable
    {
        public int Size { get; }
        public LinkedList<KeyValuePair<string, string>>[] Contents { get; set; }
        public HashTable(int size)
        {
            Contents = new LinkedList<KeyValuePair<string, string>>[size];
            Size = Contents.Length;
        }

        /// <summary>
        /// Creates a hash value for a given key by passing that key through an algorithm, which determines where the key is stored in the hash table.
        /// </summary>
        /// <param name="key">The key to match to a hash value.</param>
        /// <returns>The hash value for the given key.</returns>
        public int Hash(string key)
        {
            int positionLoopCount = 8; // As part of the hash, multiply by a count that decreases from this number to 1, then loops. This prevents words with the same letters in different positions from having the same hash.
            int sum = 0; // Sum of values for each character in the string after position factor
            int prime = 31; // As part of hash, multiply by this prime number to minimize patterns after array size molulo operation
            int asciiCharValue;
            int positionFactor;
            for(int i = 0; i<key.Length; i++)
            {
                asciiCharValue = (int)key[i];
                positionFactor = positionLoopCount - (i % (positionLoopCount - 1)); // Counts down from 8 to 1 while traversing the string, then loops back up to 8
                sum += asciiCharValue * positionFactor;
            }
            return sum * prime % Size;
        }
        
        /// <summary>
        /// Takes a key and a value, and stores them in the hash table.
        /// </summary>
        /// <param name="key">The key, or label/name to refer to the value</param>
        /// <param name="value">The actual information that corresponds to the key</param>
        /// <returns>The hash value index of the hash table where the key and value have been stored.</returns>
        public int Add(string key, string value)
        {
            int hash = Hash(key);
            KeyValuePair<string, string> keyValue = new KeyValuePair<string, string>(key, value);
            var bucket = Contents[hash]; // The bucket we're planning to put our value
            if (bucket == null) // If the bucket doesn't have a linkedlist yet, create one
            {
                bucket = new LinkedList<KeyValuePair<string, string>>();
                Contents[hash] = bucket;
            }
            bucket.AddFirst(keyValue);
            return hash;
        }
        
        /// <summary>
        /// Provides the value stored in the hash table for a given key.
        /// </summary>
        /// <param name="key">The key to search for in the hash table.</param>
        /// <returns>The value that corresponds to the key.</returns>
        public string Get(string key)
        {
            int hash = Hash(key);
            if (Contents[hash] == null)
            {
                return null;
            }
            foreach(var kvPair in Contents[hash])
            {
                if(kvPair.Key == key)
                {
                    return kvPair.Value;
                }
            }
            return null;
        }

        /// <summary>
        /// Checks whether the given key is in the hash table.
        /// </summary>
        /// <param name="key">The key to search for.</param>
        /// <returns>True if the key is in the table, false otherwise.</returns>
        public bool Contains(string key)
        {
            int hash = Hash(key);
            if (Contents[hash] != null)
            {
                foreach(var kvPair in Contents[hash])
                {
                    if(kvPair.Key == key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
