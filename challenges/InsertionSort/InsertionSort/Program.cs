using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static void InsertionSort(int[] array)
        {
            int j;
            int temp;
            for(int i=1; i<array.Length; i++)
            {
                j = i - 1;
                temp = array[i];
                while(j>=0 && temp < array[j])
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
        }
    }
}
