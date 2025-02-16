namespace Belly.Algorithm.LeetCode;

public class LeetCode217
{
    public bool ContainsDuplicate1(int[] nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return false;
        }

        Array.Sort(nums);
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                return true;
            }
        }
        return false;
    }

    public bool ContainsDuplicate2(int[] nums)
    {
        if (nums == null || nums.Length < 2)
        {
            return false;
        }
        HashSet<int> hs = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hs.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                hs.Add(nums[i]);
            }
        }
        return false;
    }
}