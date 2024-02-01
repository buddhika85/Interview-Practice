using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.LLs.ReverseLinkedList
{
    public class ReverseLinkedListDemo
    {
        public static LinkedList ReverseLinkedList(LinkedList head) {
            var pointerOne = head;
            var pointerTwo = head.Next;
            while(pointerTwo != null)
            {
                var temp = pointerTwo;
                pointerTwo = pointerTwo.Next;
                temp.Next = pointerOne;
                pointerOne =  temp;
            }
            return pointerOne;
        }

    }

    public class LinkedList {
    public int Value;
    public LinkedList Next = null;

    public LinkedList(int value) {
      this.Value = value;
    }
  }
}