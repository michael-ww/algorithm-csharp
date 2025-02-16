namespace Belly.Algorithm.LeetCode;

public class LeetCode28
{
    public int StrStr1(string haystack, string needle)
    {
        if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
        {
            return -1;
        }
        return haystack.IndexOf(needle);
    }

    // Time Complexity: O(m*n)
    public int StrStr2(string haystack, string needle)
    {
        if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
        {
            return -1;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            int a = i, b = 0;
            while (b < needle.Length && haystack[a] == needle[b])
            {
                a++;
                b++;
            }
            if (b == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }

    // Time Complexity: O(m+n)
    public int StrStr3(string haystack, string needle)
    {
        if (string.IsNullOrWhiteSpace(haystack) || string.IsNullOrWhiteSpace(needle))
        {
            return -1;
        }

        int[] next = new int[needle.Length];
        for (int i = 1, j = 0; i < needle.Length; i++)
        {
            while (j > 0 && needle[i] != needle[j])
            {
                j = next[j - 1];
            }
            if (needle[i] == needle[j])
            {
                j++;
            }
            next[i] = j;
        }

        for (int i = 0, j = 0; i < haystack.Length; i++)
        {
            while (j > 0 && haystack[i] != needle[j])
            {
                j = next[j - 1];
            }
            if (haystack[i] == needle[j])
            {
                j++;
            }
            if (j == needle.Length)
            {
                return i - needle.Length + 1;
            }
        }

        return -1;
    }
}