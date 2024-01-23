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
            while(currNode != null)
            {
                if (currNode.Value == value)
                {
                    // remove
                    if (currNode == Head)
                    {
                        Head = currNode.Next;
                        if (Head != null)
                            Head.Prev = null;
                        currNode = Head;
                    }
                    else if (currNode ==  Tail)
                    {
                        Tail = currNode.Prev;
                        if (Tail != null)
                            Tail.Next = null;
                        currNode = Tail;
                    }
                    else
                    {
                        var prev = currNode.Prev;
                        prev.Next =  currNode.Next;
                        currNode.Next.Prev = prev;
                        currNode = prev;
                    }
                }

                currNode = currNode.Next;
            }
        }

        public void Remove(Node node)
        {
            // cannot remove in an empty list
            if (Head == null)
                return;

            // single node
            if (Head == Tail && Head == node)
            {
                Head = null;
                Tail = null;
                return;
            }

            // remove head of multi node LL
            if (node == Head)
            {
                Head = Head.Next;
                Head.Prev = null;
                return;
            }

            // remove tail of multi node LL
            if (node == Tail)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
                return;
            }

            // from middle
            var currNode = Head.Next;
            while(currNode != null && currNode != Tail)
            {
                if (currNode == node)
                {
                    currNode.Prev.Next =  currNode.Next;
                    currNode.Next.Prev = currNode.Prev;
                }
            }
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