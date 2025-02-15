namespace Algorithm.LeetCode;

public class LeetCode908
{
    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public int SmallestRangeI(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        return (nums.Max() - nums.Min()) > 2 * k ? (nums.Max() - nums.Min() - 2 * k) : 0;
    }
}
