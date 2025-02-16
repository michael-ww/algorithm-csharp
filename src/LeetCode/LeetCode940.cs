namespace Belly.Algorithm.LeetCode;

public class LeetCode940
{
    public int DistinctSubseqII(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        int mod = 1000000007;
        int[] last = new int[26];
        int all = 1, newAdd;
        foreach (var item in s)
        {
            newAdd = (all - last[item - 'a'] + mod) % mod;
            last[item - 'a'] = (last[item - 'a'] - newAdd) % mod;
            all = (all + newAdd) % mod;
        }

        return (all - 1 + mod) % mod;
    }
}
