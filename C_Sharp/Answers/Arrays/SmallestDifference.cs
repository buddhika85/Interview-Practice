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
            var difference = int.MaxValue;            // still unknown

            while (arrayOnePointer < arrayOne.Length && arrayTwoPointer < arrayTwo.Length)
            {
                var numOne = arrayOne[arrayOnePointer];
                var numTwo = arrayTwo[arrayTwoPointer];
                var currDifference = Math.Abs(numOne - numTwo);
                // update if currDifference closer to zero
                if (currDifference < difference)
                {
                    difference = currDifference;
                    result[0] = numOne;
                    result[1] = numTwo;
                }

                if (difference == 0)
                    return result;

                // take smallest and move its array index forward
                if (numOne < numTwo)
                    ++arrayOnePointer;
                else
                    ++arrayTwoPointer;
            }
            return result;
        }
    }
}