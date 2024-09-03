namespace Round_2.ArrayQs
{
    internal class ValidateSubsequence2
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            if (sequence.Count > array.Count)
                return false;

            var arrayIndex = 0;
            var lastSeenIndex = -1;         // last seen sequence index
            var isRoundOneComplete = false;
            while (arrayIndex < array.Count && lastSeenIndex + 1 < sequence.Count)
            { 
                var arrayNum = array[arrayIndex];
                var sequcneNum = sequence[lastSeenIndex + 1];
                if (arrayNum == sequcneNum)
                {
                    ++lastSeenIndex;
                }

                arrayIndex++;

                if (arrayIndex == array.Count && lastSeenIndex < sequence.Count - 1 && !isRoundOneComplete)
                {
                    arrayIndex = 0;     // reset go round 2
                    isRoundOneComplete = true;
                }
            }

            return lastSeenIndex == sequence.Count - 1;     // true means all indexes have been seen in the correct order
        }
    }
}
