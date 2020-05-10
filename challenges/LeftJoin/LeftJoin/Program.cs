using System;
using System.Collections.Generic;

namespace LeftJoin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static List<string[]> LeftJoin(HashTable hashTableA, HashTable hashTableB)
        {
            List<string[]> results = new List<string[]>();
            foreach(var bucket in hashTableA.Contents)
            {
                if (bucket != null)
                {
                    foreach(var kvPair in bucket)
                    {
                        string[] result = new string[] { kvPair.Key, kvPair.Value, null };
                        results.Add(result);
                        if (hashTableB.Contains(kvPair.Key))
                        {
                            result[2] = hashTableB.Get(kvPair.Key);
                        }
                    }

                }
            }
            return results;
        }
    }
}
