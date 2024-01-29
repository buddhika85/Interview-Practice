using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Strings
{
    public class OneEditDemo
    {

        public static void Test()
        {
            List<(string, string)> values = new()
            {
                ("hello", "hollo"),
                ("hello", "hllo"),
                ("hllo", "hello"),
                ("a", "a"),
                ("a", "b"),

                ("hello", "hol"),
                ("h", "hllo"),
                ("hllo", "he99llo"),
                ("abbc", "acbb"),
                ("abab", "baba"),

                ("a", "bb")
            };
            var oneEditDemo = new OneEditDemo();
            values.ForEach(x => {
                WriteLine(oneEditDemo.OneEdit(x.Item1, x.Item2));
            });
        }

        public bool OneEdit(string stringOne, string stringTwo)
        {
            if (Math.Abs(stringOne.Length - stringTwo.Length) > 1)
                return false;
            
            var stringOneIndex = 0;
            var stringTwoIndex = 0;
            var oneEditUsed = false;
            while(stringOneIndex < stringOne.Length && stringTwoIndex < stringTwo.Length)
            {              
                if (stringOne[stringOneIndex] != stringTwo[stringTwoIndex])
                {
                    if (oneEditUsed)
                    {
                        return false;   // more than one edit needed
                    }
                    else
                    {
                        if (stringOne.Length > stringTwo.Length)
                        {
                            stringOneIndex++;
                        }
                        else if (stringOne.Length < stringTwo.Length)
                        {
                            stringTwoIndex++;
                        }                       
                        oneEditUsed = true;
                    }
                }

                ++stringOneIndex;
                ++stringTwoIndex;
            }

            if (oneEditUsed && stringOne.Length != stringTwo.Length)
            {
                return false;
            }

            return true;
        }

    }
}