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
    }
}
