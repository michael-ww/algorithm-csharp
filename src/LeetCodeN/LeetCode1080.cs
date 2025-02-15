namespace Algorithm.LeetCode;

public class LeetCode1080
{
    public TreeNode SufficientSubset(TreeNode root, int limit)
    {
        if (root.Left == null && root.Right == null)
        {
            return limit < root.Value ? root : null;
        }
        if (root.Left != null)
        {
            root.Left = this.SufficientSubset(root.Left, limit - root.Value);
        }
        if (root.Right != null)
        {
            root.Right = this.SufficientSubset(root.Right, limit - root.Value);
        }

        return root.Left == null && root.Right == null ? null : root;
    }
}
