namespace Algorithm.LeetCode;

    public class LeetCode125
{
    public bool IsPalindrome1(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }

        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                sb.Append(s[i].ToString().ToLower());
            }
        }
        return sb.ToString() == sb.ToString().Reverse().ToString();
    }

    public bool IsPalindrome2(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }
        StringBuilder sb = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                sb.Append(s[i].ToString().ToLower());
            }
        }

        s = sb.ToString();

        int leftIndex = 0, rightIndex = s.Length - 1;
        while (leftIndex < rightIndex)
        {
            if (s[leftIndex++] != s[rightIndex--])
            {
                return false;
            }

        }

        return true;
    }

    public bool IsPalindrome3(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return true;
        }

        int leftIndex = 0, rightIndex = s.Length - 1;
        while (leftIndex < rightIndex)
        {
            while (!char.IsLetterOrDigit(s[leftIndex]))
            {
                leftIndex++;
            }
            while (!char.IsLetterOrDigit(s[rightIndex]))
            {
                rightIndex--;
            }
            if (leftIndex > rightIndex || s[leftIndex++] != s[rightIndex--])
            {
                return false;
            }
        }

        return true;
    }
}
