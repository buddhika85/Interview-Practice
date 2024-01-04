using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Strings
{
    public class CommonCharFinder
    {
        // not efficient - O(n)^2
        public static string[] CommonCharacters(string[] strings)
        {
            var commons = new List<string>();
            for (int i = 0; i < strings[0].Length; i++)
            {
                var character = strings[0][i];
                var isCommon = true;
                for (int j = 1; j < strings.Length && isCommon; j++)
                {
                    if (!strings[j].Contains(character))
                        isCommon = false;
                }
                if (isCommon)
                    commons.Add(character.ToString());
            }
            return commons.ToArray();
        }
    }
}