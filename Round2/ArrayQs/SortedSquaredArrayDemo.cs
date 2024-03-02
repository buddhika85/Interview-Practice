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

}
