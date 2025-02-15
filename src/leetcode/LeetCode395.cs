namespace Algorithm.LeetCode;

public class LeetCode395
{
    public int LongestSubstring(string s, int k)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentOutOfRangeException.ThrowIfNegative(k);
        int[] freq = new int[26];
        int answer = 0;
        for (int required = 1; required <= 26; required++)
        {
            for (int left = 0, right = 0, collected = 0, satisfied = 0; right < s.Length; right++)
            {
                freq[s[right] - 'a']++;
                if (freq[s[right] - 'a'] == 1)
                {
                    collected++;
                }
                if (freq[s[right] - 'a'] == k)
                {
                    satisfied++;
                }
                while (collected > required && left <= right)
                {
                    if (freq[s[left] - 'a'] == 0)
                    {
                        collected--;
                    }
                    if (freq[s[left] - 'a'] == k)
                    {
                        satisfied--;
                    }
                    freq[s[left++] - 'a']--;
                }
                if (satisfied == required)
                {
                    answer = Math.Max(answer, right - left + 1);
                }
            }
        }

        return answer;
    }
}