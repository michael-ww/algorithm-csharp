namespace Algorithm.LeetCode;

public class LeetCode392
{
    public bool IsSubsequence(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);

        int sIndex = 0, tIndex = 0;
        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            tIndex++;
        }
        return sIndex == s.Length;
    }
}
