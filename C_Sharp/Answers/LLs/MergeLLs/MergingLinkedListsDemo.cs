using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.MergeLLs
{
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
            while(node.next != null)
            {
                node = node.next;
                sb.Append($" --> {node.value}");
            }
            return sb.ToString();
        }
    }


    public class MergingLinkedListsDemo
    {

        public static void Demo()
        {
            var common = new LinkedList(1);
            common.next = new LinkedList(4);
            
            var linkedListOne = new LinkedList(2);
            linkedListOne.next = new LinkedList(3);
            linkedListOne.next.next = common;

            var linkedListTwo = new LinkedList(8);
            linkedListTwo.next = new LinkedList(7);
            linkedListTwo.next.next = common;

            var mergingLinkedListsDemo = new MergingLinkedListsDemo();
            WriteLine($"{mergingLinkedListsDemo.MergingLinkedLists(linkedListOne, linkedListTwo)}");
            WriteLine($"{mergingLinkedListsDemo.MergingLinkedListsAlternative(linkedListOne, linkedListTwo)}");

            // case 2
            common = new LinkedList(3);
            common.next = new LinkedList(4);
            
            linkedListOne = new LinkedList(1);
            linkedListOne.next = new LinkedList(2);
            linkedListOne.next.next = common;

            linkedListTwo = new LinkedList(5);
            linkedListTwo.next = common;

            WriteLine($"{mergingLinkedListsDemo.MergingLinkedLists(linkedListOne, linkedListTwo)}");
            WriteLine($"{mergingLinkedListsDemo.MergingLinkedListsAlternative(linkedListOne, linkedListTwo)}");

            // case 3
            common = new LinkedList(1);
            linkedListOne = common;

            linkedListTwo = new LinkedList(2);
            linkedListTwo.next = new LinkedList(3);
            linkedListTwo.next.next = new LinkedList(4);
            linkedListTwo.next.next.next = common;

            WriteLine($"{mergingLinkedListsDemo.MergingLinkedLists(linkedListOne, linkedListTwo)}");
            WriteLine($"{mergingLinkedListsDemo.MergingLinkedListsAlternative(linkedListOne, linkedListTwo)}");
        }

        public LinkedList MergingLinkedListsAlternative(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            if (linkedListOne == null || linkedListTwo == null)
                return null;
            
            var pointerOne = linkedListOne;
            var pointerTwo = linkedListTwo;
            var reassignedOne = false;
            var reassignedTwo = false;

            while(pointerOne != pointerTwo)
            {
                if (pointerOne.next == null)
                {
                    if (reassignedOne)
                        return null;
                    else
                    {
                        pointerOne = linkedListTwo;
                        reassignedOne = true;
                    }
                }
                else
                {
                    pointerOne = pointerOne.next;
                }

                if (pointerTwo.next == null)
                {
                    if (reassignedTwo)
                        return null;
                    else
                    {
                        pointerTwo = linkedListOne;
                        reassignedTwo = true;
                    }
                }
                else
                {
                    pointerTwo = pointerTwo.next;
                }
            }

            return pointerOne;
        }

        // Time complexity
        // O(n) + O(m) + O(n - m) or O(m - n) + O(n - m) or O(m - n)
        // assuming n > m 
        // O(n) + O(n) + O(n - m) + O(n - m)
        // 2 O(n) + 2 O(n - m)
        // dropping constants 
        // O(n) + O(n - m)
        // worst case n >>>>>>> m --> n is very large comparing m
        // 2 O(n)
        // dropping constants
        // O(n)

        // space comlexity
        // O(1) --> we did not use any additional space
        public LinkedList MergingLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            if (linkedListOne == null || linkedListTwo == null)
                return null;
            if (linkedListOne == linkedListTwo)
                return linkedListOne;

            var linkedListOneLength = GetLinkedListLength(linkedListOne);   // O(n)
            var linkedListTwoLength = GetLinkedListLength(linkedListTwo);   // O(m)

            if (linkedListOneLength > linkedListTwoLength)
            {
                linkedListOne = SetStartNode(linkedListOne, linkedListOneLength - linkedListTwoLength);     // O(n - m)
            }
            else if (linkedListTwoLength > linkedListOneLength)
            {
                linkedListTwo = SetStartNode(linkedListTwo, linkedListTwoLength - linkedListOneLength);     // O(m - n)
            }

            while (linkedListOne != null && linkedListTwo != null)      // O(n - m) or O(m - n)
            {
                if (linkedListOne == linkedListTwo)
                    return linkedListOne;
                linkedListOne = linkedListOne.next;
                linkedListTwo = linkedListTwo.next;
            }
            return null;
        }

        private LinkedList SetStartNode(LinkedList linkedList, int toMoveFwd)
        {
            while(toMoveFwd > 0)
            {
                linkedList = linkedList.next;
                --toMoveFwd;
            }
            return linkedList;
        }

        private int GetLinkedListLength(LinkedList linkedList)
        {
            var length = 1;
            while (linkedList.next != null)
            {
                length++;
                linkedList = linkedList.next;
            }
            return length;
        }
    }
}