namespace Algorithm.LeetCode;

public class LeetCode5
{
    // Time Complexity: O(n^3)
    // Space Complexity: O(1)
    public string LongestPalindrome1(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
        {
            return s;
        }

        int beginIndex = 0, maxLength = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            for (int j = i + 1; j < s.Length; j++)
            {
                if (j - i + 1 > maxLength && this.ValidatePalindrome(s, i, j))
                {
                    beginIndex = i;
                    maxLength = j - i + 1;
                }
            }
        }

        return s.Substring(beginIndex, maxLength);
    }

    private bool ValidatePalindrome(string s, int leftIndex, int rightIndex)
    {
        while (leftIndex < rightIndex)
        {
            if (s[leftIndex] != s[rightIndex])
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }

    // O(n^2)
    // O(1)
    public string LongestPalindrome2(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
        {
            return s;
        }

        int beginIndex = 0, maxLength = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            int oddLength = this.ExpandAroundCenter(s, i, i);
            int eventLength = this.ExpandAroundCenter(s, i, i + 1);
            maxLength = Math.Max(maxLength, Math.Max(oddLength, eventLength));
            beginIndex = i - (maxLength - 1) / 2;
        }

        return s.Substring(beginIndex, maxLength);
    }

    private int ExpandAroundCenter(string s, int leftIndex, int rightIndex)
    {
        while (leftIndex >= 0 && rightIndex < s.Length)
        {
            if (s[leftIndex] != s[rightIndex])
            {
                break;
            }
            leftIndex--;
            rightIndex++;
        }

        return rightIndex - leftIndex - 1;
    }

}