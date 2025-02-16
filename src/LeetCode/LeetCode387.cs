namespace Belly.Algorithm.LeetCode;

public class LeetCode387
{
    public int FirstUniqChar(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return -1;
        }

        Dictionary<char, int> dictionary = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (dictionary.TryGetValue(s[i], out int count))
            {
                dictionary[s[i]] += 1;
            }
            else
            {
                dictionary.Add(s[i], 1);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (dictionary[s[i]] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}
