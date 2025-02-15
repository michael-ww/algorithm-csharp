namespace Algorithm.LeetCode;

public class LeetCode264
{
    public int NthUglyNumber(int n)
    {
        if (n <= 0)
        {
            throw new InvalidOperationException();
        }

        int[] dp = new int[n + 1];
        dp[1] = 1;
        for (int i = 2, p2 = 1, p3 = 1, p5 = 1; i <= n; i++)
        {
            int two = dp[p2] * 2, three = dp[p3] * 3, five = dp[p5] * 5;
            dp[i] = Math.Min(Math.Min(two, three), five);
            if (dp[i] == two)
            {
                p2++;
            }
            if (dp[i] == three)
            {
                p3++;
            }
            if (dp[i] == five)
            {
                p5++;
            }
        }
        return dp[n];
    }
}
