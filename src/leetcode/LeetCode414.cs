namespace Algorithm.LeetCode;

public class LeetCode414
{
    // Time Complexity: O(nlogn)
    // Space Complexity: O(logn)
    public int ThirdMax1(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        SortedSet<int> ss = new();
        foreach (var item in nums)
        {
            ss.Add(item);
            if (ss.Count > 3)
            {
                ss.Remove(ss.Min);
            }
        }

        return ss.Count == 3 ? ss.Min : ss.Max;
    }

    // Time Complexity: O(n)
    // Space Complexity: O(1)
    public int ThirdMax2(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        Array.Sort(nums, Comparer<int>.Create((int x, int y) => y - x));
        for (int i = 1, iterateTime = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1] && ++iterateTime == 3)
            {
                return nums[i];
            }
        }
        return nums[0];
    }
}
