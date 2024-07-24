namespace Round_2.ArrayQs
{
    internal class TwoNumberSum2
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            var left = 0;
            var right = array.Length - 1;
            while (left < right)
            {
                var sum = array[left] + array[right];
                if (sum > targetSum)
                {
                    right--;
                }
                else if (sum < targetSum)
                {
                    left++;
                }

                // found
                return new int[] { array[left], array[right] };
            }

            // not found
            return new int[] { };
        }
    }
}
