namespace Algorithm.LeetCode;

    public class LeetCode383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if (string.IsNullOrEmpty(ransomNote))
        {
            return true;
        }

        if (string.IsNullOrEmpty(magazine))
        {
            return false;
        }

        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }

        int[] alpha = new int[26];
        for (int i = 0; i < magazine.Length; i++)
        {
            alpha[magazine[i] - 'a'] += 1;
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            alpha[ransomNote[i] - 'a'] -= 1;
            if (alpha[ransomNote[i] - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
