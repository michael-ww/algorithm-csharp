namespace Algorithm.LeetCode;


public class LeetCode99
{
    public void RecoverTree1(TreeNode root)
    {
        if (root == null)
        {
            return;
        }
        TreeNode x = null, y = null, previous = null;
        Stack<TreeNode> stack = new();
        while (stack.Count > 0 || root != null)
        {
            if (root == null)
            {
                root = stack.Pop();
                if (previous != null && root.Value < previous.Value)
                {
                    y = root;
                    if (x == null)
                    {
                        x = previous;
                    }
                    else
                    {
                        break;
                    }
                }
                previous = root;
                root = root.Right;
            }
            else
            {
                stack.Push(root);
                root = root.Left;
            }
        }

        int temp = x.Value;
        x.Value = y.Value;
        y.Value = temp;
    }

    public void RecoverTree2(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        TreeNode previous = null, x = null, y = null, current = root;
        while (current != null)
        {
            TreeNode mostRight = current.Left;
            if (mostRight != null)
            {
                while (mostRight.Right != null && mostRight.Right != current)
                {
                    mostRight = mostRight.Right;
                }
                if (mostRight.Right == null)
                {
                    mostRight.Right = current;
                    current = current.Left;
                    continue;
                }
                else
                {
                    mostRight.Right = null;
                }
            }
            if (previous != null && current.Value < previous.Value)
            {
                y = current;
                if (x == null)
                {
                    x = previous;
                }
            }
            previous = current;
            current = current.Right;
        }

        if (x != null && y != null)
        {
            int temp = x.Value;
            x.Value = y.Value;
            y.Value = temp;
        }
    }
}
