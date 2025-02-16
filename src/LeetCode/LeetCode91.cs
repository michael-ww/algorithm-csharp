namespace Belly.Algorithm.LeetCode;

public class LeetCode91
{
    public int NumDecodings1(string s)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        return this.NumDecodings(s, 0);
    }

    private int NumDecodings(string s, int index)
    {
        if (index >= s.Length)
        {
            return 1;
        }

        if (s[index] == '0')
        {
            return 0;
        }
        else
        {
            int answer = this.NumDecodings(s, index + 1);
            if (index + 1 < s.Length && ((s[index] - '0') * 10 + (s[index + 1] - '0')) <= 26)
            {
                answer += this.NumDecodings(s, index + 2);
            }
            return answer;
        }
    }

    public int NumDecodings2(string s)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        int[] dp = new int[s.Length];
        Array.Fill(dp, -1);
        return this.NumDecodings(s, 0, dp);
    }

    private int NumDecodings(string s, int index, int[] dp)
    {
        if (index >= s.Length)
        {
            return 1;
        }

        if (dp[index] != -1)
        {
            return dp[index];
        }

        if (s[index] == '0')
        {
            dp[index] = 0;
            return 0;
        }
        else
        {
            int answer = this.NumDecodings(s, index + 1, dp);
            if (index + 1 < s.Length && ((s[index] - '0') * 10 + (s[index + 1] - '0')) <= 26)
            {
                answer += this.NumDecodings(s, index + 2, dp);
            }
            dp[index] = answer;
            return answer;
        }
    }

    public int NumDecodings3(string s)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        int[] dp = new int[s.Length + 1];
        dp[^1] = 1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '0')
            {
                dp[i] = 0;
            }
            else
            {
                dp[i] = dp[i + 1];
                if (i + 1 < s.Length && ((s[i] - '0') * 10 + (s[i + 1] - '0')) <= 26)
                {
                    dp[i] += dp[i + 2];
                }
            }
        }
        return dp[0];
    }

    public int NumDecodings4(string s)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        int next = 1, nnext = 0;
        for (int i = s.Length - 1, current; i >= 0; i--)
        {
            if (s[i] == '0')
            {
                current = 0;
            }
            else
            {
                current = next;
                if (i + 1 < s.Length && ((s[i] - '0') * 10 + (s[i + 1] - '0')) <= 26)
                {
                    current += nnext;
                }
            }

            nnext = next;
            next = current;
        }

        return next;
    }
}
