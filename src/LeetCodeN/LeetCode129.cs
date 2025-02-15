namespace Algorithm.LeetCode;

public class LeetCode129
{
    public int SumNumbers(TreeNode root)
    {
        ArgumentNullException.ThrowIfNull(root);
        return this.SumNumbers(root, 0);
    }

    private int SumNumbers(TreeNode root, int sum)
    {
        if (root == null)
        {
            return 0;
        }
        sum = sum * 10 + root.Value;
        if (root.Left == null && root.Right == null)
        {
            return sum;
        }
        return this.SumNumbers(root.Left, sum) + this.SumNumbers(root.Right, sum);
    }
}
