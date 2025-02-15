namespace Algorithm.LeetCode;

public class LeetCode242
{
    public bool IsAnagram1(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return false;
        }

        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> sd = [];
        for (int i = 0; i < s.Length; i++)
        {
            if (sd.TryGetValue(s[i], out int count))
            {
                sd[s[i]] = count + 1;
            }
            else
            {
                sd.Add(s[i], 1);
            }
        }

        Dictionary<char, int> td = [];
        for (int i = 0; i < t.Length; i++)
        {
            if (td.TryGetValue(t[i], out int count))
            {
                td[t[i]] = count + 1;
            }
            else
            {
                td.Add(t[i], 1);
            }
        }

        if (sd.Count != td.Count)
        {
            return false;
        }

        foreach (var item in sd)
        {
            if (td.TryGetValue(item.Key, out int count))
            {
                if (count != item.Value)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAnagram2(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return false;
        }

        if (s.Length != t.Length)
        {
            return false;
        }
        char[] schars = s.ToCharArray();
        char[] tchars = t.ToCharArray();
        Array.Sort(schars);
        Array.Sort(tchars);
        for (int i = 0; i < schars.Length; i++)
        {
            if (schars[i] != tchars[i])
            {
                return false;
            }
        }
        return true;
    }

    public bool IsAnagram3(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return false;
        }

        if (s.Length != t.Length)
        {
            return false;
        }

        int[] alpha = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            alpha[s[i] - 'a']++;
            alpha[t[i] - 'a']--;
        }

        for (int i = 0; i < alpha.Length; i++)
        {
            if (alpha[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
