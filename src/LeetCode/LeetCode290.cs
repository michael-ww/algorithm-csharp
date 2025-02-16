namespace Belly.Algorithm.LeetCode;

public class LeetCode290
{
    public bool WordPattern(string pattern, string s)
    {
        if (string.IsNullOrEmpty(pattern) || string.IsNullOrEmpty(s))
        {
            return false;
        }

        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (words.Length != pattern.Length)
        {
            return false;
        }

        Dictionary<char, string> p2s = new();

        for (int i = 0; i < pattern.Length; i++)
        {
            if (p2s.TryGetValue(pattern[i], out string word))
            {
                if (words[i] != word)
                {
                    return false;
                }
            }
            else
            {
                p2s.Add(pattern[i], words[i]);
            }
        }
        return true;
    }
}
