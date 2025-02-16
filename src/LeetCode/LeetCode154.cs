namespace Belly.Algorithm.LeetCode;

public class LeetCode154
{
    public int FindMin(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);
        int leftIndex = 0, rightIndex = nums.Length - 1, answer = nums[0];
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[middleIndex] > nums[leftIndex])
            {
                if (nums[leftIndex] < answer)
                {
                    answer = nums[leftIndex];
                }
                leftIndex = middleIndex + 1;
            }
            else if (nums[middleIndex] < nums[rightIndex])
            {
                if (nums[middleIndex] < answer)
                {
                    answer = nums[middleIndex];
                }
                rightIndex = middleIndex - 1;
            }
            else
            {
                answer = Math.Min(Math.Min(nums[leftIndex], nums[rightIndex]), answer);
                leftIndex++;
                rightIndex--;
            }
        }

        return answer;
    }
}
