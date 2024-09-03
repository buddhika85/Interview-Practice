using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs
{
    public class RemoveDuplicatesLogic
    {
        // 1 --> 1 --> 3 --> 4 --> 4 --> 4 --> 5 --> 6 --> 6
        // 1 --> 3 --> 4 --> 5 --> 6
        public static LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            var node = linkedList;
            var curr = node.next;
            while (curr != null)
            {
                if (node.value == curr.value)
                    node.next = null;
                if (node.value < curr.value)
                {
                    node.next = curr;
                    node = curr;
                }
                curr = curr.next;
            }
            return linkedList;
        }
    }
}