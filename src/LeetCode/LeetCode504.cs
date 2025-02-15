namespace Algorithm.LeetCode;

public class LeetCode504
{
    public string ConvertToBase7(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        bool negative = num < 0;
        num = Math.Abs(num);
        StringBuilder sb = new();
        while (num > 0)
        {
            sb.Append(num % 7);
            num /= 7;
        }
        if (negative)
        {
            sb.Append('-');
        }
        StringBuilder digits = new();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            digits.Append(sb[i]);
        }

        return digits.ToString();
    }
}