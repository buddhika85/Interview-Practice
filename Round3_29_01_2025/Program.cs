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
            Test_4();
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
