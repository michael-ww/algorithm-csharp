namespace Belly.Algorithm.LeetCode;

public class LeetCode287
{
    public int FindDuplicate(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan(nums.Length, 2);
        int slow = 0, fast = 0;
        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while (slow != fast);
        fast = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}
