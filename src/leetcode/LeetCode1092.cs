namespace Algorithm.LeetCode;

public class LeetCode1092
{
    // Time Complexity: O(n*m)
    // Space Complexity: O(n*m)
    public string ShortestCommonSupersequence(string str1, string str2)
    {
        if (str1 == null || string.IsNullOrEmpty(str1))
        {
            return str2;
        }
        if (str2 == null || string.IsNullOrEmpty(str2))
        {
            return str1;
        }

        int[][] dp = new int[str1.Length + 1][];
        for (int i = 0; i <= str1.Length; i++)
        {
            dp[i] = new int[str2.Length + 1];
        }
        for (int i = 0; i < str1.Length; i++)
        {
            dp[i][str2.Length] = str1.Length - i;
        }
        for (int i = 0; i < str2.Length; i++)
        {
            dp[str1.Length][i] = str2.Length - i;
        }
        for (int i = str1.Length - 1; i >= 0; --i)
        {
            for (int j = str2.Length - 1; j >= 0; --j)
            {
                if (str1[i] == str2[j])
                {
                    dp[i][j] = dp[i + 1][j + 1] + 1;
                }
                else
                {
                    dp[i][j] = Math.Min(dp[i + 1][j], dp[i][j + 1]) + 1;
                }
            }
        }
        StringBuilder answer = new StringBuilder();
        int t1 = 0, t2 = 0;
        while (t1 < str1.Length && t2 < str2.Length)
        {
            if (str1[t1] == str2[t2])
            {
                answer.Append(str1[t1]);
                ++t1;
                ++t2;
            }
            else if (dp[t1 + 1][t2] == dp[t1][t2] - 1)
            {
                answer.Append(str1[t1]);
                ++t1;
            }
            else if (dp[t1][t2 + 1] == dp[t1][t2] - 1)
            {
                answer.Append(str2[t2]);
                ++t2;
            }
        }
        if (t1 < str1.Length)
        {
            answer.Append(str1.Substring(t1));
        }
        else if (t2 < str2.Length)
        {
            answer.Append(str2.Substring(t2));
        }
        return answer.ToString();
    }
}
