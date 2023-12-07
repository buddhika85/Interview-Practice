using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace C_Sharp.Answers
{
    public class Q23BubbleSort
    {
        // Time - O(n)^2 - uses outer and inner loop, Space = O(1) in place sorting
        public static int[] BubbleSort(int[] array)
        {
            for (var round = 0; round < array.Length - 1; round++)
            {
                for (var i = 0; i < array.Length - 1 - round; i++)
                {
                    if (array[i] > array[i + 1])
                        Swap(array, i, i + 1);
                }
            }
            return array;
        }

        private static void Swap(int[] array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}