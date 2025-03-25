namespace Belly.Algorithm.LeetCode;

public class LeetCode189
{
    public void Rotate(int[] nums, int k)
    {
        Utility.Reverse(nums, 0, nums.Length - 1);
        Utility.Reverse(nums, 0, k - 1);
        Utility.Reverse(nums, k, nums.Length - 1);
    }
}