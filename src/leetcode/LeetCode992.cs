namespace Algorithm.LeetCode;

public class LeetCode992
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        return this.AtMostDistinct(nums, k) - this.AtMostDistinct(nums, k - 1);
    }

    private int AtMostDistinct(int[] nums, int k)
    {
        int[] freqs = new int[nums.Length + 1];
        int answer = 0;
        for (int leftIndex = 0, rightIndex = 0, count = 0; rightIndex < nums.Length; rightIndex++)
        {
            if (++freqs[nums[rightIndex]] == 1)
            {
                count++;
            }
            while (count > k)
            {
                if (--freqs[nums[leftIndex++]] == 0)
                {
                    count--;
                }
            }
            answer += rightIndex - leftIndex + 1;
        }
        return answer;
    }
}