
using Round_2;
using Round_2.ArrayQs;
using Round_2.ExtensionMethods;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        //TestTwoNumberSum();
        //TestValidateSubsequence2();
        //TestSortedSquaredArray();
        TestRournamentWinner();
    }

    private static void TestRournamentWinner()
    {
        List<List<string>> competitions = new List<List<string>> 
        { 
            new List<string> { "HTML", "C#" },
            new List<string> { "C#", "Python" },
            new List<string> { "Python", "HTML" }
        };
        List<int> results = new List<int> { 0, 0, 1};  // Python
        //List<int> results = new List<int> { 0, 1, 1 };      // C#
        WriteLine(TournamentWinnerDemo.TournamentWinnerOpt(competitions, results));
    }

    private static void TestSortedSquaredArray()
    {
        var result = SortedSquaredArrayDemo.SortedSquaredArrayV3(new int[] { 1,2,3,4,5 });
        WriteLine(result.Join<int>(','));

        //result = SortedSquaredArrayDemo.SortedSquaredArrayV3(new int[] { -10, -2, 1, 5 });
        //WriteLine(result.Join<int>(','));

        //result = SortedSquaredArrayDemo.SortedSquaredArrayV3(new int[] { -3, -2, -1, 4, 5 });
        //WriteLine(result.Join<int>(','));

        result = SortedSquaredArrayDemo.SortedSquaredArrayV3(new int[] { -7, -3, -2, 1, 4, 5 });
        WriteLine(result.Join<int>(','));
    }

    private static void TestValidateSubsequence2()
    {
        var array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
        var sequence = new List<int> { 1, 6, -1, 5 };
        WriteLine(ValidateSubsequence3.IsValidSubsequence(array, sequence));

        sequence = new List<int> { 1, 6, -1, 10 };
        WriteLine(ValidateSubsequence3.IsValidSubsequence(array, sequence));

    }

    private static void TestTwoNumberSum()
    {
        //var result = TwoNumberSum3.TwoNumberSum(new int[] { 3, 5, -4, 8, 11, -1, 6 }, 10)
        var result = TwoNumberSum3.TwoNumberSumDictionary(new int[] { 3, 5, -4, 8, 11, -1, 6 }, 10);
        WriteLine(result.Join<int>(','));
    }
}