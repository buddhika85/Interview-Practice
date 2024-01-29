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

                // ("hello", "hol"),
                // ("h", "hllo"),
                // ("hllo", "he99llo"),
                // ("abbc", "acbb"),
                // ("abab", "baba"),

                ("a", "bb"),
                ("ba", "bba")
            };
            var oneEditDemo = new OneEditDemo();
            values.ForEach(x => {
                WriteLine(oneEditDemo.OneEdit(x.Item1, x.Item2));
            });
        }

        public bool OneEdit(string stringOne, string stringTwo)
        {
            var lengthGap = Math.Abs(stringOne.Length - stringTwo.Length);
            if (lengthGap > 1)
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
                        else
                        {
                            ++stringOneIndex;
                            ++stringTwoIndex;
                        }
                        oneEditUsed = true;
                    }
                }
                else
                {
                    ++stringOneIndex;
                    ++stringTwoIndex;
                }
            }

            if (lengthGap > 1 || (lengthGap == 1 && ((stringOne.Length > stringTwo.Length && stringOneIndex == stringOne.Length - 1) || (stringTwo.Length > stringOne.Length && stringTwoIndex == stringTwo.Length - 1))))
                return false;

            return true;
        }

    }
}