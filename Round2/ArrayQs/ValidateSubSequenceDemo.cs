namespace Round_2;

public class ValidateSubSequenceDemo
{
    // Time: O(n) n being the length of array | Space: O(1) -> no additional space used
    public static bool IsValidSubsequence(List<int> array, List<int> sequence) 
    {
        if (array.Count < sequence.Count)
        {
            return false;
        }

        var current = 0;
        var indexToLookFor = 0;

        while(current < array.Count && indexToLookFor < sequence.Count)
        {
            if (array[current] == sequence[indexToLookFor])
            {
                indexToLookFor++;
            }
            current++;
        }
        return indexToLookFor == sequence.Count;
    }
}
