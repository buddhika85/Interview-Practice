using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Arrays
{
    public static class ProductTriplets
    {
        public static void Demo()
        {
            var input = new int[] {1,4,6,2,3,8};
            var target = 24;
            List<int[]> triplets = GetProductTriplets(input, target);
            //List<int[]> triplets = GetProductTripletsOptimal(input, target);
            foreach (var triplet in triplets)
            {
                WriteLine($"[{triplet.Display(", ")}]");
            }
        }

        private static List<int[]> GetProductTripletsOptimal(int[] input, int target)
        {
            throw new NotImplementedException();
        }

        // Time: O(n)^3 - becuase we used 3 nested loops
        // Space: O(1) - we did not use any additional data structures
        private static List<int[]> GetProductTriplets(int[] array, int target)
        {
            List<int[]> triplets = new List<int[]>();
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    for (int k = j; k < array.Length; k++)
                    {
                        if (i != j && j != k && i != k && 
                            array[i] * array[j] * array[k] == target)
                        {
                            triplets.Add(new int[] { array[i], array[j], array[k]});
                        }
                    }
                }
            }
            return triplets;
        }
    }
}