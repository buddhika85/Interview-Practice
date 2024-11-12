using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_2.ArrayQs
{
    internal class TwoNumberSum3
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            var left = 0;
            var right = array.Length - 1;
            Array.Sort(array);
            while (left < right)
            {
                if (array[left] + array[right] == targetSum)
                    return new int[] { array[left], array[right] };

                if (array[left] + array[right] < targetSum)
                    left++;
                else 
                    right--;
            }
            return new int[] { };
        }
    }
}
