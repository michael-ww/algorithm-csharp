namespace Belly.Algorithm.LeetCode;

public class LeetCode20
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrWhiteSpace(s) || s.Length <= 0 || s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '{' || s[i] == '[' || s[i] == '(')
            {
                stack.Push(s[i]);
            }
            else
            {
                if (stack.Count <= 0)
                {
                    return false;
                }
                else if (s[i] == '}' && stack.Pop() != '{')
                {
                    return false;
                }
                else if (s[i] == ']' && stack.Pop() != '[')
                {
                    return false;
                }
                else if (s[i] == ')' && stack.Pop() != '(')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
