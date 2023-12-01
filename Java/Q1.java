package Java;

import java.util.Arrays;
import java.util.HashMap;

public class Q1 {
    public static int[] twoNumberSum(int[] array, int targetSum) {
        HashMap<Integer, Integer> myMap = new HashMap<>();
        for (int value : array) {
            var needed = targetSum - value;
            if (myMap.containsKey(needed))
                return new int[] { value, needed };
            else
                myMap.put(value, value);
        }
        return new int[0];
    }

    public static void sort(int[] array) {
        Arrays.sort(array);
    }

    public static int[] twoNumberSumV2(int[] array, int targetSum) {
        sort(array);                // sort first
        int left = 0, right = array.length - 1;
        while(left < right)
        {
            if (array[left] + array[right] < targetSum)
                ++left;             // go right
            else if (array[left] + array[right] > targetSum)
                -- right;           // go left
            else
                return new int[] { array[left], array[right] };
        }
        return new int[0];
    }
}
