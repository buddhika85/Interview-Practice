using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Strings
{
    public class MinimumCharactersForWordsDemo
    {

        public static void Test()
        {
            var obj = new MinimumCharactersForWordsDemo();
            var words = new string[] { "your", "you", "or", "yo" };
            WriteLine($"[{obj.MinimumCharactersForWords(words).Display(",")}]");

            words = new string[] { "this", "that", "did", "dead", "deed", "them!", "a" };
            WriteLine($"[{obj.MinimumCharactersForWords(words).Display(",")}]");
        }
        public string[] MinimumCharactersForWords(string[] words)
        {
            var dictionary = new Dictionary<char, Counts>();
            foreach (var word in words)
            {
                foreach(var character in word)
                {
                    if (dictionary.ContainsKey(character))
                    {
                        var pair = dictionary[character];
                        ++pair.CurrentCountSeen;
                        if (pair.MaxCountSeen < pair.CurrentCountSeen)
                        {
                            pair.MaxCountSeen = pair.CurrentCountSeen;
                        }
                    }
                    else
                    {
                        dictionary.Add(character, new Counts{ MaxCountSeen = 1, CurrentCountSeen = 1});
                    }
                }
                foreach(var pair in dictionary)
                {
                    pair.Value.CurrentCountSeen = 0;
                }
            }

            var strings = new List<string>();
            foreach(var pair in dictionary)
            {
                for (int i = 0; i < pair.Value.MaxCountSeen; i++)
                {
                    strings.Add(pair.Key.ToString());
                }
            }
            return strings.ToArray();
        }
        
    }

    public class Counts
    {
        public int MaxCountSeen { get; set; }
        public int CurrentCountSeen { get;set; }
    }
}