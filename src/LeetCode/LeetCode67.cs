namespace Belly.Algorithm.LeetCode;

using System.Globalization;

public class LeetCode67
{
    public string AddBinary1(string a, string b)
    {
        if (string.IsNullOrWhiteSpace(a))
        {
            return b;
        }
        if (string.IsNullOrWhiteSpace(b))
        {
            return a;
        }
        string answer = string.Empty;
        int aIndex = a.Length - 1, bIndex = b.Length - 1, carryNumber = 0;
        while (aIndex >= 0 || bIndex >= 0)
        {
            int x = aIndex >= 0 ? a[aIndex] - '0' : 0;
            int y = bIndex >= 0 ? b[bIndex] - '0' : 0;
            int z = x + y + carryNumber;
            answer = z % 2 + answer;
            carryNumber = z / 2;
            aIndex--;
            bIndex--;
        }
        if (carryNumber > 0)
        {
            answer = '1' + answer;
        }

        return answer;
    }

    public string AddBinary2(string a, string b)
    {
        if (string.IsNullOrEmpty(a))
        {
            return b;
        }
        if (string.IsNullOrEmpty(b))
        {
            return a;
        }

        int x = int.Parse(a, NumberStyles.BinaryNumber);
        int y = int.Parse(b, NumberStyles.BinaryNumber);
        return Convert.ToString(x + y, 2);
    }

    public string AddBinary3(string a, string b)
    {
        if (string.IsNullOrEmpty(a))
        {
            return b;
        }
        if (string.IsNullOrEmpty(b))
        {
            return a;
        }

        int x = int.Parse(a, NumberStyles.BinaryNumber);
        int y = int.Parse(b, NumberStyles.BinaryNumber);
        int sum = x ^ y;
        int carry = (x & y) << 1;
        while (carry > 0)
        {
            sum ^= carry;
            carry = (carry & sum) << 1;
        }
        return sum.ToString();
    }
}
