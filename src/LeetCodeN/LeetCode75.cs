namespace Algorithm.LeetCode;

public class LeetCode75
{
    public void SortColors(int[] nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }
        int lessIndex = -1, moreIndex = nums.Length, index = 0;
        while (index < moreIndex)
        {
            if (nums[index] < 1)
            {
                Utility.Swap(nums, index++, ++lessIndex);
            }
            else if (nums[index] > 1)
            {
                Utility.Swap(nums, index, --moreIndex);
            }
            else
            {
                index++;
            }
        }
    }
}
