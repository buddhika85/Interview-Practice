using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Recursion
{
    public static class PermutationsDemo
    {
        public static void Demo()
        {
            List<int> list = new() {1,2,3};
            var permutations = GetPermutations(list);
            WriteLine(permutations.Count);
            foreach (var item in permutations)
            {
                WriteLine(item.Display(","));
            }
        }

        public static List<List<int>> GetPermutations(List<int> array)
        {
            var allPermsSoFar =  new List<List<int>>();
            GetPermutationsHelper(array, 0, allPermsSoFar);
            return allPermsSoFar;
        }

        private static void GetPermutationsHelper(List<int> array, int start, List<List<int>> allPermsSoFar)
        {
            if (start == array.Count - 1)
            {
                var permutation = new List<int>();
                permutation.AddRange(array);
                allPermsSoFar.Add(permutation); 
            }
            else
            {
                for (int j = start; j < array.Count; j++)
                {
                    // swap start and j
                    Swap(start, j, array);
                    // recursive
                    GetPermutationsHelper(array, start + 1, allPermsSoFar);
                    // swap start and j
                    Swap(start, j, array);
                }
            }
        }

        private static void Swap(int i, int j, List<int> array)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}