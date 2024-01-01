using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class Monotonic
    {
        public static bool IsMonotonic(int[] array) {
            if (array.Length <= 1)
                return true;
            bool? isIncreasing = null;      // do not know
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (isIncreasing == null)
                    isIncreasing = array[i] == array[i + 1] ? null : 
                        array[i] < array[i + 1];
                else if (isIncreasing.Value && array[i] > array[i + 1])
                    return false;           // we expected to increase, but did not
                else if (!isIncreasing.Value && array[i] < array[i + 1])
                    return false;           // we expected to decrease, but did not
            }
            return isIncreasing != null;
        }
    }
}