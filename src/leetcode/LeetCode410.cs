namespace Algorithm.LeetCode;

public class LeetCode410
{
    public int SplitArray(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(k);

        int answer = 0, left = 0, right = nums.Sum();
        while (left <= right)
        {
            int middle = left + ((right - left) >> 1);
            int count = this.Check(nums, middle);
            if (count <= k)
            {
                answer = middle;
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return answer;
    }

    private int Check(int[] nums, int limit)
    {
        int parts = 1, sum = 0;
        foreach (var item in nums)
        {
            if (item > limit)
            {
                return int.MaxValue;
            }
            if (sum + item > limit)
            {
                parts++;
                sum = item;
            }
            else
            {
                sum += item;
            }
        }

        return parts;
    }
}
