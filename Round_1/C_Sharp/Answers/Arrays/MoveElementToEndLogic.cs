using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class MoveElementToEndLogic
    {
        // O(n)
        public static List<int> MoveElementToEnd(List<int> array, int toMove)
        {
            var left = 0;
            var right = array.Count - 1;
            while(left < right)
            {
                if (array[left] == toMove && array[right] != toMove)
                {
                    Swap(array, left, right);
                    ++left;
                    --right;
                }
                else if (array[left] == toMove && array[right] == toMove)
                    --right;
                else
                    ++left;
            }
            return array;
        }

        private static void Swap(List<int> array, int left, int right)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}