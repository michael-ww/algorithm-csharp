namespace Belly.Algorithm.LeetCode;

public class LeetCode333
{
    public int LargestBTSSubTree(TreeNode root)
    {
        return this.DFS(root).Item2;
    }

    private (bool, int, long, long) DFS(TreeNode node)
    {
        if (node == null)
        {
            return (true, 0, long.MinValue, long.MaxValue);
        }
        (bool isLeftBst, int leftBstSize, long leftMax, long leftMin) = this.DFS(node.Left);
        (bool isRightBst, int rightBstSize, long rigthMax, long rightMin) = this.DFS(node.Right);
        long max = Math.Max(node.Value, Math.Max(leftMax, rigthMax));
        long min = Math.Min(node.Value, Math.Min(leftMin, rightMin));
        bool isBst = isLeftBst && isRightBst && node.Value > leftMax && node.Value < rightMin;
        int bstSize = default;
        if (isBst)
        {
            bstSize = leftBstSize + rightBstSize + 1;
        }
        else
        {
            bstSize = Math.Max(leftBstSize, rightBstSize);
        }
        return (isBst, bstSize, max, min);
    }
}
