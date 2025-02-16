namespace Belly.Algorithm.LeetCode;

public class LeetCode409
{
    public int LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int[] counter = new int[128];
        for (int i = 0; i < s.Length; i++)
        {
            counter[s[i]]++;
        }

        int answer = 0;
        foreach (var item in counter)
        {
            answer += item / 2 * 2;
            if (item % 2 == 1 && answer % 2 == 0)
            {
                answer++;
            }
        }
        return answer;
    }
}
