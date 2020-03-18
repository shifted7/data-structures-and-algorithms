using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int[] InsertShiftArray(int[] array, int value)
        {
            int[] shiftedArray = new int[array.Length + 1]; // Creates the new, shifted array where we will be adding our value
            int middleIndex = (array.Length+1) / 2;
            for(int i=0; i < shiftedArray.Length; i++)
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
