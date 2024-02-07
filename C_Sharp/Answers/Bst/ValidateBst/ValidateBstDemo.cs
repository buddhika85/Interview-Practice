using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.Bst.ValidateBst
{
    public class ValidateBstDemo
    {
        public static void Test()
        {
            BST bstOne = new(10)
            {
                left = new(5),
                right = new(15)
            };

            bstOne.left.left = new(2);
            bstOne.left.right = new(5);

            bstOne.right.left = new(13);
            bstOne.right.right = new(22);

            bstOne.left.left.left = new(1);

            bstOne.right.left.right = new(14);
            WriteLine($"{ValidateBst(bstOne)}");

            BST bstTwo=new(10)
            {
                left=new(5),
                right=new(15)
            };

            bstTwo.left.left=new(2);
            bstTwo.left.right=new(5);

            bstTwo.right.left=new(13);
            bstTwo.right.right=new(22);

            bstTwo.left.left.left=new(1);

            bstTwo.right.left.right=new(12);        // 13's right cannot be 12 as per BST property
             WriteLine($"{ValidateBst(bstTwo)}");
        }

        public static bool ValidateBst(BST tree) 
        {
            return ValidateBstHelper(tree, int.MinValue, int.MaxValue);
        }

        private static bool ValidateBstHelper(BST tree, int minValue, int maxValue)
        {
            if (tree == null)
                return true;
            if (tree.value < minValue || tree.value >= maxValue)
                return false;
            // means this node and its immediate children values are valid 

            // now validate its left sub tree
            if (!ValidateBstHelper(tree.left, minValue, tree.value))
                return false;
            // now validate its right sub tree
            if (!ValidateBstHelper(tree.right, tree.value, maxValue))
                return false;
            return true;
        }

        // Below attemopt does not valdiate BST property correctly 
        public static bool ValidateBstDoesNotWork(BST tree) {
            var queue = new Queue<BST>();
            queue.Enqueue(tree);
            while(queue.Count > 0)
            {
                var dequeued = queue.Dequeue();
                if (dequeued.left != null)
                {
                    if (dequeued.left != null && dequeued.left.value < dequeued.value)
                    {
                        queue.Enqueue(dequeued.left);
                    }
                    else
                    {
                        return false;
                    }
                }

                if (dequeued.right != null)
                {
                    if (dequeued.right.value >= dequeued.value)
                    {
                        queue.Enqueue(dequeued.right);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
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