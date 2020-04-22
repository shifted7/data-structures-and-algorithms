using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void MergeSort(int[] array)
        {
            int n = array.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] left = array[0..mid];
                int[] right = array[mid..n];
                MergeSort(left);
                MergeSort(right);
                Merge(left, right, array);
            }
        }

        public static void Merge(int[] left, int[] right, int[] array)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }
            
            if (i == left.Length) // Case: reached end of left list, no more items to compare. Just add remaining items of right list to main list
            {
                List<int> arrayList = array[0..i].ToList(); // convert values so far of main array to list to allow concatenation
                List<int> rightRemainingList = right[j..right.Length].ToList(); // List of remaining items in the array after (and including) index j
                arrayList.AddRange(rightRemainingList); // Add the remaining items in the right list to the end of the main list.
                array = arrayList.ToArray();
            }
            else // Case: reached end of right list, no more items to compare. Just add remaining items of left list to main list
            {
                List<int> arrayList = array[0..j].ToList(); // convert values so far of main array to list to allow concatenation
                List<int> leftRemainingList = left[i..left.Length].ToList(); // List of remaining items in the array after (and including) index i
                arrayList.AddRange(leftRemainingList); // Add the remaining items in the left list to the end of the main list.
                array = arrayList.ToArray();
            }
            
        }
    }
}
