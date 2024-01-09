using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class MajorityElementLogic
    {
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
    }
}