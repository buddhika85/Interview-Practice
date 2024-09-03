using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q21InsertionSort
    {
        // Time - O(n)^2, Space - O(1) in space sorting
        public static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var current = array[i];
                var j = i - 1;
                var proceed = true;
                while (j >= 0 && proceed)
                {
                    if (array[j] > current)
                    {
                        // move to right
                        array[j + 1] = array[j];
                        --j;
                    }
                    else
                        proceed = false;
                }
                if (array[i] != current)
                {
                    array[j + 1] = current;
                }
            }
            return array;
        }
    }
}