namespace Belly.Algorithm.LeetCode;

public class LeetCode209
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }

        int answer = int.MaxValue;
        for (int leftIndex = 0, rightIndex = 0, sum = 0; rightIndex < nums.Length; rightIndex++)
        {
            sum += nums[rightIndex];
            while (sum - nums[leftIndex] >= target)
            {
                sum -= nums[leftIndex++];
            }
            if (sum >= target)
            {
                answer = Math.Min(answer, rightIndex - leftIndex + 1);
            }
        }

        return answer == int.MaxValue ? 0 : answer;
    }
}
