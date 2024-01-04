using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Recursion
{
    public class Fibonacci
    {
        // 0, 1, 1, 2, 3, 5, 8, 13, 21, 34
        public static int GetNthFib(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;

            // adding the two numbers before it
            return GetNthFib(n - 1) + GetNthFib(n - 2);
        }
    }
}