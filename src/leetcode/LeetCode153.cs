namespace Algorithm.LeetCode;

public class LeetCode153
{
    public int FindMin(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        int leftIndex = 0, rightIndex = nums.Length - 1, answer = nums[Random.Shared.Next(0, nums.Length)];
        while (leftIndex <= rightIndex)
        {
            int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
            if (nums[leftIndex] < nums[middleIndex])
            {
                if (nums[leftIndex] < answer)
                {
                    answer = nums[leftIndex];
                }
                leftIndex = middleIndex + 1;
            }
            else
            {
                if (nums[middleIndex] < answer)
                {
                    answer = nums[middleIndex];
                }
                rightIndex = middleIndex - 1;
            }
        }

        return answer;
    }
}
