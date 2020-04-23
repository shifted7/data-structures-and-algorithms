using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void QuickSort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int position = Partition(array, leftIndex, rightIndex);
                QuickSort(array, leftIndex, position - 1);
                QuickSort(array, position + 1, rightIndex);
            }
        }

        public static int Partition(int[] array, int leftIndex, int rightIndex)
        {
            int pivot = array[rightIndex];
            int lowIndex = leftIndex - 1;
            for(int i = leftIndex; i<rightIndex; i++)
            {
                if(array[i] <= pivot)
                {
                    lowIndex++;
                    Swap(array, i, lowIndex);
                }
            }
            Swap(array, rightIndex, lowIndex + 1);
            return lowIndex+1;
        }

        public static void Swap(int[] array, int i, int lowIndex)
        {
            int temp = array[i];
            array[i] = array[lowIndex];
            array[lowIndex] = temp;
        }
    }
}
