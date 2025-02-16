namespace Belly.Algorithm.LeetCode;

public class LeetCode222
{
    public int CountNodes1(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = this.CountNodes1(root.Left);
        int right = this.CountNodes1(root.Right);
        return left + right + 1;
    }

    public int CountNodes2(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int height = 0;
        TreeNode current = root;
        while (current.Left != null)
        {
            height++;
            current = current.Left;
        }

        int low = 1 << height, high = (1 << (height + 1)) - 1;
        while (low < high)
        {
            int middle = (high + low) >> 1;
            if (this.Exists(root, height, middle))
            {
                low = middle;
            }
            else
            {
                high = middle - 1;
            }
        }

        return low;
    }

    private bool Exists(TreeNode tn, int height, int count)
    {
        int bits = 1 << (height - 1);
        TreeNode node = tn;
        while (node != null && bits > 0)
        {
            if ((bits & count) == 0)
            {
                node = node.Left;
            }
            else
            {
                node = node.Right;
            }
            bits >>= 1;
        }
        return node != null;
    }
}
