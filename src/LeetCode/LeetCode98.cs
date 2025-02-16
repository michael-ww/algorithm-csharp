namespace Belly.Algorithm.LeetCode;

public class LeetCode98
{
    public bool IsValidBST1(TreeNode root)
    {
        int minValue = int.MinValue;
        return this.IsValidBST(root, ref minValue);
    }

    private bool IsValidBST(TreeNode root, ref int previous)
    {
        if (root == null)
        {
            return true;
        }
        bool isLeftValidBST = this.IsValidBST(root.Left, ref previous);
        if (!isLeftValidBST)
        {
            return false;
        }
        if (root.Value <= previous)
        {
            return false;
        }
        else
        {
            previous = root.Value;
        }
        return this.IsValidBST(root.Right, ref previous);
    }

    public bool IsValidBST2(TreeNode root)
    {
        if (root == null)
        {
            return false;
        }

        Stack<TreeNode> stack = new();
        int previous = int.MinValue;
        while (stack.Count > 0 || root != null)
        {
            if (root == null)
            {
                root = stack.Pop();
                if (root.Value <= previous)
                {
                    return false;
                }
                else
                {
                    previous = root.Value;
                }
                root = root.Right;
            }
            else
            {
                stack.Push(root);
                root = root.Left;
            }
        }

        return true;
    }

    public bool IsValidBST3(TreeNode root)
    {
        if (root == null)
        {
            return false;
        }

        int previous = int.MinValue;
        TreeNode current = root;
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
                else if (mostRight.Right == current)
                {
                    mostRight.Right = null;
                }
            }
            if (current.Value <= previous)
            {
                return false;
            }
            previous = current.Value;
            current = current.Right;
        }

        return true;
    }
}
