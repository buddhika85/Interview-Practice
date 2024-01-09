using C_Sharp.Answers;
using static System.Console;
using C_Sharp.Answers.Extensions;
using C_Sharp.Answers.Arrays;
using C_Sharp.Answers.Recursion;
using C_Sharp.Answers.Strings;

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
        // Q21();
        // Q23();

        //ThreeNumberSumTestNotOptimal();
        //ThreeNumberSumTestOptimal();

        //TestMonotonic();
        //TestSmallestDifference();

        //TestRecursionFibonacci();
        //TestCommonCharacters();


        //TestCaesarCypherEncryptor();
        //TestMoveElementToEnd();

        //TestLongestPeak();
        //TestFirstDuplicateValue();

        TestMajorityElement();

        // BST - To Do
        //BstConstructionTests();
    }

    private static void TestMajorityElement()
    {
        var array = new int[] {1,2,3,2,2,1,2};
        var expected = 2;
        WriteLine($"TestMajorityElement => {MajorityElementLogic.MajorityElement(array) == expected}");
        WriteLine($"TestMajorityElementOptimal => {MajorityElementLogic.MajorityElementOptimalTwo(array) == expected}");
    }

    private static void TestFirstDuplicateValue()
    {
        var array = new int[] {2, 1, 5, 2, 3, 3, 4};
        var expected = 2;
        WriteLine($"TestFirstDuplicateValue => {FirstDuplicateValueLogic.FirstDuplicateValueOptimal(array) == expected}");
        
        array = new int[] {2, 1, 5, 3, 3, 2, 4};
        expected = 3;
        WriteLine($"TestFirstDuplicateValue => {FirstDuplicateValueLogic.FirstDuplicateValueOptimal(array) == expected}");
    }

    private static void TestLongestPeak()
    {
        var data = new List<(int[], int)> 
        {
            (new int[] {1,2,3,3,4,0,10,6,5,-1,-3,2,3}, 6),
            (new int[] {1, 3, 2}, 3),
            (new int[] {1, 2, 3, 4, 5, 1}, 6),
            (new int[] {5, 4, 3, 2, 1, 2, 1}, 3),
            (new int[] {1, 1, 3, 2, 1}, 4)
        };
        foreach (var i in data)
        {
            WriteLine($"Longest Peak: {LongestPeakLogic.LongestPeak(i.Item1) == i.Item2}");
        }
    }

    private static void TestCaesarCypherEncryptor()
    {
        var str = "xyz";
        var shiftedFowardTo = 2;
        WriteLine($"{str} => {CaesarCypherEncryptHelper.CaesarCypherEncryptor("xyz", shiftedFowardTo)}");
    }

    private static void TestMoveElementToEnd()
    {
        var list = new List<int> { 2,1,2,2,2,3,4,2 };
        var toMove = 2;
        WriteLine($"{MoveElementToEndLogic.MoveElementToEnd(list, toMove).Display(",")}");
    }

    private static void TestCommonCharacters()
    {
        var strings = new string[] {"abc", "bcd", "cbaccd"};
        // var strings = new string[] {"aaaa", "a"};
        WriteLine($"Commons: {CommonCharFinder.CommonCharactersSolThree(strings).Display(", ")}");
    }

    private static void TestRecursionFibonacci()
    {
        var result = new int[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};
        for (var i = 0; i < result.Length; i++)
        {
            WriteLine($"{result[i] == Fibonacci.GetNthFib(i + 1)}");
        }
    }

    private static void TestSmallestDifference()
    {
        var arrayOne = new int [] {-1, 5, 10, 20, 28, 3};
        var arrayTwo = new int[] {26, 134, 135, 15, 17};
        WriteLine($"Smallest Difference: {SmallestDifferenceOfArrays.SmallestDifference(arrayOne, arrayTwo).Display(",")}");
    }

    private static void TestMonotonic()
    {
        List<int[]> monotonics = new List<int[]> {
            new int[] {},
            new int[] {1},
            new int[] {1, 2, 2, 3, 5},
            new int[] {7, 5, 4, 3, 1},
            new int[] {2, 4, 6, 8, 10},
            new int[] {9, 7, 5, 3, 1},
            new int[] {1, 2, 2, 3, 5, 6},
            new int[] {7, 5, 4, 3, 1, -10},
            new int[] {2, 4, 6, 8, 10, 20},
            new int[] {9, 7, 5, 3, 1, -100},
            new int[] {-1, -5, -10, -1100, -1100, -1101, -9001},
            new int[] {-1, -1, -1, -1, -1, -1, -1, -1}
        };
        WriteLine("Monotonics");
        foreach (var item in monotonics)
        {
            // WriteLine($"{Monotonic.IsMonotonic(item).BoolYesNo()}");
            WriteLine($"{Monotonic.IsMonotonicSolTwo(item).BoolYesNo()}");
        }

        List<int[]> nonMonotonics = new List<int[]> {
            new int[] {-1,-2, 1},
            new int[] {1,100,0},
            new int[] {1, 2, 2, 3, 5, 0},
            new int[] {7, 5, 4, 3, 1, 1000},
            new int[] {2, 4, 6, 8, 10, -10},
            new int[] {9, 7, 5, 3, 1, 100},
            new int[] {1, 2, 2, 3, 5, 6, 0},
            new int[] {7, 5, 4, 3, 1, -10, 11},
            new int[] {2, 4, 6, 8, 10, 20, -21},
            new int[] {9, 7, 5, 3, 1, -100, 101},
            new int[] {-1, -5, -10, -1100, -1100, -1101, -9001, 9001}
        };
        WriteLine("\nNon Monotonics");
        foreach (var item in nonMonotonics)
        {
            //WriteLine($"{Monotonic.IsMonotonic(item).BoolYesNo()}");
            WriteLine($"{Monotonic.IsMonotonicSolTwo(item).BoolYesNo()}");
        }
    }

    private static void ThreeNumberSumTestOptimal()
    {
        var array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
        var targetSum = 0;
        var results = QThreeNumberSumOptimal.ThreeNumberSum(array, targetSum);
        foreach (var item in results)
        {
            WriteLine($"{item?.Display(",")}\n");
        }
    }

    // [12, 3, 1, 2, -6, 5, -8, 6]
    // target Sum = 0
    // [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
    private static void ThreeNumberSumTestNotOptimal()
    {
        var array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
        var targetSum = 0;
        var results = QThreeNumberSumWithTreeLoops.ThreeNumberSum(array, targetSum);
        foreach (var item in results)
        {
            WriteLine($"{item?.Display(",")}\n");
        }
    }

    private static void BstConstructionTests()
    {
        var nums = new[] { 5, 15, 2, 5, 13, 22, 1, 14 };
        C_Sharp.Answers.Bst.BST bst = new(10);
        foreach (var item in nums)
        {
            bst.Insert(item);
        }
        WriteLine("Insertion Complete");

        // found cases
        // foreach (var item in nums)
        // {
        //     WriteLine($"{item} found => {(bst.Contains(item) ? "Yes" : "No")}");
        // }

        // not found cases
        // WriteLine($"{0} found => {(bst.Contains(0) ? "Yes" : "No")}");
        // WriteLine($"{-1} found => {(bst.Contains(-1) ? "Yes" : "No")}");
        // WriteLine($"{100} found => {(bst.Contains(100) ? "Yes" : "No")}");

        // removal of root
        //bst.Remove(10);
        //WriteLine($"{10} found => {(bst.Contains(10) ? "Yes" : "No")}");            // works

        // removal of a leaf right
        // bst.Remove(14);
        // WriteLine($"{14} found => {(bst.Contains(14) ? "Yes" : "No")}");                // works

        // // removal of a leaf left
        // bst.Remove(1);
        // WriteLine($"{1} found => {(bst.Contains(1) ? "Yes" : "No")}");                  // works

        // removal of a node with one child - left
        bst.Remove(2);
        WriteLine($"{2} found => {(bst.Contains(2) ? "Yes" : "No")}");                // works

        // removal of a node with one child - right
        bst.Remove(13);
        WriteLine($"{13} found => {(bst.Contains(13) ? "Yes" : "No")}");                // works
    }

    private static void Q21()
    {
        var data = new List<int[]>
        {
            new [] {1},
            new [] {1,0-1},
            new [] {2,0,1},
            new [] {1,0,-2,-1},
            new [] {1,0,10,10-2,-1},
            new [] {8,5,2,9,5,6,3},
        };
        foreach (var item in data)
        {
            WriteLine($"{item.Display(",")} => {Q21InsertionSort.InsertionSort(item).Display(",")}");
        }
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

        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 33) == 3}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] { -5, 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 }, 33) == 4}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] { 1 }, 1) == 0}");
        WriteLine($"{Q20BinarySearch.BinarySearchRecursive(new int[] { 1 }, 2) == -1}");
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