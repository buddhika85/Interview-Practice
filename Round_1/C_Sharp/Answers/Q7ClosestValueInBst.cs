using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q7ClosestValueInBst
    {
        public static int FindClosestValueInBst(BST tree, int target)
        {
            var notFound = true;
            var closest = int.MaxValue;
            while(notFound)
            {
                if (tree.value == target)
                {
                    closest = tree.value;
                     notFound = false;
                }

                var currentToTarget = Math.Abs(tree.value - target);
                var closestToTarget = Math.Abs(closest - target);
                if (currentToTarget < closestToTarget)
                    closest = tree.value; 
                if (tree.value <= target && tree.right != null)
                    tree = tree.right;
                else if (tree.value > target && tree.left != null)
                    tree = tree.left;
                else
                    notFound = false;
            }
            return closest;
        }
    }

    public class BST
    {
        public int value;
        public BST? left;
        public BST? right;

        public BST(int value)
        {
            this.value = value;
        }
    }
}