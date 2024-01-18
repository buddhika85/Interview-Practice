using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs
{
    public class FindMiddleNodeLogic
    {
        public static LinkedList MiddleNode(LinkedList linkedList)
        {
            var length = 1;
            var node =  linkedList;
            while(node.next != null)
            {
                node = node.next;
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

        public static LinkedList MiddleNodeOptimal(LinkedList linkedList)
        {
            var speedXPointer = linkedList;
            var speed2XPointer = linkedList;
            while(speed2XPointer != null && speed2XPointer.next != null)
            {
                speed2XPointer = speed2XPointer.next.next;
                speedXPointer = speedXPointer.next;
            }
            return speedXPointer;
        }
    }
}