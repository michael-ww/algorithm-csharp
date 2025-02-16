namespace Belly.Algorithm.LeetCode;

public class LeetCode8
{
    public int MyAtoi(string s)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(s);
        int answer = 0;
        bool negative = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '-')
            {
                if (answer != 0)
                {
                    return answer;
                }
                else
                {
                    negative = true;
                }
            }
            if (char.IsDigit(s[i]))
            {
                answer = answer * 10 + (s[i] - '0');
            }
        }

        return negative == true ? answer * -1 : answer;
    }
}
