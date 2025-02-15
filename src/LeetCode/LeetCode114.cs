namespace Algorithm.LeetCode;

public class LeetCode114
{
    public void Flatten1(TreeNode root)
    {
        while (root != null)
        {
            TreeNode mostRight = root.Left;
            if (mostRight != null)
            {
                while (mostRight.Right != null)
                {
                    mostRight = mostRight.Right;
                }

                mostRight.Right = root.Right;
                root.Right = root.Left;
                root.Left = null;
            }
            root = root.Right;
        }
    }

    public void Flatten2(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        Stack<TreeNode> stack = new();
        stack.Push(root);
        TreeNode previous = null;
        while (stack.Count > 0)
        {
            TreeNode tn = stack.Pop();
            if (previous != null)
            {
                previous.Right = tn;
                previous.Left = null;
            }
            if (tn.Right != null)
            {
                stack.Push(tn.Right);
            }
            if (tn.Left != null)
            {
                stack.Push(tn.Left);
            }
            previous = tn;
        }
    }
}