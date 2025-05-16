namespace Round3_29_01_2025
{
    /*
     
     You are given an array of Integers in which each subsequent value is not less than the previous value. 
    Write a function that takes this array as an input and returns a new array with the squares of each number sorted in ascending order.
    [-4, -2, 0, 1, 3] => [0, 1, 4, 9, 16]
     */
    public class _8_SortedSquaredArray
    {
        // Time complexity = O(n)   / uses a loop
        // Space complexity = O(n)  / uses an additional array to store results
        public int[] GetSortedSquaredArray(int[] input)
        {
            var result = new int[input.Length];
            var left = 0;
            var right = input.Length - 1;
            var index = result.Length - 1;
            while(left <= right)
            {
                var leftSqrd = input[left] * input[left];
                var rightSqrd = input[right] * input[right];
                if (leftSqrd > rightSqrd)
                {
                    result[index--] = leftSqrd;
                    ++left;
                }
                else
                {
                    result[index--] = rightSqrd;
                    --right;
                }
            }
            return result;
        }
    }
}
