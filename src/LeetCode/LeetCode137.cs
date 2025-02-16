namespace Belly.Algorithm.LeetCode;

public class LeetCode137
{
    public int SingleNumber1(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int answer = 0;
        for (int i = 0; i < 32; i++)
        {
            int total = 0;
            foreach (int num in nums)
            {
                total += (num >> i) & 1;
            }

            int remainder = total % 3;
            if (remainder != 0)
            {
                answer |= 1 << i;
            }
        }

        return answer;
    }

    public int SingleNumber2(int[] nums)
    {
        int a = 0, b = 0;
        foreach (int num in nums)
        {
            b = ~a & (b ^ num);
            a = ~b & (a ^ num);
        }
        return b;
    }
}