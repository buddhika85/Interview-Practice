using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q20BinarySearch
    {
        public static int BinarySearch(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;
            while (left <= right)
            {
                var mid = (left + right) / 2;
                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else // if (array[mid] > target)
                    right = mid - 1;
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] array, int target)
        {
            return BinarySearchRecursiveHelper(array, target, 0, array.Length - 1);
        }

        private static int BinarySearchRecursiveHelper(int[] array, int target, int left, int right)
        {
            if (left > right)
            return -1;                      // terminate recursion

            var mid = (left + right) / 2;
            if (array[mid] == target)
                return mid;

            else if (array[mid] < target)
                left = mid + 1;
            else // if (array[mid] > target)
                right = mid - 1;
            
            return BinarySearchRecursiveHelper(array, target, left, right);
        }
    }
}