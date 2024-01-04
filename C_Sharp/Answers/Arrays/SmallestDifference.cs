using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class SmallestDifferenceOfArrays
    {
        public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            var arrayOnePointer = 0;
            var arrayTwoPointer = 0;
            var result = new int[2];
            var difference = -1;            // still unknown


            while (arrayOnePointer < arrayOne.Length && arrayTwoPointer < arrayTwo.Length)
            {
                var currDifference = Math.Abs(arrayOne[arrayOnePointer] - arrayTwo[arrayTwoPointer]);
                // update if currDifference closer to zero
                if (difference == -1 || currDifference < difference)
                {
                    difference = currDifference;
                    result[0] = arrayOne[arrayOnePointer];
                    result[1] = arrayTwo[arrayTwoPointer];
                }

                if (difference == 0)
                    return result;

                // take smallest and move its array index forward
                if (arrayOne[arrayOnePointer] < arrayTwo[arrayTwoPointer])
                {
                    if (arrayOnePointer < arrayOne.Length - 1)
                        ++arrayOnePointer;
                    else if (arrayTwoPointer < arrayTwo.Length - 1)
                        ++arrayTwoPointer;
                    else 
                        return result;
                }
                else
                {
                    if (arrayTwoPointer < arrayTwo.Length - 1)
                        ++arrayTwoPointer;
                    else if (arrayOnePointer < arrayOne.Length - 1)
                        ++arrayOnePointer;
                    else 
                        return result;
                }
            }
            return result;
        }

    }
}