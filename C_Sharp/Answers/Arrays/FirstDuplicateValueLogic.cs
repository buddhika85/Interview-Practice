using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class FirstDuplicateValueLogic
    {
        public static int FirstDuplicateValue(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                var seen = new Dictionary<int, int> { { array[0], 1 } };
                for (int i = 1; i < array.Length; i++)
                {
                    if (seen.ContainsKey(array[i]))
                        return array[i];
                    seen.Add(array[i], 1);
                }
            }
            return -1;
        }

    }
}