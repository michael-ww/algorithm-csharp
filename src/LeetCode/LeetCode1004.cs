namespace Belly.Algorithm.LeetCode;

public class LeetCode1004
{
    public int LongestOnes(int[] nums, int k)
    {
        int[] prefixSum = new int[nums.Length + 1];
        for (int i = 1; i <= nums.Length; i++)
        {
            prefixSum[i] = prefixSum[i - 1] + (1 - nums[i - 1]);
        }

        int answer = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            int left = this.BinarySearch(prefixSum, prefixSum[right + 1] - k);
            answer = Math.Max(answer, right - left + 1);
        }

        return answer;
    }

    private int BinarySearch(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        while (left < right)
        {
            int middle = left + (right - left) >> 1;
            if (nums[middle] < target)
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }
        return left;
    }
}