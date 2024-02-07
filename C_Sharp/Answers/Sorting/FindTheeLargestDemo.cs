using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using C_Sharp.Answers.Strings;
using static System.Console;

namespace C_Sharp.Answers.Sorting
{
    public class FindTheeLargestDemo
    {
        public static void Demo()
        {
            int[] array = new int[] {141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7};
            WriteLine($"{FindThreeLargestNumbers(array).Display(", ")}");
            WriteLine($"{FindThreeLargestNumbersSimplified(array).Display(", ")}");
            WriteLine($"{FindThreeLargestNumbersTryThree(array).Display(", ")}");
        }

        #region try_tree
        // Time - O(n)   --> one loop n number of iterations
        // Space - O(1)  --> did not use any additional space while processing
        public static int[] FindThreeLargestNumbersTryThree(int[] array)
        {
            var results = new int[] {int.MinValue, int.MinValue, int.MinValue};
            for (int i = 0; i < array.Length; i++)
            {
                ShiftAndUpdate(results, array[i]);
            }
            return results;
        }

        private static void ShiftAndUpdate(int[] results, int value)
        {
            if (value > results[2])
            {
                Update(results, value, 2);
            }
            else if (value > results[1])
            {
                Update(results, value, 1);
            }
            else if (value > results[0])
            {
                Update(results, value, 0);
            }
        }

        private static void Update(int[] results, int value, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                if (i  == index)
                {
                    results[i] = value;
                }
                else
                {
                    results[i] = results[i + 1];
                }
            }
        }
        #endregion

        #region try_two
        public static int[] FindThreeLargestNumbersSimplified(int[] array)
        {
            var results = new int[] { int.MinValue, int.MinValue, int.MinValue};
            for (int i = 0; i < array.Length; i++)
            {
                Shift(results, array[i]);
            }
            return results;
        }

        private static void Shift(int[] results, int value)
        {
            if (results[2] < value)
            {
                var shifted = Shift(results, 2, value);
                if (results[1] < shifted)
                {
                    shifted = Shift(results, 1, shifted);
                    if (results[0] < shifted)
                    {
                        Shift(results, 0, shifted);
                    }
                }
            }
            else if (results[1] < value)
            {
                var shifted = Shift(results, 1, value);
                if (results[0] < shifted)
                {
                    Shift(results, 0, shifted);
                }
            }
            else if (results[0] < value)
            {
                Shift(results, 0, value);
            } 
        }

        private static int Shift(int[] results, int index, int value)
        {
            var shifted = results[index];
            results[index] = value;
            return shifted;
        }

        #endregion try_two

        #region try_one
        // Time - O(n)   --> one loop n number of iterations
        // Space - O(1)  --> did not use any additional space while processing
        public static int[] FindThreeLargestNumbers(int[] array)
        {
            int largest, mid, smallest = int.MinValue;
            if (array[0] >= array[1] && array[0] >= array[2])
            {
                largest = array[0];
                if (array[1] >= array[2])
                {
                    mid = array[1];
                    smallest = array[2];
                }
                else
                {
                    mid = array[2];
                    smallest = array[1];
                }
            }
            else if  (array[1] >= array[0] && array[1] >= array[2])
            {
                largest = array[1];
                if (array[0] >= array[2])
                {
                    mid = array[0];
                    smallest = array[2];
                }
                else
                {
                    mid = array[2];
                    smallest = array[0];
                }
            }
            else
            {
                largest = array[2];
                if (array[0] >= array[1])
                {
                    mid = array[0];
                    smallest = array[1];
                }
                else
                {
                    mid = array[1];
                    smallest = array[0];
                }
            }
            for (var i = 3; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    var temp = largest;
                    largest = array[i];
                    if (temp > mid)
                    {
                        var temp2 = mid;
                        mid = temp;
                        if (temp2 > smallest)
                        {
                            smallest = temp2;
                        }
                    }
                }
                else if (array[i] > mid)
                {
                    var temp = mid;
                    mid = array[i];
                    if (temp > smallest)
                    {
                        smallest = temp;
                    }
                }
                else if (array[i] > smallest)
                {
                    smallest = array[i];
                }
            }
            return new int[3] { smallest, mid, largest};
        }

        #endregion try_one
    }
}