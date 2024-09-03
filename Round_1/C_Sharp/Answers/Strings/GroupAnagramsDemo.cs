using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;

namespace C_Sharp.Answers.Strings
{
    public class GroupAnagramsDemo
    {
        public static void Demo()
        {
            List<string> words = new() {"yo", "act", "flop", "tac", "foo", "cat", "oy"};
            GroupAnagrams(words).ForEach(x => {
                Write($"[{x.Display(",")}], ");
            });
        }
        
        public static List<List<string>> GroupAnagrams(List<string> words) 
        {
            var list = new List<List<string>>();
            var dictionary = new Dictionary<string, List<string>>();
            foreach (var item in words)
            {
                var sortedString = SortString(item);
                if (dictionary.ContainsKey(sortedString))
                {
                    dictionary[sortedString].Add(item);
                }
                else
                {
                    dictionary.Add(sortedString, new List<string> { item });
                }
            }

            foreach (var item in dictionary.Values)
            {
                list.Add(item);
            }
            return list;
        }

        private static string SortString(string item)
        {
            var charArray = item.ToArray();
            Array.Sort(charArray);
            return new string(charArray);
        }
    }
}