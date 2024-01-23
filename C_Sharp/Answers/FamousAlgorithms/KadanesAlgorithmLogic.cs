using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.FamousAlgorithms
{
    public class KadanesAlgorithmLogic
    {

        public static void KadanesAlgorithmTest()
        {
            var array = new int[] {3,5,-9,1,3,-2,3,4,7,2,-9,6,3,1,-5,4};
            var subArrayMaxSumExpected = 19;
            var subArrayMaxSumActual = KadanesAlgorithm(array);
            WriteLine($"KadanesAlgorithm => {array.Display(", ")} : max sum of sub array = {subArrayMaxSumActual}{Environment.NewLine}Passed => {subArrayMaxSumActual == subArrayMaxSumExpected}");
        }

        public static int KadanesAlgorithm(int[] array)
        {
            var maxSoFar = int.MaxValue * -1;
            var maxEndingHere = 0;
            foreach (var item in array)
            {
                maxEndingHere = int.Max(maxEndingHere + item, item);
                maxSoFar = int.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }
    }
}