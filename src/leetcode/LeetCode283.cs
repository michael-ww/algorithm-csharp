namespace Algorithm.LeetCode;

public class LeetCode283
{
    public void MoveZeroes(int[] nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return;
        }
        int left = 0, right = 0;
        while (right < nums.Length)
        {
            if (nums[right] != 0)
            {
                Utility.Swap(nums, left++, right);
            }
            right++;
        }
    }
}
