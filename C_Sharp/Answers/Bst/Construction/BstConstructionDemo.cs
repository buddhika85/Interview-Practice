using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace C_Sharp.Answers.Bst.Construction
{
    public static class BstConstructionDemo
    {
        public static void Demo()
        { 
          BST bst = new BST(20);
          bst.Insert(6);
          bst.Insert(35);
          bst.Insert(3);
          bst.Insert(8);
          bst.Insert(27);
          bst.Insert(55);
          bst.Insert(1);
          bst.Insert(3);
          bst.Insert(25);
          bst.Insert(29);
          bst.Insert(60);

          WriteLine($"{bst.Contains(6)}");
          WriteLine($"{bst.Contains(35)}");
          WriteLine($"{bst.Contains(3)}");
          WriteLine($"{bst.Contains(8)}");
          WriteLine($"{bst.Contains(27)}");
          WriteLine($"{bst.Contains(55)}");
          WriteLine($"{bst.Contains(1)}");
          WriteLine($"{bst.Contains(3)}");
          WriteLine($"{bst.Contains(25)}");
          WriteLine($"{bst.Contains(29)}");
          WriteLine($"{bst.Contains(60)}");

          WriteLine($"{bst.Contains(100)}");
          WriteLine($"{bst.Contains(30)}");
          WriteLine($"{bst.Contains(-1)}");
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

        public BST InsertIterative(int toInsert)
        {
          var tree = this;
          while(true)
          {
            if (toInsert < tree.value)
            {
              // go left
              if (tree.left == null)
              {
                tree.left = new BST(toInsert);
                return this;
              }
              else
              {
                tree = tree.left;
              }
            }
            else
            {
              // go right
              if (tree.right == null)
              {
                tree.right = new BST(toInsert);
                return this;
              }
              else
              {
                tree = tree.right;
              }
            }
          }
        }

        public bool Contains(int toSearch)
        {
            if (toSearch == value)
            {
              return true;
            }
            else if (toSearch < value)
            {
              if (left == null)
              {
                return false;
              }
              else
              {
                return left.Contains(toSearch);
              }
            }
            else
            {
              if (right == null)
              {
                return false;
              }
              else
              {
                return right.Contains(toSearch);
              }
            }
        }

        public bool ContainsIterative(int toSearch)
        {
          if (value == toSearch)
            return true;

          var tree = this;
          while(tree != null)
          {
            if (toSearch  == tree.value)
            {
              return true;
            }
            else if (toSearch < tree.value)
            {
              tree = tree.left;
            }
            else
            {
              tree = tree.right;
            }
          }
          return false;
        }
        
        public BST Remove(int value)
        {
            // Find the Node
            // 1 If the node to remove is a leaf - just remove it
            // 2 If the node to remove has one child - remove it and put that child in the place of removed
            // 3 If the node to remove is has 2 children - Find in order predesesor/successor of the node to remove 
            //  3.1 remove it and in order predesesor/successor in the place of removed


            // Do not edit the return statement of this method.
            return this;
        }
    }
}