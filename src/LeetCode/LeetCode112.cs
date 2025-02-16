namespace Belly.Algorithm.LeetCode;

public class LeetCode112
{
    public bool HasPathSum(TreeNode root, int target)
    {
        if (root == null)
        {
            return false;
        }
        if (root.Left == null && root.Right == null)
        {
            return root.Value == target;
        }

        return this.HasPathSum(root.Left, target - root.Value) || this.HasPathSum(root.Right, target - root.Value);
    }
}
