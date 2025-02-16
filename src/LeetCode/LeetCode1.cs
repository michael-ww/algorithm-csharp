namespace Belly.Algorithm.LeetCode;

public class LeetCode1
{
    public (int, int) TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 2)
        {
            return (-1, -1);
        }

        Dictionary<int, int> cache = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (cache.ContainsKey(target - nums[i]))
            {
                return (cache[target - nums[i]], i);
            }
            else
            {
                cache.Add(nums[i], i);
            }
        }

        return (-1, -1);
    }
}
