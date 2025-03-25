namespace Belly.Algorithm.LeetCode;

public class LeetCode403
{
    public bool CanCross1(int[] stones)
    {
        bool?[][] dp = new bool?[stones.Length][];
        return this.DFS(stones, 0, 0, dp);
    }

    private bool DFS(int[] stones, int index, int step, bool?[][] dp)
    {
        if (index >= stones.Length - 1)
        {
            return true;
        }
        if (dp[index][step].HasValue)
        {
            return dp[index][step].Value;
        }
        for (int distance = step - 1; distance <= step + 1; distance++)
        {
            if (distance > 0)
            {
                int nextIndex = Array.BinarySearch(stones, index + 1, stones.Length - index - 1, stones[index] + distance);
                if (nextIndex >= 0 && this.DFS(stones, nextIndex, distance, dp))
                {
                    dp[index][step] = true;
                    return true;
                }
            }
        }
        dp[index][step] = false;
        return false;
    }

    public bool CanCross2(int[] stones)
    {
        bool[][] dp = new bool[stones.Length][];
        dp[0][0] = true;
        for (int i = 1; i < stones.Length; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                int k = stones[i] - stones[j];
                if (k > j + 1)
                {
                    break;
                }
                dp[i][k] = dp[j][k - 1] || dp[j][k] || dp[j][k + 1];
                if (i >= stones.Length - 1 && dp[i][k])
                {
                    return true;
                }
            }
        }
        return false;
    }
}