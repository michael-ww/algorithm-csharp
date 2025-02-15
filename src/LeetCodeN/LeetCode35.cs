namespace Algorithm.LeetCode;

public class LeetCode35
{
    public int SearchInsert(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int leftIndex = 0, rightIndex = nums.Length - 1;
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[middleIndex] >= target)
            {
                rightIndex = middleIndex - 1;
            }
            else
            {
                leftIndex = middleIndex + 1;
            }
        }

        return leftIndex;
    }
}
