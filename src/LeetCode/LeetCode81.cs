namespace Algorithm.LeetCode;

public class LeetCode81
{
    public bool Search(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length == 0)
        {
            return false;
        }
        if (nums.Length == 1)
        {
            return nums[0] == target;
        }
        int leftIndex = 0, rightIndex = nums.Length - 1;
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[middleIndex] == target)
            {
                return true;
            }
            if (nums[leftIndex] == nums[middleIndex] && nums[middleIndex] == nums[rightIndex])
            {
                leftIndex++;
                rightIndex--;
            }
            else if (nums[middleIndex] >= nums[leftIndex])
            {
                if (nums[leftIndex] <= target && nums[middleIndex] > target)
                {
                    rightIndex = middleIndex - 1;
                }
                else
                {
                    leftIndex = middleIndex + 1;
                }
            }
            else
            {
                if (nums[middleIndex] < target && nums[rightIndex] >= target)
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }
        }

        return false;
    }
}