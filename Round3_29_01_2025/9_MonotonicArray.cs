namespace Round3_29_01_2025
{
    public class MonotonicArray
    {
        // An array is monotonic if it is either monotone increasing or monotone decreasing.
        // An array is monotone increasing if all its elements from left to right are non-decreasing.
        // An array is monotone decreasing if all  its elements from left to right are non-increasing.
        // Given an integer array return true if the given array is monotonic, or false otherwise. 
        // Time = O(n)      - we are using the loop in worst case
        // Space = O(1)     - we have not created any new array variables
        public bool IsMonotonic(int[] array)
        {
            if (array.Length < 3)
                return true;

            var monotoneIncreasing = false;
            var monotoneDecreasing = false;
            for (var i = 1; i < array.Length; i++)
            {
                // decide if its montoneIncreasing or montoneDecreasing
                if (!monotoneIncreasing && !monotoneDecreasing)
                { 
                    if (array[i] > array[i - 1])
                    {
                        monotoneIncreasing = true;
                    }
                    if (array[i] < array[i - 1])
                    {
                        monotoneDecreasing = true;
                    }
                }
                else
                {
                    // once decided check if its continued or not
                    if (array[i] > array[i - 1] && monotoneDecreasing)
                        return false;
                    if (array[i] < array[i - 1] && monotoneIncreasing)
                        return false;
                }
            }
            return true;
        }
    }
}
