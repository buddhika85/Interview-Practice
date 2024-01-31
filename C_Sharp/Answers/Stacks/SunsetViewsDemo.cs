using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Stacks
{
    public class SunsetViewsDemo
    {
        public static void Demo()
        {
            SunsetViewsDemo sunsetViewsDemo = new();
            var buildings = new int[] {3,5,4,4,3,1,3,2};
            var direction = "EAST";
            WriteLine($"[{sunsetViewsDemo.SunsetViews(buildings, direction).Display(",")}]");
            direction = "WEST";
            WriteLine($"[{sunsetViewsDemo.SunsetViews(buildings, direction).Display(",")}]");
        }

        // Time - O(n)  --> only one loop
        // Space - O(n) --> we did use additional space to store results which would be maximum of n length (buildings arrays length)
        public List<int> SunsetViews(int[] buildings, string direction)
        {
            var indexes = new List<int>();
            var tallestSeen = int.MaxValue * - 1;
            if (direction == "EAST")
            {
                for (int i = buildings.Length - 1; i >= 0; i--)
                {
                    if (buildings[i] > tallestSeen)
                    {
                        indexes.Insert(0, i);
                        tallestSeen = buildings[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i <= buildings.Length - 1; i++)
                {
                    if (buildings[i] > tallestSeen)
                    {
                        indexes.Add(i);
                        tallestSeen = buildings[i];
                    }
                }
            }
            return  indexes;
        }
    }
}