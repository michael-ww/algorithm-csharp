namespace Algorithm.LeetCode;

public class LeetCode405
{
    public string ToHex(int num)
    {
        if (num == 0)
        {
            return "0";
        }

        StringBuilder sb = new();
        for (int i = 7; i >= 0; i--)
        {
            int value = (num >>> (4 * i)) & 0xf;
            if (sb.Length > 0 || value > 0)
            {
                char digit = value < 10 ? (char)('0' + value) : (char)('a' + value - 10);
                sb.Append(digit);
            }
        }

        return sb.ToString();
    }
}
