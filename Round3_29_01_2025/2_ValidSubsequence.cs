namespace Round3_29_01_2025
{
    internal class _2_ValidSubsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            if (array.Count < sequence.Count) 
                return false;

            var lookingForIndex = 0;
            var arrayIndex = 0; 
            while (lookingForIndex < sequence.Count && arrayIndex < array.Count)
            {
                if (array[arrayIndex] == sequence[lookingForIndex])
                {
                    lookingForIndex++;
                }
                arrayIndex++;
            }
            return lookingForIndex == sequence.Count;
        }
    }
}
