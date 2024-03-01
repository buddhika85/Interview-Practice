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
            var input = new int[] { 1, 4, 6, 2, 3, 8 };
            var target = 24;

            List<int[]> triplets = GetProductTriplets(input, target);
            Display(triplets);

            WriteLine();
            triplets = GetProductTripletsOptimal(input, target);
            Display(triplets);
        }

        private static void Display(List<int[]> triplets)
        {
            foreach (var triplet in triplets)
            {
                WriteLine($"[{triplet.Display(", ")}]");
            }
        }

        // Time: O(n)^3 - becuase we used 3 nested loops
        // Space: O(1) - we did not use any additional data structures
        private static List<int[]> GetProductTripletsOptimal(int[] array, int target)
        {
            List<int[]> triplets = new List<int[]>();

            Array.Sort(array);      // sort in place - typically quick sort - O(log n)
            for (int i = 0; i < array.Length - 2; i++)      // last two will be used for other 2 pointers
            {
                var start = i + 1;
                var end = array.Length - 1;
                while (start < end)
                {
                    var product = array[i] * array[start] * array[end];
                    if (product == target)
                    {
                        triplets.Add(new int[] { array[i], array[start], array[end] });
                        // move both
                        ++start;
                        --end;
                    }
                    else if (product < target)
                    {
                        // make start bigger
                        ++start;
                    }
                    else // if (product > target)
                    {
                        // make end smaller
                        --end;
                    }
                }
            }
            return triplets;
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
                            triplets.Add(new int[] { array[i], array[j], array[k] });
                        }
                    }
                }
            }
            return triplets;
        }
    }
}