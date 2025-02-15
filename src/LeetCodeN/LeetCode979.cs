namespace Algorithm.LeetCode;

public class LeetCode979
{
    public int DistributeCoins(TreeNode root)
    {
        return this.DFS(root).Item3;
    }

    private (int, int, int) DFS(TreeNode node)
    {
        if (node == null)
        {
            return (0, 0, 0);
        }
        (int leftSize, int leftCoins, int leftMoves) = this.DFS(node.Left);
        (int rightSize, int rightCoins, int rightMoves) = this.DFS(node.Right);
        int size = leftSize + rightSize + 1;
        int coins = leftCoins + rightCoins + node.Value;
        int moves = leftMoves + rightMoves + Math.Abs(leftCoins - leftSize) + Math.Abs(rightCoins - rightSize);
        return (size, coins, moves);
    }
}