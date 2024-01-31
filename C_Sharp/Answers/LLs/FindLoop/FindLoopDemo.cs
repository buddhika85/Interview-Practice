using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                head = head.next;
            }
            return null;
        }

    }
}