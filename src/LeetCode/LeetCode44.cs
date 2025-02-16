namespace Belly.Algorithm.LeetCode;

public class LeetCode44
{
    public bool IsMatch1(string s, string p)
    {
        int[,] dp = new int[s.Length + 1, p.Length + 1];
        return this.IsMatch1(s, p, s.Length, p.Length, dp);
    }

    private bool IsMatch1(string s, string p, int i, int j, int[,] dp)
    {
        if (i <= 0 && j <= 0)
        {
            return true;
        }
        if (i <= 0 && j > 0)
        {
            return p[..j] == "*";
        }
        if (i <= 0 || j <= 0)
        {
            return false;
        }
        if (dp[i, j] != 0)
        {
            return dp[i, j] == 1;
        }

        bool answer = false;
        if (p[j - 1] == '*')
        {
            answer = IsMatch1(s, p, i - 1, j, dp) || IsMatch1(s, p, i, j - 1, dp);
        }
        else if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
        {
            answer = IsMatch1(s, p, i - 1, j - 1, dp);
        }

        dp[i, j] = answer ? 1 : -1;
        return answer;
    }

    public bool IsMatch2(string s, string p)
    {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = 0; j <= p.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[i, j] = true;
                }
                else if (i == 0 && j > 0)
                {
                    dp[i, j] = p[..j] == "*";
                }
                else if (i > 0 && j == 0)
                {
                    dp[i, j] = false;
                }
                else
                {
                    if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i, j - 1] || dp[i - 1, j];
                    }
                    else if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                }
            }
        }

        return dp[s.Length, p.Length];
    }

    public bool IsMatch3(string s, string p)
    {
        bool[] dp = new bool[p.Length + 1];
        for (int i = 0; i <= s.Length; i++)
        {
            bool leftUp = false;
            for (int j = 0; j <= p.Length; j++)
            {
                bool backup = dp[j];
                if (i == 0 && j == 0)
                {
                    dp[j] = true;
                }
                else if (i == 0 && j > 0)
                {
                    dp[j] = p[..j] == "*";
                }
                else if (i > 0 && j == 0)
                {
                    dp[j] = false;
                }
                else
                {
                    if (p[j - 1] == '*')
                    {
                        dp[j] = dp[j] || dp[j - 1];
                    }
                    else if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
                    {
                        dp[j] = leftUp;
                    }
                }
                leftUp = backup;
            }
        }

        return dp[p.Length];
    }
}
