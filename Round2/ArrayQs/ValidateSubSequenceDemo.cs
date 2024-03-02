﻿namespace Round_2;

public class ValidateSubSequenceDemo
{
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
