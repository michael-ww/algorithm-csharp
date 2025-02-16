namespace Belly.Algorithm.LeetCode;

public class LeetCode26
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            return 0;
        }

        int iteratorIndex = 1, distinctIndex = 1;
        while (iteratorIndex < nums.Length)
        {
            if (nums[iteratorIndex] != nums[iteratorIndex - 1])
            {
                nums[distinctIndex] = nums[iteratorIndex];
                distinctIndex++;
            }
            iteratorIndex++;
        }
        return distinctIndex;
    }
}
