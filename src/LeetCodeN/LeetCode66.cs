namespace Algorithm.LeetCode;

public class LeetCode66
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i]++;
            digits[i] %= 10;
            if (digits[i] != 0)
            {
                return digits;
            }
        }

        digits = new int[digits.Length + 1];
        digits[0] = 1;
        return digits;
    }
}