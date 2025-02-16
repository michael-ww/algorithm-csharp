namespace Belly.Algorithm.LeetCode;

public class LeetCode53
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public int MaxSubArray(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }
        int answer = nums[0];
        for (int i = 1, previous = nums[0]; i < nums.Length; i++)
        {
            previous = Math.Max(nums[i], previous + nums[i]);
            answer = Math.Max(answer, previous);
        }

        return answer;
    }
}
