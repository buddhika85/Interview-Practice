using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.FamousAlgorithms
{
    public class KadanesAlgoTry2Demo
    {
        public static void Demo()
        {
            int[] numbers = new int[] {3,5,-9,1,3,-2,3,4,7,2,-9,6,3,1,-5,4};
            WriteLine($"{KadanesAlgorithm(numbers)}");
        }

        public static int KadanesAlgorithm(int[] array)
        {
            var currentSoFar = array[0];
            var maxSoFar = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                currentSoFar = Math.Max(currentSoFar + array[i], array[i]);
                maxSoFar = Math.Max(currentSoFar, maxSoFar);
            }
            return maxSoFar;
        }

    }
}