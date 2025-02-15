namespace Algorithm.LeetCode;

public class LeetCode509
{
    public int Fibonacci1(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return this.Fibonacci1(n - 1) + this.Fibonacci1(n - 2);
        }
    }

    public int Fibonacci2(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        int[] dp = new int[n + 1];
        Array.Fill(dp, -1);
        dp[0] = 0;
        dp[1] = 1;
        return this.Fibonacci(n, dp);
    }

    private int Fibonacci(int n, int[] dp)
    {
        if (dp[n] != -1)
        {
            return dp[n];
        }

        int answer = this.Fibonacci(n - 1, dp) + this.Fibonacci(n - 2, dp);
        dp[n] = answer;
        return answer;
    }

    public int Fibonacci3(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int[] dp = new int[n + 1];
        dp[0] = 0;
        dp[1] = 1;
        for (int i = 2; i < dp.Length; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }

    public int Fibonacci4(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int llast = 0, last = 1, answer = 0;
        for (int i = 2; i <= n; i++)
        {
            answer = last + llast;
            llast = last;
            last = answer;
        }
        return answer;
    }
}
