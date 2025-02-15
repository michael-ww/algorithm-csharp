namespace Algorithm.LeetCode;

public class LeetCode345
{
    public string ReverseVowels(string s)
    {
        if (s == null || s.Length < 2)
        {
            return s;
        }

        HashSet<char> hs = new() { 'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U' };
        char[] chars = s.ToCharArray();
        int leftIndex = 0, rightIndex = chars.Length - 1;
        while (leftIndex < rightIndex)
        {
            while (!hs.Contains(s[leftIndex]) && leftIndex < chars.Length)
            {
                leftIndex++;
            }
            while (!hs.Contains(s[rightIndex]) && rightIndex >= 0)
            {
                rightIndex--;
            }
            if (leftIndex >= rightIndex)
            {
                break;
            }
            Utility.Swap(chars, leftIndex++, rightIndex--);
        }

        return string.Concat(chars);
    }
}
