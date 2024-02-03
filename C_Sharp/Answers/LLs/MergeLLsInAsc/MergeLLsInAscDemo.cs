using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs.MergeLLsInAsc
{
    public static class MergeLLsInAscDemo
    {
        public static void Demo()
        {
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
            LinkedList current = merged.next;        // last pointer of the merged
            while(headOne != null || headTwo != null)
            {
                if (headOne != null)
                {
                    // can add only head two
                    current = headTwo;
                    headTwo = headTwo.next;                    
                }
                else if (headTwo != null)
                {
                    // can add only head one
                    current = headOne;
                    headOne = headOne.next;
                }
                else
                {
                    // need to add smallest of head one and head two
                    if (headOne.value <= headTwo.value)
                    {
                        // start with head one
                        current = headOne;
                        headOne = headOne.next;                
                    }
                    else
                    {
                        // start with head two
                        current = headTwo;
                        headTwo = headTwo.next;
                    }
                }
                current.next = null;                // break from remaining
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
    }

}