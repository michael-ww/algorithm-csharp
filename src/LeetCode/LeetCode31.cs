namespace Belly.Algorithm.LeetCode;

public class LeetCode31
{
    public void NextPermutation(int[] nums)
    {
        int i = nums.Length - 2, j = nums.Length - 1;
        while (i >= 0 && nums[i] >= nums[j])
        {
            i--;
            j--;
        }

        if (i >= 0)
        {
            int k = nums.Length - 1;
            while (k >= j && nums[i] >= nums[k])
            {
                k--;
            }
            Utility.Swap(nums, i, k);
        }
        Utility.Reverse(nums, i + 1, nums.Length - 1);
    }
}
