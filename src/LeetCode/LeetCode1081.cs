namespace Belly.Algorithm.LeetCode;

public class LeetCode1081
{
    public string SmallestSubsequence(string s)
    {
        int[] counter = new int[26];
        bool[] entered = new bool[26];
        Stack<char> stack = [];
        foreach (var ch in s)
        {
            counter[ch - 'a']++;
        }
        foreach (var ch in s)
        {
            if (!entered[ch])
            {
                while (stack.Count > 0 && stack.Peek() > ch && counter[stack.Peek() - 'a'] > 0)
                {
                    entered[stack.Pop() - 'a'] = false;
                }
                stack.Push(ch);
                entered[ch - 'a'] = true;
            }
            counter[ch - 'a']--;
        }
        StringBuilder sb = new();
        while (stack.Count > 0)
        {
            sb.Insert(0, stack.Pop());
        }
        return sb.ToString();
    }
}
