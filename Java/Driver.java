package Java;

import java.util.Arrays;

public class Driver
{
    public static void main(String[] args) {
        System.out.println("Testing Java");
        testQ1();
    }

    private static void testQ1() {
        var inputArray = new int [] { 3, 5, -4, 8, 11, 1, -1, 0 };
        // var result = Q1.twoNumberSum(inputArray, 10);
        // System.out.println(Arrays.toString(result));
        var result = Q1.twoNumberSumV2(inputArray, 10);
        System.out.println(Arrays.toString(result));
    }
}