using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q3SortedSquared
    {
        // Time complexity - O(n)
        // Space complexity - O(1)
        public int[] SortedSquaredArray(int[] array)
        {
            int left = 0, right = array.Length - 1;
            int[] result = new int[array.Length];
            int resultIndex = result.Length - 1;
            while (resultIndex >= 0)
            {
                if (array[left] * array[left] <= array[right] * array[right])
                {
                    result[resultIndex--] = array[right] * array[right];
                    --right;
                }
                else if (array[left] * array[left] > array[right] * array[right])
                {
                    result[resultIndex--] = array[left] * array[left];
                    ++left;
                }
            }
            return result;
        }
    }
}