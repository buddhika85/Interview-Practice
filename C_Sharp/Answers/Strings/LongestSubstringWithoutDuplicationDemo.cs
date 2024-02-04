using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.Strings
{
    public static class LongestSubstringWithoutDuplicationDemo
    {
        public static void Demo()
        {
            var str = "clementiscap";
            //str  = "abcdeabcdefc";
            WriteLine($"{LongestSubstringWithoutDuplication(str)}");
        }

        public static string LongestSubstringWithoutDuplication(string str)
        {
            var current = $"{str[0]}";
            var maxSoFar = $"{str[0]}";
            for (var i = 1; i < str.Length; i++)
            {
                var foundIndex = current.IndexOf(str[i]);
                if (foundIndex > -1)
                {
                    //current = str.Substring(foundIndex + 1, i-foundIndex);   
                    var start = foundIndex + 1;
                    current = $"{current.Substring(start, current.Length - start)}{str[i]}";            
                }
                else
                {
                    current = $"{current}{str[i]}";
                }
                if (current.Length > maxSoFar.Length)
                {
                    maxSoFar = current;
                }
            }
            return maxSoFar;
        }
    }
}