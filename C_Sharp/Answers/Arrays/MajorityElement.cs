using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class MajorityElementLogic
    {
        // Time - O(n)^2
        // Space - O(1)
        public static int MajorityElement(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var count = 0;
                for (var j = 0; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                        ++count;
                }
                if (count > array.Length / 2)
                    return array[i];
            }
            return -1;
        }

        // Time - O(n)
        // Space - O(1) 
        public static int MajorityElementOptimal(int[] array)
        {
            var count = 1;
            var majorityElement = array[0];            // consider 0th element as the majority element
            var i = 1;
            while(i < array.Length)
            {
                if (count == 0)
                    majorityElement = array[i];

                if (array[i] == majorityElement)                
                    ++count;
                else                
                    --count;                     
                ++i;
            }
            return majorityElement;
        }


        public static int MajorityElementOptimalTwo(int[] array)
        {
            var count = 0;
            int? majorityElement = null;            // consider 0th element as the majority element
            foreach (var item in array)
            {
                if (count == 0)
                    majorityElement = item;
                if (item == majorityElement)
                    ++count;
                else
                    --count;
            }
            return majorityElement.Value;
        }
    }
}