using static System.Console;

namespace Round3_29_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test_1();
        }

        private static void Test_1()
        {
            var array = new[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            var target = 10;
            WriteLine(_1_TwoNumberSum.TwoNumberSum(array, target).DisplayableString(','));
        }
    }
}
