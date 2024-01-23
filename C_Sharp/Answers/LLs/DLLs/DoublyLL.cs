using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs.DLLs
{
    public class DoublyLL
    {
        public Node Head;
        public Node Tail;

        public void SetHead(Node node)
        {
            // Write your code here.
        }

        public void SetTail(Node node)
        {
            // Write your code here.
        }

        public void InsertBefore(Node node, Node nodeToInsert)
        {
            // Write your code here.
        }

        public void InsertAfter(Node node, Node nodeToInsert)
        {
            // Write your code here.
        }

        public void InsertAtPosition(int position, Node nodeToInsert)
        {
            // Write your code here.
        }

        public void RemoveNodesWithValue(int value)
        {
            var currNode = Head;
            while (currNode != null)
            {
                if (currNode.Value == value)
                {
                    // remove
                    var prev = currNode.Prev;
                    var next = currNode.Next;
                    prev.Next = next;
                    next.Prev = prev;
                    currNode = prev;
                }
                // move foward
                currNode = currNode.Next;
            }
        }

        public void Remove(Node node)
        {
            RemoveNodesWithValue(node.Value);
        }

        public bool ContainsNodeWithValue(int value)
        {
            var node = Head;
            while(node != null)
            {
                if (node.Value == value)
                    return true;
                node = node.Next;
            }
            return false;
        }
    }
}