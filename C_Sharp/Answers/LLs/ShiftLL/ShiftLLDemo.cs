using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.ShiftLL
{
    public class ShiftLLDemo
    {
        public static void Demo()
        {
            LinkedList linkedList = new(0);
            linkedList.next = new(1);
            linkedList.next.next = new(2);
            linkedList.next.next.next = new(3);
            linkedList.next.next.next.next = new(4);
            linkedList.next.next.next.next.next = new(5);
            WriteLine($"{linkedList}");

            // var newHead = ShiftLinkedList(linkedList, 2);
            var newHead = ShiftLinkedList(linkedList, 6);
            WriteLine(newHead);
        }

        // Time: O(n) Space: O(1)
        public static LinkedList ShiftLinkedList(LinkedList head, int k)
        {
            if (k == 0)
            {
                return head;            // nothing to do
            }          

            // find length
            var length = FindLength(head);

            // tackle large numbers
            k = k % length;
            if (k == 0)
            {
                return head;            // nothing to do
            }

            // tackle negetive numbers
            if (k < 0)
            {
                k = Math.Abs(0 + k);
            }

            // find new tail
            var tailIndex = length - k;
            // get tail
            LinkedList newTail = GetNthNode(head, tailIndex);
            WriteLine($"Length: {length}, Tail Index: {tailIndex}\n{newTail}");
            // manipulate
            head = Shift(head, newTail);
            
            return head;
        }

        private static LinkedList Shift(LinkedList head, LinkedList newTail)
        {
            var temp = head;
            head = newTail.next;
            newTail.next = null;        // making it tail

            // attach pervious head (temp) to end
            var node = head;
            while(node.next != null)
            {
                node = node.next;
            }
            node.next = temp;
            return head;
        }

        private static LinkedList GetNthNode(LinkedList head, int tailIndex)
        {            
            if (tailIndex == 0)
            {
                return head;
            }
            var index = 1;
            while(head.next != null && index != tailIndex)
            {
                head = head.next;
                ++index;
            }
            return head;
        }

        private static int FindLength(LinkedList head)
        {
            var count = 0;
            var node = head;
            while(node != null)
            {
                ++count;
                node = node.next;
            }
            return count;
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