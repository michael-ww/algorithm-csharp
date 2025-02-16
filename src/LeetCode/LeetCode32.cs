namespace Belly.Algorithm.LeetCode;

public class LeetCode32
{
    public int LongestValidParentheses1(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }

        int[] dp = new int[s.Length];
        int answer = 0;
        for (int i = 1, previous; i < s.Length; i++)
        {
            if (s[i] == ')')
            {
                previous = i - dp[i - 1] - 1;
                if (previous >= 0 && s[previous] == '(')
                {
                    dp[i] = dp[i - 1] + 2 + (previous > 0 ? dp[previous - 1] : 0);
                }
            }
            answer = Math.Max(dp[i], answer);
        }

        return answer;
    }

    public int LongestValidParentheses2(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return 0;
        }
        Stack<int> stack = new();
        stack.Push(-1);
        int answer = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(i);
            }
            else
            {
                stack.Pop();
                if (stack.Count <= 0)
                {
                    stack.Push(i);
                }
                else
                {
                    answer = Math.Max(answer, i - stack.Peek());
                }
            }
        }

        return answer;
    }
}
