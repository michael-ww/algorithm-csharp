namespace Algorithm.LeetCode;

public class LeetCode285
{
    public TreeNode InorderSuccessor(TreeNode root, TreeNode node)
    {
        if (root == null)
        {
            return null;
        }
        if (root.Value <= node.Value)
        {
            return this.InorderSuccessor(root.Right, node);
        }
        else
        {
            TreeNode left = this.InorderSuccessor(root.Left, node);
            return left ?? root;
        }
    }
}
