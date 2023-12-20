
namespace C_Sharp.Answers.Bst
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            var current = this;
            var inserted = false;
            while(!inserted)
            {
                if (value < current.value)
                    if (current.left == null)
                    {
                        current.left = new BST(value);
                        inserted = true;
                    }
                    else
                        current = current.left;
                else
                    if (current.right == null)
                    {
                        current.right = new BST(value);
                        inserted = true;
                    }
                    else
                        current = current.right;
            }
            return this;
        }

        public bool Contains(int value)
        {
            var current = this;
            while(current != null)
            {
                if (value == current.value)
                    return true;
                else if (value < current.value)
                    current = current.left;
                else
                    current =  current.right;
            }
            return false;
        }

        // 1 leaf node removal
        // 2 node with 2 child removal
        // 3 node with one child removal
        public BST Remove(int value)
        {
            if (IsSingleNodeTree())
                return this;

            BST parent = null!;
            var current = this;
            var removed = false;
            while(!removed && current != null)
            {
                if (value < current.value)
                {
                    // go left
                    parent = current;
                    current = current.left;
                }
                else if (value > current.value)
                {
                    // go right
                    parent = current;
                    current = current.right;
                }
                else
                {
                    // found the value
                    if (current.left == null && current.right == null)
                    {
                        // 1 leaf node removal
                        if (current == parent.left)
                        {
                            parent.left = null;
                            removed = true;
                        }
                        else
                        {
                            parent.right = null;
                            removed = true;
                        }
                    } 
                    else if (current.left != null && current.right != null)
                    {
                        // 2 node with 2 child removal
                        var minOfRight = FindMin(current.right);
                        current.value = minOfRight;
                        // remove minRight leaf node from right sub tree
                        current.right.Remove(minOfRight);
                        removed = true;
                    }
                    else
                    {
                        // 3 node with one child removal
                        if (current == parent.left)
                        {
                            parent.left = current.left != null ? current.left : current.right;
                            removed = true;
                        }
                        else
                        {
                            // current is parents right 
                            parent.right = current.left != null ? current.left : current.right;
                            removed = true;
                        }
                    }
                }
            }
            
            return this;
        }

        private int FindMin(BST tree)
        {
            while(tree.left != null)
            {
                tree = tree.left;
            }
            return tree.value;
        }

        private bool IsSingleNodeTree()
        {
            return left == null && right == null;
        }
    }
}