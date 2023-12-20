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
            // Write your code here.
            return false;
        }

        public BST Remove(int value)
        {
            if (IsSingleNodeTree())
                return this;
            
            // To Do
            return this;
        }

        private bool IsSingleNodeTree()
        {
            return left == null && right == null;
        }
    }
}