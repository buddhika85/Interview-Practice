using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs.SumOfLLs
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
    }

    public class SumOfLLsDemo
    {
        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            int numOne = GetNumber(linkedListOne);
            int numTwo = GetNumber(linkedListTwo);
            string sum = $"{numOne + numTwo}";
            return GenerateLinkedList(sum);
        }

        private static LinkedList GenerateLinkedList(string sum)
        {
            LinkedList resultHead = null;
            LinkedList lastNode = null;
            foreach (char str in sum)
            {
                if (resultHead == null)
                {
                    resultHead = new LinkedList(int.Parse(str.ToString()));
                    lastNode = resultHead;
                }
                else
                {
                    lastNode.next = new LinkedList(int.Parse(str.ToString()));
                    lastNode = lastNode.next;
                }
            }
            return resultHead;
        }

        private int GetNumber(LinkedList linkedList)
        {
            var sb = new StringBuilder();
            while(linkedList != null)
            {
                sb.Insert(0, linkedList.value);
                linkedList = linkedList.next;
            }
            return int.Parse(sb.ToString());
        }
    }
}