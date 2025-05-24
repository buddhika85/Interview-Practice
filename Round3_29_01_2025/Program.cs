using System.Collections.ObjectModel;
using static System.Console;

namespace Round3_29_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test_1();
            //Test_2();
            //Test_3();
            //Test_4();
            //Test_5();
            //Test_6();
            //Test_7();
            //Test_8();
            Test_13();
        }

        private static void Test_13()
        {
            WriteLine(new PowerSum().GetPowerSum(new object[]
            {
                1,
                2,
                new int[] { 3, 4 },
                new int[][] { new int[] { 2 } }
            }));
        }

        private static void Test_8()
        {
            var cut = new SortedSquaredArray();
            var data = new (int[], int[])[] 
            {
                ([], []),
                ([-4, -2, 0, 1, 3], [0, 1, 4, 9, 16]),
                ([1, 3, 5], [1, 9, 25]),
                ([0, 5, 6], [0, 25, 36])
            };
            foreach (var testCase in data)
            {
                if (testCase.Item2.SequenceEqual(cut.GetSortedSquaredArray(testCase.Item1)))
                {
                    WriteLine("Pass");
                }
            }
        }

        private static void Test_7()
        {
            var array = new[] { 5, 1, 4, 2 };
            //var array = new[] { 0,0,0,0 };
            var result = _7_ArrayOfProducts.ArrayOfProducts(array);
            WriteLine($"Array Of Products = {result.DisplayableString(',')}");
        }

        private static void Test_6()
        {
            int[,] twoDArray = { 
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 } 
            };
            // 0th Dimension of the array are rows
            // 1st Dimension of the array are columns
            WriteLine($"Rows => {twoDArray.GetLength(0)}");
            WriteLine($"Columns => {twoDArray.GetLength(1)}");

            WriteLine($"array[0,1] => {twoDArray[0, 1]}" );      // 2

            int[,] result = _6_TransposeMatrix.TransposeMatrix(twoDArray);

            //    output = [
            //    [1,3,5]
            //    [2,4,6]
            //]
            WriteLine($"\nRESULT Rows => {result.GetLength(0)}");
            WriteLine($"\nRESULT Columns => {result.GetLength(1)}");
            WriteLine($"{result[0,0]} , {result[0,1]} , {result[0,2]}");      // 1,3,5
            WriteLine($"{result[1, 0]} , {result[1, 1]} , {result[1, 2]}");     // 2,4,6
        }

        private static void Test_5()
        {
            var testCases = new List<(int[], int)> 
            { 
                (new int[] { 1, 2, 5 }, 4),
                (new int[] { 5,7,1,1,2,3,22}, 20)
            };
            foreach (var testCase in testCases)
            {
                WriteLine($"{testCase.Item1.DisplayableString(',')} => " +
                    $"{_5_NonConstructibleChange.NonConstructibleChange(testCase.Item1)}");
            }
        }

        private static void Test_4()
        {
            var competitions = new List<List<string>> 
            { 
                new List<string> { "HTML", "C#"},                 
                new List<string> { "C#", "PYTHON"}, 
                new List<string> { "PYTHON", "HTML" } 
            };
            var results = new List<int> { 0, 0, 1 };
            WriteLine($"Winner = {_4_TournamentWinner.TournamentWinner(competitions, results)}");
        }

        private static void Test_3()
        {
            var array = new[] { -5, -2, 1, 2, 3 };
            WriteLine($"Sorted squared array = {_3_SortedSquaredArray.SortedSquaredArray(array).DisplayableString(',')}");
        }

        private static void Test_2()
        {
            var array = new[] { 55,1,22,25,6,-1,8,10 };
            var sequence = new[] { 1, 6, -1, 10 };
            WriteLine($"Is valid subsequence => {_2_ValidSubsequence.IsValidSubsequence(array.ToList(), sequence.ToList())}");
        }

        private static void Test_1()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            var target = 10;
            WriteLine(_1_TwoNumberSum.TwoNumberSum(array, target).DisplayableString(','));
        }
    }
}
