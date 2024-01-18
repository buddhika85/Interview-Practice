using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs
{
    public class FindMiddleNodeLogic
    {
        public LinkedList MiddleNode(LinkedList linkedList)
        {
            var length = 1;
            while(linkedList.next != null)
            {
                ++length;
            }
            var middleIndex = length / 2;
            if (middleIndex == 0)
                return linkedList;
            var currIndex = 0;
            while(currIndex < middleIndex)
            {
                linkedList = linkedList.next;
                ++currIndex;
            }
            return linkedList;
        }
    }
}