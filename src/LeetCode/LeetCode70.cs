namespace Belly.Algorithm.LeetCode;

public class LeetCode70
{
    public int ClimbStairs1(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        if (n == 2)
        {
            return 2;
        }

        return this.ClimbStairs1(n - 1) + this.ClimbStairs1(n - 2);
    }

    public int ClimbStairs2(int n)
    {
        Dictionary<int, int> cache = new();
        return this.ClimbStairs22(n, cache);
    }

    private int ClimbStairs22(int n, Dictionary<int, int> cache)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        if (n == 2)
        {
            return 2;
        }

        if (cache.TryGetValue(n, out int value))
        {
            return value;
        }
        else
        {
            int ways = this.ClimbStairs22(n - 1, cache) + this.ClimbStairs22(n - 2, cache);
            cache.Add(n, ways);
            return ways;
        }
    }

    public int ClimbStairs3(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        dp[2] = 2;
        for (int i = 3; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n];
    }

    public int ClimbStairs4(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        int n1 = 1, n2 = 2, sum = 0;
        for (int i = 3; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
        }

        return sum;
    }
}
