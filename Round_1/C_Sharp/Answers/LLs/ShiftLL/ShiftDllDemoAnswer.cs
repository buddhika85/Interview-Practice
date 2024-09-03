using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.ShiftLL
{
    public class ShiftDllDemoAnswer
    {
        internal static void Demo()
        {
            LinkedList linkedList = new(0);
            linkedList.next = new(1);
            linkedList.next.next = new(2);
            linkedList.next.next.next = new(3);
            linkedList.next.next.next.next = new(4);
            linkedList.next.next.next.next.next = new(5);
            WriteLine($"{linkedList}");

            // var newHead = ShiftLinkedList(linkedList, 2);
            var newHead = ShiftLinkedList(linkedList, 2);
            WriteLine(newHead);
        }

        // Time: O(n) Space: O(1)
        public static LinkedList ShiftLinkedList(LinkedList head, int k)
        {
            if (head == null || k == 0)
                return head;

            int listLength = 0;
            LinkedList listTail = head;
            while (listTail.next != null)
            {
                listLength++;
                listTail = listTail.next;
            }
            listLength++; // Increment to count the last node

            int offSet = Math.Abs(k) % listLength;
            if (offSet == 0)
                return head;

            int newTailPosition = k > 0 ? listLength - offSet : offSet;

            LinkedList newTail = head;
            for (int i = 1; i < newTailPosition; i++)
            {
                newTail = newTail.next;
            }

            LinkedList newHead = newTail.next;
            newTail.next = null;
            listTail.next = head;

            return newHead;

        }

       

        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                next = null;
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
}