﻿
using Round_2.ArrayQs;
using Round_2.ExtensionMethods;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        //TestTwoNumberSum();
        TestValidateSubsequence2();
    }

    private static void TestValidateSubsequence2()
    {
        var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
        var sequence = new List<int> { 1, 6, -1, 5 };
        WriteLine(ValidateSubsequence2.IsValidSubsequence(array, sequence));
    }

    private static void TestTwoNumberSum()
    {
        var result = TwoNumberSum2.TwoNumberSum(new int[] { 3, 5, -4, 8, 11, -1, 6 }, 10);
        WriteLine(result.Join<int>(','));

    }
}