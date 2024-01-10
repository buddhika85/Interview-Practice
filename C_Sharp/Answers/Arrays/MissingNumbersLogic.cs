using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public static class MissingNumbersLogic
    {
        // [1, 4, 5]
        // 1 .. n => n = 3 + 2 => 5
        // possible values => [1,2,3,4,5]
        // 2 missing => [2,3]
        // only 2 missing
        // return sorted 2 missing
        // O(n) time | O(n) space --> because we used one hash set (additional space) and nums array we passed
        public static int[] MissingNumbers(int[] nums)
        {
            var all = new HashSet<int>(Enumerable.Range(1, nums.Length + 2));
            all.ExceptWith(nums);
            return all.ToArray();
        }

        // O(n) time | O(1)  --> space is 1 because we did not use any additonal space
        public static int[] MissingNumbersOptimal(int[] nums)
        {
            var sumCurrent = nums.Sum();
            var sumAll = Enumerable.Range(1, nums.Length + 2).Sum();
            var sumDiff = sumAll - sumCurrent;
            var diffAverage = sumDiff / 2;
            var sumLeftAll = Enumerable.Range(1, diffAverage).Sum();
            var sumRightAll = Enumerable.Range(diffAverage + 1, nums.Length + 2 - diffAverage).Sum();
            var sumLeftCurrent = 0;
            var sumRightCurrent = 0;
            foreach (var item in nums)
            {
                if (item <= diffAverage)
                    sumLeftCurrent += item;
                else
                    sumRightCurrent += item;
            }
            return new int[] {sumLeftAll - sumLeftCurrent, sumRightAll - sumRightCurrent};
        }

    }
}