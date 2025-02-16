namespace Belly.Algorithm.LeetCode;

public class LeetCode162
{
    public int FindPeakElement(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return -1;
        }
        if (nums.Length == 1)
        {
            return 0;
        }
        if (nums[0] > nums[1])
        {
            return 0;
        }
        if (nums[^1] > nums[^2])
        {
            return nums.Length - 1;
        }
        int leftIndex = 1, rightIndex = nums.Length - 2;
        while (leftIndex <= rightIndex)
        {
            int middleIndex = (leftIndex + rightIndex) / 2;
            if (nums[middleIndex - 1] > nums[middleIndex])
            {
                rightIndex = middleIndex - 1;
            }
            else if (nums[middleIndex + 1] > nums[middleIndex])
            {
                leftIndex = middleIndex + 1;
            }
            else
            {
                return middleIndex;
            }
        }

        return -1;
    }


}
