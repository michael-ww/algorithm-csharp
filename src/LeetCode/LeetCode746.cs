namespace Belly.Algorithm.LeetCode;

public class LeetCode746
{
    // dp[i] 表示达到下标i的最小花费
    // 由于可以选择下标0或1作为初始阶梯，因此有 dp[0]=dp[1]=0
    // dp[i]=min(dp[i−1]+cost[i−1],dp[i−2]+cost[i−2])
    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost == null || cost.Length <= 0)
        {
            return 0;
        }

        int previous = 0, current = 0;
        for (int i = 2; i <= cost.Length; i++)
        {
            int next = Math.Min(current + cost[i - 1], previous + cost[i - 2]);
            previous = current;
            current = next;
        }

        return current;
    }
}