namespace Algorithm.LeetCode;

public class LeetCode111
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        if (root.Left == null && root.Right == null)
        {
            return 1;
        }
        int left = int.MaxValue, right = int.MaxValue;
        if (root.Left != null)
        {
            left = this.MinDepth(root.Left);
        }
        if (root.Right != null)
        {
            right = this.MinDepth(root.Right);
        }
        return Math.Min(left, right) + 1;
    }
}