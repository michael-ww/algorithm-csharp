namespace Belly.Algorithm.LeetCode;

public class LeetCode1979
{
    public int FindGCD(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);

        int max = int.MinValue, min = int.MaxValue;
        foreach (var item in nums)
        {
            if (item > max)
            {
                max = item;
            }
            if (item < min)
            {
                min = item;
            }
        }

        if (max == min)
        {
            return max;
        }

        if (max == 0 || min == 0)
        {
            return 0;
        }

        return Utility.GreatestCommonDivisor(max, min);
    }
}
