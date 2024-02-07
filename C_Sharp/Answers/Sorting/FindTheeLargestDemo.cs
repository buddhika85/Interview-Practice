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
        }

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
    }
}