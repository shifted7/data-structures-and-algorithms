using System;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = {89, 2354, 3546, 23, 10, -923, 823, -12}; //Define sample array for testing
            Console.Write($"Input array = ");
            foreach (int sampleValue in sampleArray)
            {
                Console.Write($"{sampleValue} "); //Display sample array
            }
            
            int[] reversedArray = ReverseArray(sampleArray); //Call method to create a new, reversed array
            Console.WriteLine(); 
            Console.Write($"Output array = ");
            foreach (int value in reversedArray)
            {
                Console.Write($"{value} "); //Display reversed array
            }

        }
        static int[] ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length]; //Create new empty array that's the same size as the original
            for(int i=0; i<array.Length; i++)
            {
                reversedArray[i] = array[array.Length-1 - i]; //Set reversed array values, ascending order, to original array values, descending order
            }
            return reversedArray;
        }
    }
}
