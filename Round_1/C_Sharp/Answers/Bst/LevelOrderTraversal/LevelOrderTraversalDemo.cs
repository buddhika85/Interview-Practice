using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Bst.LevelOrderTraversal
{
    public static class LevelOrderTraversalDemo
    {
        public static void Demo()
        {}
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public void Insert(int?[] array)
        {
            if (array[0] == null)
                return;
            value = array[0].Value;
            var i = 1;
            var queue = new Queue<BST>();
            queue.Enqueue(this);
            while(i < array.Length)
            {
                var dequeued = queue.Dequeue();
                if (++i < array.Length && array[i] != null)
                {
                    if (dequeued.left != null)
                    {
                        dequeued.left = new BST(array[i].Value);
                        queue.Enqueue(dequeued.left);
                    }
                    else
                    {
                        dequeued.right = new BST(array[i].Value);
                        queue.Enqueue(dequeued.right);
                    }
                }
            }
        }
    }
}