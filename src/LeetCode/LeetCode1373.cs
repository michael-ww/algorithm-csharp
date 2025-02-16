namespace Belly.Algorithm.LeetCode;

public class LeetCode1373
{
    public int MaxSumBST(TreeNode root)
    {
        return this.DFS(root).Item3;
    }

    private (bool, int, int, long, long) DFS(TreeNode node)
    {
        if (node == null)
        {
            return (true, 0, 0, long.MinValue, long.MaxValue);
        }
        (bool isLeftBst, int leftSum, int leftBstSum, long leftMax, long leftMin) = this.DFS(node.Left);
        (bool isRightBst, int rightSum, int rightBstSum, long rightMax, long rightMin) = this.DFS(node.Right);
        long max = Math.Max(node.Value, Math.Max(leftMax, rightMax));
        long min = Math.Min(node.Value, Math.Min(leftMin, rightMin));
        bool isBst = isLeftBst && isRightBst && node.Value > leftMax && node.Value < rightMin;
        int sum = leftSum + rightSum + node.Value;
        int bstSum = Math.Max(leftBstSum, rightBstSum);
        if (isBst)
        {
            bstSum = Math.Max(sum, bstSum);
        }
        return (isBst, sum, bstSum, max, min);
    }
}