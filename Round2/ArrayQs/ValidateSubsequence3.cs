using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round_2.ArrayQs
{
    internal class ValidateSubsequence3
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            var indexToFind = 0;
            for (int i = 0; i < array.Count && indexToFind < sequence.Count; i++)
            {
                if (array[i] == sequence[indexToFind])
                    ++indexToFind;
            }
            return indexToFind == sequence.Count; // if true we found all in sequnce in the array
        }
    }
}
