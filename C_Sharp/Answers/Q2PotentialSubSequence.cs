using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q2PotentialSubSequence
    {
        // Time complexity - O(n) 
        // Space complexity - O(1)
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {

            if (sequence.Count > array.Count)
                return false;

            var seqIndexToFind = 0;

            for (var i = 0; i < array.Count && seqIndexToFind < sequence.Count; i++)
            {
                if (array[i] == sequence[seqIndexToFind])
                    ++seqIndexToFind;
            }

            return seqIndexToFind == sequence.Count;
        }
    }
}