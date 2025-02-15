namespace Algorithm.LeetCode;

public class LeetCode34
{
    public int[] SearchRange(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int startIndex = this.MostLeft(nums, target);
        if (startIndex < 0 || startIndex >= nums.Length || nums[startIndex] != target)
        {
            return [-1, -1];
        }
        int endIndex = this.MostRight(nums, target);
        return [startIndex, endIndex];
    }

    private int MostLeft(int[] nums, int target)
    {
        int leftIndex = 0, rightIndex = nums.Length - 1, answer = -1;
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[middleIndex] >= target)
            {
                answer = middleIndex;
                rightIndex = middleIndex - 1;
            }
            else
            {
                leftIndex = middleIndex + 1;
            }
        }

        return answer;
    }

    private int MostRight(int[] nums, int target)
    {
        int leftIndex = 0, rightIndex = nums.Length - 1, answer = -1;
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[middleIndex] <= target)
            {
                answer = middleIndex;
                leftIndex = middleIndex + 1;
            }
            else
            {
                rightIndex = middleIndex - 1;
            }
        }

        return answer;
    }
}
