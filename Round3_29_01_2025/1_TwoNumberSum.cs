namespace Round3_29_01_2025
{
    internal class _1_TwoNumberSum
    {

        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            // sort
            Array.Sort(array);

            // iterate and find target
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var total = array[left] + array[right];
                if (total > targetSum)
                {
                    --right;
                }
                else if (total < targetSum)
                {
                    ++left;
                }
                else
                {
                    return [array[left], array[right]];
                }
            }
            return Array.Empty<int>();
        }
    }
}
