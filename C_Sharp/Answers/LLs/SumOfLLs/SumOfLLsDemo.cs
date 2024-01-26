using static System.Console;
using System.Text;
using System.Linq;

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

    public class SumOfLLsDemo
    {
        public static void Demo()
        {
            SumOfLLsDemo sumOfLLsDemo = new();
            var linkedListOne = new LinkedList(2);
            var linkedListTwo = new LinkedList(9);
            PopulateLinkedList(linkedListOne, new List<int> { 4, 7, 1 });
            PopulateLinkedList(linkedListTwo, new List<int> { 4, 5 });
            WriteLine(linkedListOne);
            WriteLine(linkedListTwo);
            var sumLinkedList = sumOfLLsDemo.SumOfLinkedLists(linkedListOne, linkedListTwo);
            WriteLine(sumLinkedList);
        }

        private static void PopulateLinkedList(LinkedList linkedList, List<int> nums)
        {
            if (nums.Count() == 0)
                return;
            var tempLinkedList = linkedList;
            while (tempLinkedList.next != null)
                tempLinkedList = tempLinkedList.next;
            var first = nums[0];
            nums.RemoveAt(0);
            tempLinkedList.next = new LinkedList(first);
            PopulateLinkedList(linkedList, nums);
        }

        public LinkedList SumOfLinkedLists(LinkedList linkedListOne, LinkedList linkedListTwo)
        {
            int numOne = GetNumber(linkedListOne);
            int numTwo = GetNumber(linkedListTwo);
            string sum = $"{numOne + numTwo}";
            return GenerateLinkedList(sum.Reverse());
        }

        private LinkedList GenerateLinkedList(IEnumerable<char> sum)
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
            while (linkedList != null)
            {
                sb.Insert(0, linkedList.value);
                linkedList = linkedList.next;
            }
            return int.Parse(sb.ToString());
        }
    }
}