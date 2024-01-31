using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.LLs.FindLoop
{
    public class LinkedList
    {
        public int value;
        public LinkedList next = null;

        public LinkedList(int value)
        {
            this.value = value;
        }
    }

    public class FindLoopDemo
    {
        public static void Demo()
        {
            LinkedList linkedList = new(0);
            linkedList.next = new LinkedList(1);
            linkedList.next.next = new LinkedList(2);
            linkedList.next.next.next = new LinkedList(3);
            var loop = new LinkedList(4);
            linkedList.next.next.next.next = loop;
            linkedList.next.next.next.next.next = new LinkedList(5);
            linkedList.next.next.next.next.next.next = new LinkedList(6);
            linkedList.next.next.next.next.next.next.next = new LinkedList(7);
            linkedList.next.next.next.next.next.next.next.next = new LinkedList(8);
            linkedList.next.next.next.next.next.next.next.next.next = new LinkedList(9);
            linkedList.next.next.next.next.next.next.next.next.next.next = loop;

            WriteLine($"{FindLoop(linkedList).value}");
        }
        public static LinkedList FindLoop(LinkedList head)
        {
            if (head == null)
                return null;
            var alreadySeen = new Dictionary<LinkedList, bool>();
            alreadySeen.Add(head, true);
            head = head.next;
            while(head != null)
            {
                alreadySeen.TryGetValue(head, out bool found);
                if (found)
                    return head;
                else
                    alreadySeen.Add(head, true);
                head = head.next;
            }
            return null;
        }
    }
}