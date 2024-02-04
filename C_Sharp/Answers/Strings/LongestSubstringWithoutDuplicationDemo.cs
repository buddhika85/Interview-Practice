using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Strings
{
    public static class LongestSubstringWithoutDuplicationDemo
    {
        public static void Demo()
        {

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
                    current = str.Substring(foundIndex + 1, i-foundIndex);                    
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