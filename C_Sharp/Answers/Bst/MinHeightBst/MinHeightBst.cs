using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Bst.MinHeightBst
{
    public class MinHeightBstDemo
    {
        public static void Demo()
        {
            List<int> list = new() {1,2,5,7,10,13,14,15,22};
            var bst = MinHeightBst(list);
            WriteLine($"[{BST.BreadthFirstSearch(bst).Display(", ")}]");        // should display level by level
        }

        public static BST MinHeightBst(List<int> array)
        {
            // Write your code here.
            return ConstructMinHeightyBst(array, null, 0, array.Count - 1);
        }

        // Time: O(nlog(n))
        // Space : O(n) 
        private static BST ConstructMinHeightyBst(List<int> array, BST bst, int startIndex, int endIndex)
        {
            // recurision termination method
            if (endIndex < startIndex)
                return bst;
            var midIndex = (startIndex + endIndex) / 2;
            var valueToAdd = array[midIndex];
            if (bst == null)
                bst = new BST(valueToAdd);                                      // root
            else
                bst.insert(valueToAdd);                                         // current
            ConstructMinHeightyBst(array, bst, startIndex, midIndex - 1);       // left
            ConstructMinHeightyBst(array, bst, midIndex + 1, endIndex);       // right
            return bst;
        }

        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }

            public void insert(int value)
            {
                if (value < this.value)
                {
                    if (left == null)
                    {
                        left = new BST(value);
                    }
                    else
                    {
                        left.insert(value);
                    }
                }
                else
                {
                    if (right == null)
                    {
                        right = new BST(value);
                    }
                    else
                    {
                        right.insert(value);
                    }
                }
            }

            // Time: O(n)  --> because we used one loop [enque and deque and list.add are constant time operations]
            // Space - O(n)^2       --> because we used additionally a queue and a list of maximum length n
            public static List<int> BreadthFirstSearch(BST tree)
            {
                var queue = new Queue<BST>();
                queue.Enqueue(tree);
                var list = new List<int>();
                while (queue.Count > 0)
                {
                    var dequeued = queue.Dequeue();
                    list.Add(dequeued.value);
                    if (dequeued.left != null)
                        queue.Enqueue(dequeued.left);
                    if (dequeued.right != null)
                        queue.Enqueue(dequeued.right);
                }
                return list;
            }
        }

    }
}