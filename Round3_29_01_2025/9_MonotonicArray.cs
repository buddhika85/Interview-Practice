namespace Round3_29_01_2025
{
    public class MonotonicArray
    {
        // An array is monotonic if it is either monotone increasing or monotone decreasing.
        // An array is monotone increasing if all its elements from left to right are non-decreasing.
        // An array is monotone decreasing if all  its elements from left to right are non-increasing.
        // Given an integer array return true if the given array is monotonic, or false otherwise. 
        public bool IsMonotonic(int[] array)
        {
            var montoneIncreasing = false;
            var montoneDecreasing = false;
            for (var i = 1; i < array.Length; i++)
            {
                // decide if its montoneIncreasing or montoneDecreasing
                if (!montoneIncreasing && !montoneDecreasing)
                { 
                    if (array[i] > array[i - 1])
                    {
                        montoneIncreasing = true;
                    }
                    if (array[i] < array[i - 1])
                    {
                        montoneDecreasing = true;
                    }
                }
                else
                {
                    // once decided check if its continued or not
                    if (array[i] > array[i - 1] && montoneDecreasing)
                        return false;
                    if (array[i] < array[i - 1] && montoneIncreasing)
                        return false;
                }
            }
            return true;
        }
    }
}
