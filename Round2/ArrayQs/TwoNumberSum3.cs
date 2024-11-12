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


        public static int[] TwoNumberSumDictionary(int[] array, int targetSum)
        {
            // key:how many needed to make sum, value:item
            Dictionary<int, int> howManyToAdd = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (howManyToAdd.ContainsKey(item))
                {
                    return new int[] { item, howManyToAdd[item] };
                }
                howManyToAdd.Add(targetSum - item, item);
            }
            return new int[] { };
        }
    }
}
