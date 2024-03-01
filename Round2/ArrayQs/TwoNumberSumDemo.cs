namespace Round_2;

public class TwoNumberSumDemo
{
    public static int[] TwoNumberSum(int[] array, int targetSum)
    {
       
        Array.Sort(array);
        var left = 0;
        var right = array.Length - 1;
        while(left < right)
        {
            var sum = array[left] + array[right];
            if (sum == targetSum)
            {
                return new int[]{array[left], array[right]};
            }
            else if (sum > targetSum)
            {
                --right;
            }
            else
            {
                ++left;
            }
        }
        return new int[0];
    }
}
