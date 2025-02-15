namespace Algorithm.LeetCode;

public class LeetCode235
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        while (root != p && root != q)
        {
            if (root.Value > Math.Min(p.Value, q.Value) && root.Value < Math.Max(p.Value, q.Value))
            {
                break;
            }
            root = root.Value < Math.Min(p.Value, q.Value) ? root.Right : root.Left;
        }

        return root;
    }
}
