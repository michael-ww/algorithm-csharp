namespace Belly.Algorithm.LeetCode;

public class LeetCode27
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }

        int iteratorIndex = 0, distinctIndex = -1;
        while (iteratorIndex < nums.Length)
        {
            if (nums[iteratorIndex] != val)
            {
                nums[++distinctIndex] = nums[iteratorIndex];
            }
            iteratorIndex++;
        }
        return distinctIndex + 1;
    }
}
