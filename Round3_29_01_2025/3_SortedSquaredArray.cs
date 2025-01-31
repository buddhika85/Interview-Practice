namespace Round3_29_01_2025
{
    internal class _3_SortedSquaredArray
    {
        public static int[] SortedSquaredArray(int[] array)
        {
            var results = new int[array.Length];
            var left = 0;
            var right = array.Length - 1;
            var resultsIndex = array.Length - 1;
            while(resultsIndex >= 0)
            {
                var leftSquared = array[left] * array[left];
                var rightSquared = array[right] * array[right];
                if (leftSquared > rightSquared)
                {
                    results[resultsIndex--] = leftSquared;
                    ++left;
                }
                else
                {
                    results[resultsIndex--] = rightSquared;
                    --right;
                }
            }
            return results;
        }
    }
}
