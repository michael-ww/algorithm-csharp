namespace Algorithm.LeetCode;

public class LeetCode16
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfLessThan(nums.Length, 3);
        Array.Sort(nums);
        int closetTarget = default;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            int j = i + 1, k = nums.Length - 1;
            while (j < k)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    j++;
                    continue;
                }
                if (k < nums.Length - 1 && nums[k] == nums[k + 1])
                {
                    k--;
                    continue;
                }
                closetTarget = nums[i] + nums[j] + nums[k];
                if (target > closetTarget)
                {
                    j++;
                }
                else if (target < closetTarget)
                {
                    k--;
                }
                else
                {
                    return closetTarget;
                }
            }
        }
        return closetTarget;
    }
}
