using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Bst.Traversal
{
    public static class BstTraversalDemo
    {
        public static void Demo()
        {
            BST bstOne = new(10)
            {
                left = new(5),
                right = new(15)
            };

            bstOne.left.left = new(2);
            bstOne.left.right = new(5);

            bstOne.right.left = null;
            bstOne.right.right = new(22);

            bstOne.left.left.left = new(1);
            bstOne.left.left.right = null;
            WriteLine($"[{BreadthFirstSearch(bstOne).Display(", ")}]");    // [10, 5, 15, 2, 5, 22, 1]

            BST bstTwo = new(20)
            {
                left = new(13),
                right = new(40)
            };

            bstTwo.left.left = new(10);
            bstTwo.left.right = new(13);

            bstTwo.right.left = null;
            bstTwo.right.right = new(43);

            bstTwo.left.left.left = new(8);
            bstTwo.left.left.right = new(11);

            bstTwo.right.right.left = new(41);
            bstTwo.right.right.right = null;
            WriteLine($"[{BreadthFirstSearch(bstTwo).Display(", ")}]");    // [20, 13, 40, 10, 13, 43, 8, 11, 41]
        }

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

        public static List<int> InOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            return new List<int>();
        }

        public static List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            return new List<int>();
        }

        public static List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            // Write your code here.
            return new List<int>();
        }

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
    }

}