namespace Round_2;

public class SortedSquaredArrayDemo
{
    // TimeL O(n) | Space: O(n)
    public int[] SortedSquaredArray(int[] array) 
    {
        var result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)  // O(n)
        {
            result[i] = array[i] * array[i];
        }  
        Array.Sort(result);     // quick sort - O(log n)
        return result;  
    }

    public int[] SortedSquaredArrayV2(int[] array) 
    {
        int[] result = new int[array.Length];
        int resultIndex = array.Length - 1;
        var left = 0;
        var right = array.Length - 1;
        while(left <= right)
        {
            var leftSqured = array[left] * array[left];
            var rightSquared = array[right] * array[right];
            if (leftSqured > rightSquared)
            {
                result[resultIndex--] = leftSqured;
                ++left;
            }
            else 
            {
                 result[resultIndex--] = rightSquared;
                --right;
            }
        }
        return result;
    }

}
