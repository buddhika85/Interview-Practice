using System.Text;

namespace C_Sharp.Answers.LLs
{
    public class RemoveKthNodeFromEndLogic
    {
        public static void RemoveKthNodeFromEnd(TestLL.LinkedList head, int k) 
        {
            var pointer1 = head;
            var pointer2 = head;            
            var iPointer2 = 0;
            while(iPointer2 < k && pointer2.Next != null)
            {
                ++iPointer2;
                pointer2 = pointer2.Next;
            }
            if (k - iPointer2 > 1)
                return;                 // not enough elements
            else if (k - iPointer2 == 1)
            {
                // remove head
                // head = head.Next;
                // head.Show();
                // return;

                // var newHead = pointer1.Next;
                // pointer1 = newHead; 
                // head = newHead;
                // head.Show();   
                // return;
                head.Value = head.Next.Value;
                head.Next = head.Next.Next;
                return; 
            }
            while(pointer2.Next != null)
            {
                pointer1 = pointer1.Next;
                pointer2= pointer2.Next;
            }
            // now pointer 2 is at tail
            // pointer 1.next is one to remove
            var newNext = pointer1.Next.Next;          
            pointer1.Next = newNext;
        }

        public static void RemoveKthNodeFromEndLogicTest()
        {
            TestLL.LinkedList linkedList = GetSampleLinkedList();

            linkedList.Show();
            RemoveKthNodeFromEnd(linkedList, 4);
            linkedList.Show();

            linkedList = GetSampleLinkedList();

            linkedList.Show();
            RemoveKthNodeFromEnd(linkedList, 10);
            linkedList.Show();
        }

        private static TestLL.LinkedList GetSampleLinkedList()
        {
            TestLL.LinkedList linkedList = new(0);
            linkedList.Next = new(1);
            linkedList.Next.Next = new(2);
            linkedList.Next.Next.Next = new(3);
            linkedList.Next.Next.Next.Next = new(4);
            linkedList.Next.Next.Next.Next.Next = new(5);
            linkedList.Next.Next.Next.Next.Next.Next = new(6);
            linkedList.Next.Next.Next.Next.Next.Next.Next = new(7);
            linkedList.Next.Next.Next.Next.Next.Next.Next.Next = new(8);
            linkedList.Next.Next.Next.Next.Next.Next.Next.Next.Next = new(9);
            return linkedList;
        }
    }

    

  

}