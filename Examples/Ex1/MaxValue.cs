using System;

namespace Algorithms.Examples.Ex1
{
    public class MaxValue
    {
        //Returns the max value from an array
        public static int Max(int[] myArray)
        {
            var temp = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (temp < myArray[i])
                    temp = myArray[i];
            }
            return temp;
        }
    }
}
