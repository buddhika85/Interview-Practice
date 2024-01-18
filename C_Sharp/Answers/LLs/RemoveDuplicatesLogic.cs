using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs
{
    public class RemoveDuplicatesLogic
    {
        public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList)
        {
            var node = linkedList;
            var curr = node.next;
            while (curr != null)
            {
                if (node.value == curr.value)
                    node.next = null;
                else
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