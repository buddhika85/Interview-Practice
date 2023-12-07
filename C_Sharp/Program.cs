using C_Sharp.Answers;
using static System.Console;
using C_Sharp.Answers.Extensions;

internal class Program
{
    private static void Main(string[] args)
    {
        WriteLine("Testing Answers \n");
        // Q1();
        // Q2();
        // Q3();
        // Q4();
        // Q5();
        // Q6();
        // Q7();
        // Q25();
        // Q20();
        Q23();
    }

    private static void Q23()
    {
        var data = new List<int[]> 
        {
            new [] {1},
            new [] {1,0-1},
            new [] {1,0,-2,-1},
            new [] {1,0,10,10-2,-1},
            new [] {8,5,2,9,5,6,3},
        };
        foreach (var item in data)
        {
            WriteLine($"{item.Display(",")} => {Q23BubbleSort.BubbleSort(item).Display(",")}");
        }
    }

    private static void Q20()
    {
        // WriteLine($"{Q20BinarySearch.BinarySearch(new int[] {0,1,21,33,45,45,61,71,72,73}, 33) == 3}");
        // WriteLine($"{Q20BinarySearch.BinarySearch(new int[] {-5,0,1,21,33,45,45,61,71,72,73}, 33) == 4}");
        // WriteLine($"{Q20BinarySearch.BinarySearch(new int[] {1}, 1) == 0}");
        // WriteLine($"{Q20BinarySearch.BinarySearch(new int[] {1}, 2) == -1}");

        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] {0,1,21,33,45,45,61,71,72,73}, 33) == 3}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] {-5,0,1,21,33,45,45,61,71,72,73}, 33) == 4}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] {1}, 1) == 0}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] {1}, 2) == -1}");
    }

    private static void Q25()
    {
        WriteLine($"{Q25PalindromeCheck.IsPalindrome("abcdcba")}");
        WriteLine($"{Q25PalindromeCheck.IsPalindrome("a")}");
        //WriteLine($"{Q25PalindromeCheck.IsPalindrome("malayalam")}");
        WriteLine($"{Q25PalindromeCheck.IsPalindrome("xy")}");
        WriteLine($"{Q25PalindromeCheck.IsPalindrome("xyx")}");
    }

    private static void Q7()
    {
        var root = new BST(10);
        root.left = new BST(5);
        root.left.left = new BST(2);
        root.left.left.left = new BST(1);
        root.left.right = new BST(5);
        root.right = new BST(15);
        root.right.left = new BST(13);
        root.right.left.right = new BST(14);
        root.right.right = new BST(22);
        WriteLine($"{Q7ClosestValueInBst.FindClosestValueInBst(root, 12)}");
    }

    private static void Q6()
    {
        var twoDArrays = new List<int[,]>
        {
            new int[,]
            {
                {1,2},
                {3,4},
                {5,6}
            },
            new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            },
            new int[,]
            {
                {1,2}
            },
        };
        foreach (var twoDArray in twoDArrays)
        {
            Print2DArray(twoDArray);
            Print2DArray(new Q6TransposeMatrix().TransposeMatrix(twoDArray));
        }
    }

    private static void Q5()
    {
        var input = new int[] { 1, 2, 5 };
        WriteLine($"{new Q5NonConstructableChange().NonConstructibleChange(input) == 4}");

        input = new int[] { 1, 10 };
        WriteLine($"{new Q5NonConstructableChange().NonConstructibleChange(input) == 2}");

        input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
        WriteLine($"{new Q5NonConstructableChange().NonConstructibleChange(input) == 20}");

        input = new int[] { 1, 1, 1, 1, 1 };
        WriteLine($"{new Q5NonConstructableChange().NonConstructibleChange(input) == 6}");
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
        var inputArray = new[] { -5, -1, 0, 1, 2 };
        var result = new Q3SortedSquared().SortedSquaredArray(inputArray);
        WriteLine($"{string.Join("|", result)}");


        inputArray = new[] { 1, 2, 3, 4 };
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

    private static void Print2DArray(int[,] twoDArray)
    {
        string str = string.Empty;
        var rows = twoDArray.GetLength(0);
        var columns = twoDArray.GetLength(1);
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                str += $"{twoDArray[row, col]} ";
            }
            str += Environment.NewLine;
        }
        Console.WriteLine(str);
    }
}