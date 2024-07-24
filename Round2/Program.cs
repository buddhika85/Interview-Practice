
using Round_2.ArrayQs;
using Round_2.ExtensionMethods;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        TestTwoNumberSum();
    }

    private static void TestTwoNumberSum()
    {
        var result = TwoNumberSum2.TwoNumberSum(new int[] { 3, 5, -4, 8, 11, -1, 6 }, 10);
        WriteLine(result.Join<int>(','));

    }
}