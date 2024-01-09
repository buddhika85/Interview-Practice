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
        public static int[] MissingNumbers(int[] nums)
        {
            var all = new HashSet<int>(Enumerable.Range(1, nums.Length + 2));
            all.ExceptWith(nums);
            return all.ToArray();
        }

    }
}