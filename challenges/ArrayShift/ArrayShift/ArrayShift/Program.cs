using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 7;
            int[] oddArray = { 2, 4, 6, 8, 10 };
            int[] shiftedArray = ShiftArray(oddArray, value);
            foreach (int number in shiftedArray)
            {
                Console.Write(number);
            }

            value = 5;
            int[] evenArray = { 2, 4, 6, 8 };
            shiftedArray = ShiftArray(evenArray, value);
            Console.WriteLine();
            foreach(int number in shiftedArray)
            {
                Console.Write(number);
            }
        }

        /// <summary>
        /// This method takes in an array and a value, and returns a copy of that array with the value inserted at the middle index and subsequent values shifted toward the end of the array. Middle index is considered to be the current middle index + 1 for odd array lengths.
        /// </summary>
        /// <param name="array">The array to insert the value at the middle index of.</param>
        /// <param name="value">The value to insert at the array's middle index.</param>
        /// <returns>A new array, similar to the old, but with the value inserted at the middle index.</returns>
        static int[] ShiftArray(int[] array, int value)
        {
            int[] shiftedArray = new int[array.Length + 1];
            int middleIndex = (array.Length+1) / 2; // Index of the middle of the array. Uses integer division truncation to give correct index for an array whether it is even or odd.
            for(int i=0; i < shiftedArray.Length; i++) // Fill in the values for the shifted array, depending on where each index is in relation to the middle index
            {
                if (i == middleIndex)
                {
                    shiftedArray[i] = value;
                } else if(i < middleIndex)
                {
                    shiftedArray[i] = array[i];
                } else if(i > middleIndex)
                {
                    shiftedArray[i] = array[i - 1];
                }
            }
            return shiftedArray;
        }
    }
}
