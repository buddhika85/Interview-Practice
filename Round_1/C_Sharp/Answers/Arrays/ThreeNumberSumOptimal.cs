namespace C_Sharp.Answers.Arrays
{
    public class QThreeNumberSumOptimal
    {
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
             var triplets = new List<int[]>();

            // sort the array
            Array.Sort(array);
            for (var i = 0; i < array.Length - 2; i++)          // why -2 => we need to have 2 elements to right of the i always
            {
                var left = i + 1;
                var right = array.Length - 1;
                while(left < right)
                {
                    var sum = array[i] + array[left] + array[right];
                    if (sum == targetSum)
                        triplets.Add(new int[] {array[i], array[left++], array[right--]});      // add and move both
                    else if (sum < targetSum)
                        ++left;                 // move left to right
                    else if (sum > targetSum)
                        --right;                // move right to left
                }
            }

            return triplets;
        }
    }
}
