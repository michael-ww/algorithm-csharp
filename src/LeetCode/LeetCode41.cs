namespace Belly.Algorithm.LeetCode;

public class LeetCode41
{
    public int FirstMissingPositive(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);
        int left = 0, right = nums.Length;
        while (left < right)
        {
            if (nums[left] == left + 1)
            {
                left++;
            }
            else if (nums[left] <= left || nums[left] > right || nums[left] != nums[nums[left] - 1])
            {
                Utility.Swap(nums, left, --right);
            }
            else
            {
                Utility.Swap(nums, left, nums[left] - 1);
            }
        }

        return left + 1;
    }
}
