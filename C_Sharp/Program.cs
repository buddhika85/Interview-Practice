using C_Sharp.Answers;
using static System.Console;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Testing Answers \n");        
        // Q1();
        // Q2();
        // Q3();
        Q4();
    }

    private static void Q4()
    {
        var competition = new List<List<String>> 
        {
            new List<string> { "HTML", "C#"},
            new List<string> { "C#", "Python"},
            new List<string> { "Python", "HTML"},
        };
        var results = new List<int> 
        {
            0, 0, 1
        };

        WriteLine(new Q4TournamentWinner().TournamentWinner(competition, results));
    }

    private static void Q3()
    {
        var inputArray = new[] { -5,-1,0,1,2};
        var result = new Q3SortedSquared().SortedSquaredArray(inputArray);
        WriteLine($"{string.Join("|", result)}");


        inputArray = new[] { 1,2,3,4};
        result = new Q3SortedSquared().SortedSquaredArray(inputArray);
        WriteLine($"{string.Join("|", result)}");
    }

    private static void Q1()
    {
        var inputArray = new[] { 3, 5, -4, 8, 11, 1, -1, 0 };
        var result = new Q1TwoSumNum().TwoNumberSum(inputArray, 10);
        WriteLine($"{result[0]} , {result[1]}");

        inputArray = new[] { 3, 5, -4, 8, 11, 1, -1, 0 };
        //new Q1TwoSumNum().Sort(inputArray);
        //WriteLine(string.Join(" | ", inputArray));
        result = new Q1TwoSumNum().TwoNumberSumV2(inputArray, 10);
        WriteLine($"{result[0]} , {result[1]}");
    }

    private static void Q2()
    {
        List<int> inputArray = new() { 5, 1, 22, 25, 6, -1, 8, 10 };
        List<int> sequence = new() { 1, 6, -1, 10 };
        WriteLine($"{Q2PotentialSubSequence.IsValidSubsequence(inputArray, sequence)}");

        inputArray = new() { 5, 1, 22, 25, 6, -1, 8, 10 };
        sequence = new() { 1, 6, -1, 5 };
        WriteLine($"{Q2PotentialSubSequence.IsValidSubsequence(inputArray, sequence) == false}");
    }
}