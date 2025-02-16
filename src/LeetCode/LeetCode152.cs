namespace Belly.Algorithm.LeetCode;

public class LeetCode152
{
    public int MaxProduct1(int[] nums)
    {
        return this.MaxProduct1(nums, nums.Length - 1).Item1;
    }

    private (int, int) MaxProduct1(int[] nums, int index)
    {
        if (index <= 0)
        {
            return (nums[0], nums[0]);
        }

        (int previousMax, int previousMin) = this.MaxProduct1(nums, index - 1);
        int currentMax = Math.Max(nums[index], Math.Max(nums[index] * previousMax, nums[index] * previousMin));
        int currentMin = Math.Min(nums[index], Math.Min(nums[index] * previousMax, nums[index] * previousMin));
        return (currentMax, currentMin);
    }

    public int MaxProduct2(int[] nums)
    {
        int answer = nums[0];
        for (int i = 1, previousMax = nums[0], previousMin = nums[0], currentMax, currentMin; i < nums.Length; i++)
        {
            currentMax = Math.Max(nums[i], Math.Max(nums[i] * previousMax, nums[i] * previousMin));
            currentMin = Math.Min(nums[i], Math.Min(nums[i] * previousMax, nums[i] * previousMin));
            previousMax = currentMax;
            previousMin = currentMin;
            answer = Math.Max(currentMax, answer);
        }
        return answer;
    }
}
