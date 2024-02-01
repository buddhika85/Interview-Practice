using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.ReverseLinkedList
{
    public class ReverseLinkedListDemo
    {
        public static void Test()
        {
            LinkedList linkedList = new(0);
            linkedList.Next = new(1);
            linkedList.Next.Next = new(2);
            linkedList.Next.Next.Next = new(3);
            linkedList.Next.Next.Next.Next = new(4);
            linkedList.Next.Next.Next.Next.Next = new(5);

            WriteLine($"{linkedList}");
            WriteLine($"{ReverseLinkedList(linkedList)}");
        }

        // Time complexity : O(n) --> we need to go through entire linked list
        // Space : O(1) --> we did not use any additional space, we did the reverse in place
        public static LinkedList ReverseLinkedList(LinkedList head)
        {
            var pointerOne = head;
            var pointerTwo = head.Next;
            head.Next = null;           // make head tail
            while (pointerTwo != null)
            {
                var temp = pointerTwo;
                pointerTwo = pointerTwo.Next;
                temp.Next = pointerOne;
                pointerOne = temp;
            }
            return pointerOne;
        }
    }

    public class LinkedList
    {
        public int Value;
        public LinkedList Next = null;

        public LinkedList(int value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            var node = this;
            StringBuilder sb = new();
            sb.Append(node.Value);
            while (node.Next != null)
            {
                node = node.Next;
                sb.Append($" --> {node.Value}");
            }
            return sb.ToString();
        }
    }
}