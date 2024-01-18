using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public static class BestSeatLogic
    {
        // assumption - index 0 seat and last seat of the array always filled
        // 0, 1, 2, 3, 4, 5, 6      - indexing
        // 1, 0, 1, 0, 0, 0, 1
        //       l           r
        // bestSpace = 3
        // bestSeat = 4
        public static int BestSeat(int[] seats)
        {
            var left = 0;
            var right = 1;
            var bestSeat = -1;
            var bestSpace = 0;
            while(right < seats.Length)
            {
                if (seats[right] == 1)
                {
                    var currentSpace = right - left - 1;
                    if (currentSpace > bestSpace)
                    {
                        bestSpace = currentSpace;
                        bestSeat = (right + left) / 2;
                    }
                    left = right;                   // move left to right
                }
                ++right;
            }
            return  bestSeat;
        }
    }
}