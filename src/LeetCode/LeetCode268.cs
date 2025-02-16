namespace Belly.Algorithm.LeetCode;

public class LeetCode268
{
    public int MissingNumber1(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }

        return int.MaxValue;
    }

    public int MissingNumber2(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        HashSet<int> hs = new();
        foreach (var item in nums)
        {
            hs.Add(item);
        }

        for (int i = 0; i <= nums.Length; i++)
        {
            if (!hs.Contains(i))
            {
                return i;
            }
        }
        return int.MaxValue;
    }

    public int MissingNumber3(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int eor = 0;
        for (int i = 0; i <= nums.Length; i++)
        {
            eor ^= i;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            eor ^= nums[i];
        }

        return eor;
    }

    public int MissingNumber4(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int total = nums.Length * (nums.Length + 1) / 2;
        int sum = 0;
        foreach (var item in nums)
        {
            sum += item;
        }

        return total - sum;
    }
}
