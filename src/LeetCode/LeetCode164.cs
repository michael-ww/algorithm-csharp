namespace Belly.Algorithm.LeetCode;

public class LeetCode164
{
    public int MaximumGap(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length < 2)
        {
            return 0;
        }

        Array.Sort(nums);
        int answer = nums[1] - nums[0];
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] > answer)
            {
                answer = nums[i] - nums[i - 1];
            }
        }

        return answer;
    }
}
