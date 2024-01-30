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
            WriteLine($"[{obj.MinimumCharactersForWordsOptimal(words).Display(",")}]");

            words = new string[] { "this", "that", "did", "dead", "deed", "them!", "a" };
            WriteLine($"[{obj.MinimumCharactersForWords(words).Display(",")}]");
            WriteLine($"[{obj.MinimumCharactersForWordsOptimal(words).Display(",")}]");
        }

        public string[] MinimumCharactersForWordsOptimal(string[] words)
        {
            var charMaxCounts = new Dictionary<char, int>();
            foreach (var word in words)
            {
                // find character count for a word
                Dictionary<char, int> charCountsForWord = FindUniqueCharCountForWord(word);

                // update common character counts
                UpdateCharCountsForWords(charMaxCounts, charCountsForWord);
            }
            return GenerateAnArray(charMaxCounts);
        }

        private string[] GenerateAnArray(Dictionary<char, int> charMaxCounts)
        {
            var strings = new List<string>();
            foreach (var pair in charMaxCounts)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    strings.Add(pair.Key.ToString());
                }
            }
            return strings.ToArray();
        }

        private void UpdateCharCountsForWords(Dictionary<char, int> charMaxCounts, Dictionary<char, int> charCountsForWord)
        {
            foreach (var item in charCountsForWord)
            {
                if (charMaxCounts.ContainsKey(item.Key))
                {
                    if (charMaxCounts[item.Key] < item.Value)
                    {
                        charMaxCounts[item.Key] = item.Value;
                    }
                }
                else
                {
                    charMaxCounts.Add(item.Key, item.Value);
                }
            }
        }

        private Dictionary<char, int> FindUniqueCharCountForWord(string word)
        {
            var charCountsForWord = new Dictionary<char, int>();
            foreach (var character in word)
            {
                if (charCountsForWord.ContainsKey(character))
                {
                    ++charCountsForWord[character];
                }
                else
                {
                    charCountsForWord.Add(character, 1);
                }
            }

            return charCountsForWord;
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