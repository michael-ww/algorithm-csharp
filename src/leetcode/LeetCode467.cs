namespace Algorithm.LeetCode;

public class LeetCode467
{
    public int FindSubstringInWraproundString(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        int[] dp = new int[26];
        dp[s[0]] = 1;
        for (int i = 1, previous, current, length = 1; i < s.Length; i++)
        {
            previous = s[i - 1];
            current = s[i];
            if ((previous == 25 && current == 0) || previous + 1 == current)
            {
                length++;
            }
            else
            {
                length = 1;
            }
            dp[current] = Math.Max(dp[current], length);
        }

        int answer = 0;
        for (int i = 0; i < dp.Length; i++)
        {
            answer += dp[i];
        }

        return answer;
    }
}
