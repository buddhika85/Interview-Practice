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

            // case 2
            common = new LinkedList(3);
            common.next = new LinkedList(4);
            
            linkedListOne = new LinkedList(1);
            linkedListOne.next = new LinkedList(2);
            linkedListOne.next.next = common;

            linkedListTwo = new LinkedList(5);
            linkedListTwo.next = common;

            WriteLine($"{mergingLinkedListsDemo.MergingLinkedLists(linkedListOne, linkedListTwo)}");
        }


        public LinkedList MergingLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            if (linkedListOne == null || linkedListTwo == null)
                return null;
            if (linkedListOne == linkedListTwo)
                return linkedListOne;

            var linkedListOneLength = GetLinkedListLength(linkedListOne);
            var linkedListTwoLength = GetLinkedListLength(linkedListTwo);

            if (linkedListOneLength > linkedListTwoLength)
            {
                linkedListOne = SetStartNode(linkedListOne, linkedListOneLength - linkedListTwoLength);
            }
            else if (linkedListTwoLength < linkedListOneLength)
            {
                linkedListTwo = SetStartNode(linkedListTwo, linkedListTwoLength - linkedListOneLength);
            }

            while (linkedListOne != null && linkedListTwo != null)
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