namespace Algorithm.LeetCode;

public class LeetCode236
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q)
        {
            return root;
        }

        TreeNode left = this.LowestCommonAncestor(root.Left, p, q);
        TreeNode right = this.LowestCommonAncestor(root.Right, p, q);
        return left != null && right != null ? root : left ?? right;
    }
}
