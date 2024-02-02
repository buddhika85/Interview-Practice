using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Bst.Construction
{
    public static class BstConstructionDemo
    {
        public static void Demo()
        { }
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

        public BST Insert(int toInsert)
        {
            if (toInsert < value)
            {
              // go left
              if (left == null)
              {
                left = new BST(toInsert);
              }
              else
              {
                left.Insert(toInsert);
              }
            }
            else
            {
              // go right
              if (right == null)
              {
                right = new BST(toInsert);
              }
              else
              {
                right.Insert(toInsert);
              }
            }
            return this;
        }

        public bool Contains(int value)
        {
            // Write your code here.
            return false;
        }

        public BST Remove(int value)
        {
            // Write your code here.
            // Do not edit the return statement of this method.
            return this;
        }
    }
}