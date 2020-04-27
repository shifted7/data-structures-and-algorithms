using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable
{
    public class HashTable
    {
        public int Size { get; }
        public object[] Contents { get; set; }
        public HashTable(int size)
        {
            Contents = new object[size];
            for(int i=0; i<size; i++)
            {
                LinkedList<Bucket> entries = new LinkedList<Bucket>();
                Contents[i] = entries;
            }
            Size = Contents.Length;
        }

        //TODO: add methods for add, get, contains, and hash
    }
}
