using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 4, 8, 15, 16, 23, 42 };
            int key = 15;
            BinarySearch(sortedArray, key);
        }
        
        /// <summary>
        /// Takes in a sorted array and a key value, and uses binary search to find the index of the item with that value.
        /// </summary>
        /// <param name="sortedArray">A sorted array of integers</param>
        /// <param name="key">The value we want to match to an index in the array</param>
        /// <returns>The index where the key value is found. Returns -1 if key is not found.</returns>
        public static int BinarySearch(int[] sortedArray, int key)
        {
            int lowerLimit = 0;
            int upperLimit = sortedArray.Length;
            int middleIndex = (upperLimit - lowerLimit) / 2;
            while (lowerLimit < upperLimit) {
                if (sortedArray[middleIndex] < key)
                {
                    lowerLimit = middleIndex + 1;
                }
                else if(sortedArray[middleIndex] > key)
                {
                    upperLimit = middleIndex - 1;
                }
                else
                {
                    return middleIndex;
                }
                middleIndex = (upperLimit - lowerLimit) / 2;
            }
            return -1;
        }

    }
}
