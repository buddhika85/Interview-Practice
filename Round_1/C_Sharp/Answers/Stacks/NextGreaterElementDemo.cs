using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Stacks
{
    public class NextGreaterElementDemo
    {
        public static void Demo()
        {
            var nextGreaterElementDemo = new NextGreaterElementDemo();
            var nums = new int[] {2,5,-3,-4,6,7,2};
            WriteLine($"[{nextGreaterElementDemo.NextGreaterElement(nums).Display(", ")}]");
        }

        public int[] NextGreaterElement(int[] array)
        {
            int[] nextGreaterElements = new int [array.Length];
            // set to zero - because initially we do not know next greater value
            for (int i = 0; i < array.Length; i++)
            {
                nextGreaterElements[i] = -1;
            }

            Stack<int> indexesToCheckStack = new Stack<int>();

            // Loop runs 2 times through the input array
            for (int i = 0; i < array.Length * 2; i++)
            {
                var index = i % array.Length;
                while(indexesToCheckStack.TryPeek(out int checkIndex) && array[checkIndex] < array[index])
                {
                    var poppedIndex = indexesToCheckStack.Pop();
                    nextGreaterElements[poppedIndex] = array[index];
                }
                indexesToCheckStack.Push(index);
            }

            return nextGreaterElements;
        }

    }
}