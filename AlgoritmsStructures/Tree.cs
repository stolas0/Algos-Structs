public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}


public class NTree
{
    static int recursiveTreeTraversal(NTree nTree)
    {
        return 0;
    }

    static int iterativeTreeTraversal(NTree nTree)
    {
        return 0;
    }
}


public class BinaryTree
    {
        TreeNode? root;

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int value)
        {
            var newNode = new TreeNode(value);

            if (root == null)
            {
                root = newNode;
                return;
            }

            var node = root;
            while (node != null)
            {
                if (value >= node.Value)
                {
                    if (node.Right == null)
                    {
                        node.Right = newNode;
                        break;
                    }
                    node = node.Right;
                }
                else
                {
                    if (node.Left == null)
                    {
                        node.Left = newNode;
                        break;
                    }
                    node = node.Left;
                }
            }
        }

        //public void Print() => Print(root);
        public void Print(TreeNode? treeNode = null) => PrintCore(treeNode ?? root);

        private void PrintCore(TreeNode? treeNode)
        {
            if (treeNode == null)
                return;

            Console.WriteLine(treeNode.Value);
            PrintCore(treeNode.Left);
            PrintCore(treeNode.Right);

        }
    }
