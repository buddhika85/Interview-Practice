using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_2.ArrayQs
{
    internal class MonotonicArrayDemo
    {
        public static bool IsMonotonic(int[] array)
        {
            if (array.Length == 0 || array.Length == 1) return true;
            MonotonicType monotonicType = MonotonicType.DontKnow;
            for (int i = 1; i < array.Length; i++)
            {
                if (monotonicType == MonotonicType.DontKnow)
                {
                    if (array[i - 1] < array[i])
                    {
                        monotonicType = MonotonicType.Inreasing;
                    }
                    else if (array[i - 1] > array[i])
                    {
                        monotonicType = MonotonicType.Decreasing;
                    }
                }
                else
                {
                    if ((monotonicType == MonotonicType.Inreasing && array[i - 1] > array[i]) || 
                        (monotonicType == MonotonicType.Decreasing && array[i - 1] < array[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

    enum MonotonicType
    {
        DontKnow,
        Inreasing,
        Decreasing
    }
}
