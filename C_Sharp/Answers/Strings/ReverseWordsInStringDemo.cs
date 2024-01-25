using System.Text;
using static System.Console;

namespace C_Sharp.Answers.Strings
{
    public class ReverseWordsInStringDemo
    {
        public static void Demo()
        {
            List<string> strs = new() {
                "tim is great", "whitespaces    4", "AlgoExpert is the best!"
            };
            foreach (var item in strs)
            {
                WriteLine($"{new ReverseWordsInStringDemo().ReverseWordsInString(item)}");
            }
        }

/*
tim is great
    
_tim

*/
        public string ReverseWordsInString(string str) 
        {
            var stringBuilder = new StringBuilder();
            var index = 0;
            foreach (var character in str)
            {
                if (character != ' ')
                    stringBuilder.Insert(index++, character);
                else
                {
                    index = 0;
                    stringBuilder.Insert(index, ' ');
                }
            }
            return stringBuilder.ToString();
        }

    }
}