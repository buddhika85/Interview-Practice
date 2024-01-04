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
                if (isCommon && !commons.Contains(character.ToString()))
                    commons.Add(character.ToString());
            }
            return commons.ToArray();
        }

        public static string[] CommonCharactersSolTwo(string[] strings)
        {
            var commons = new HashSet<char>();
            var orderedByLength = strings.OrderBy(x => x.Length);
            var smallest = orderedByLength.First();
            smallest.ToList().ForEach(x => commons.Add(x));
            orderedByLength.SkipWhile(x => x == smallest).ToList().ForEach(x => {
                foreach (var commonItemSoFar in commons)
                    if (!x.Contains(commonItemSoFar))
                        commons.Remove(commonItemSoFar);
            });
            var list = new List<string>();
            foreach (var common in commons)
                list.Add(common.ToString());
            return list.ToArray();
        }


        public static string[] CommonCharactersSolThree(string[] strings)
        {
            var orderedByLength = strings.OrderBy(x => x.Length);
            var smallest = orderedByLength.First();
            var commons = new HashSet<char>(smallest);
            orderedByLength.SkipWhile(x => x == smallest).ToList().ForEach(x => {              
                commons = new HashSet<char>(commons.Intersect(new HashSet<char>(x)));
            });
            return commons.Select(x => x.ToString()).ToArray();
        }
    }
}