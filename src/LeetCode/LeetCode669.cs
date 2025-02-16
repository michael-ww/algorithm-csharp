namespace Belly.Algorithm.LeetCode;

public class LeetCode669
{
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return null;
        }
        if (root.Value < low)
        {
            return this.TrimBST(root.Right, low, high);
        }
        if (root.Value > high)
        {
            return this.TrimBST(root.Left, low, high);
        }
        root.Left = this.TrimBST(root.Left, low, high);
        root.Right = this.TrimBST(root.Right, low, high);
        return root;
    }
}
