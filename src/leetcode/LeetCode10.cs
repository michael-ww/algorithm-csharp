namespace Algorithm.LeetCode;

public class LeetCode10
{
    public bool IsMatch1(string s, string p)
    {
        int[,] dp = new int[s.Length + 1, p.Length + 1];
        return IsMatch1(s, p, s.Length, p.Length, dp);
    }

    private bool IsMatch1(string s, string p, int i, int j, int[,] dp)
    {
        if (i <= 0 && j <= 0)
        {
            return true;
        }
        if (i <= 0 && j > 0)
        {
            return p[..j] == ".";
        }
        if (i <= 0 || j <= 0)
        {
            return false;
        }
        if (dp[i, j] != 0)
        {
            return dp[i, j] == 1;
        }

        bool result = false;
        if (p[j - 1] == '.' || s[i - 1] == p[j - 1])
        {
            result = IsMatch1(s, p, i - 1, j - 1, dp);
        }
        else if (p[j - 1] == '*')
        {
            result = IsMatch1(s, p, i - 1, j, dp) || IsMatch1(s, p, i, j - 1, dp);
        }
        dp[i, j] = result ? 1 : -1;
        return result;
    }
}
