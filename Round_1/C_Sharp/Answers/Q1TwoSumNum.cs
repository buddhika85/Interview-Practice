using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q1TwoSumNum
    {
        // input = array [3,5-4,8,11,1,-1,0] is distinct, 10
        // output = [-1,11]
        public int[] TwoNumberSum(int[] array, int targetSum)
        {
            Dictionary<int, int> itemsDict = new();     // key = item, value = targetSum - value
            foreach (var item in array)
            {
                var valueNeeded = targetSum - item;
                if (itemsDict.ContainsKey(valueNeeded))
                    return new[] { valueNeeded, item };
                itemsDict.Add(item, item);

            }

            return new int[] { };
        }

        public int[] TwoNumberSumV2(int[] array, int targetSum)
        {
            Sort(array);
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                if (array[left] + array[right] < targetSum)
                {
                    // need more
                    left++;
                }
                else if (array[left] + array[right] > targetSum)
                {
                    // need less
                    right--;
                }
                else   // (array[left] + array[right] == targetSum)
                {
                    return new[] { array[left], array[right] };
                }
            }
            return new int[] { };
        }


        public void Sort(int[] array)
        {
            Array.Sort(array);
        }
    }
}