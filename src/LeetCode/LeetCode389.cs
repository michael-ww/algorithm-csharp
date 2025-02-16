namespace Belly.Algorithm.LeetCode;

public class LeetCode389
{
    public char FindTheDifference1(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);

        int[] chars = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            chars[s[i] - 'a']++;
        }

        for (int i = 0; i < t.Length; i++)
        {
            chars[t[i] - 'a']--;
            if (chars[t[i] - 'a'] < 0)
            {
                return t[i];
            }
        }

        return char.MinValue;
    }

    public char FindTheDifference2(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);
        int sums = 0;
        for (int i = 0; i < s.Length; i++)
        {
            sums += s[i];
        }

        int sumt = 0;
        for (int i = 0; i < t.Length; i++)
        {
            sumt += t[i];
        }

        return (char)(sumt - sums);
    }

    public char FindTheDifference3(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);
        int eor = 0;
        foreach (char item in s)
        {
            eor ^= item;
        }

        foreach (char item in t)
        {
            eor ^= item;
        }

        return (char)eor;
    }
}
