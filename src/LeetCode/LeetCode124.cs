namespace Belly.Algorithm.LeetCode;

public class LeetCode124
{
    public int MaxPathSum(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int sum = int.MinValue;
        this.MaxPathSum(root, ref sum);
        return sum;
    }

    private int MaxPathSum(TreeNode root, ref int sum)
    {
        if (root == null)
        {
            return 0;
        }

        int left = Math.Max(this.MaxPathSum(root.Left, ref sum), 0);
        int right = Math.Max(this.MaxPathSum(root.Right, ref sum), 0);
        sum = Math.Max(sum, root.Value + left + right); // 当前节点的最大路径和
        return root.Value + Math.Max(left, right); // 当前节点的最大贡献值
    }
}
