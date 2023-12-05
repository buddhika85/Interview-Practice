using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q25PalindromeCheck
    {
        public static bool IsPalindrome(string str)
        {
            var left = 0;
            var right = str.Length - 1;
            while(left < right)
            {
                if (str[left++] != str[right--])
                    return false;
            }
            return true;
        }
    }
}