namespace Algorithm.LeetCode;

public class LeetCode58
{
    public int LengthOfLastWord1(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        return s.Split(' ', StringSplitOptions.RemoveEmptyEntries)[^1].Length;
    }

    public int LengthOfLastWord2(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        int end = s.Length - 1;
        while (s[end] == ' ')
        {
            end--;
        }

        int start = end;
        while (start >= 0 && s[start] != ' ')
        {
            start--;
        }

        return end - start;
    }
}
