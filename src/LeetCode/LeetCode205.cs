namespace Belly.Algorithm.LeetCode;

public class LeetCode205
{
    public bool IsIsomorphic(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, char> st = new();
        Dictionary<char, char> ts = new();
        for (int i = 0; i < s.Length; i++)
        {
            char a = s[i];
            char b = t[i];
            if ((st.ContainsKey(a) && st[a] != b) || (ts.ContainsKey(b) && ts[b] != a))
            {
                return false;
            }
            st[a] = b;
            ts[b] = a;
        }

        return true;
    }
}
