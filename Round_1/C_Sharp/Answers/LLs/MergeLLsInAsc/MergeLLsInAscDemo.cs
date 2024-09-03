using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.MergeLLsInAsc
{
    public static class MergeLLsInAscDemo
    {
        public static void Demo()
        {
            LinkedList headOne = new(2);
            headOne.next = new(6);
            headOne.next.next = new(7);
            headOne.next.next.next = new(8);

            LinkedList headTwo = new(1);
            headTwo.next = new(3);
            headTwo.next.next = new(4);
            headTwo.next.next.next = new(5);
            headTwo.next.next.next.next = new(9);
            headTwo.next.next.next.next.next = new(10);

            WriteLine($"{headOne}");
            WriteLine($"{headTwo}");
            WriteLine($"{mergeLinkedLists(headOne, headTwo)}");
        }


        public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
        {
            LinkedList merged = null;
            // set the first node
            if (headOne.value <= headTwo.value)
            {
                // start with head one
                merged = headOne;
                headOne = headOne.next;                
            }
            else
            {
                // start with head two
                merged = headTwo;
                headTwo = headTwo.next;
            }

            merged.next = null;                      // break from remaining
            LinkedList current = merged;        // last pointer of the merged
            while(headOne != null || headTwo != null)
            {
                if (headOne == null)
                {
                    // can add only head two
                    current.next = headTwo;
                    headTwo = headTwo.next;                    
                }
                else if (headTwo == null)
                {
                    // can add only head one
                    current.next = headOne;
                    headOne = headOne.next;
                }
                else
                {
                    // need to add smallest of head one and head two
                    if (headOne.value <= headTwo.value)
                    {
                        // start with head one
                        current.next = headOne;
                        headOne = headOne.next;                
                    }
                    else
                    {
                        // start with head two
                        current.next = headTwo;
                        headTwo = headTwo.next;
                    }
                }
                current = current.next;                // break from remaining
            }
           
            return merged;
        }
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }

        public override string ToString()
        {
            var node = this;
            StringBuilder sb = new();
            sb.Append(node.value);
            while (node.next != null)
            {
                node = node.next;
                sb.Append($" --> {node.value}");
            }
            return sb.ToString();
        }
    }

}