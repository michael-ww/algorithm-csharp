namespace Algorithm.LeetCode;

public class LeetCode922
{
    public int[] SortArrayByParityII(int[] nums)
    {
        for (int even = 0, odd = 2; even < nums.Length && odd < nums.Length;)
        {
            if ((nums[^1] & 1) == 1)
            {
                Utility.Swap(nums, even, nums.Length - 1);
                even += 2;
            }
            else
            {
                Utility.Swap(nums, odd, nums.Length - 1);
                odd += 2;
            }
        }

        return nums;
    }
}