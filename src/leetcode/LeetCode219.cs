namespace Algorithm.LeetCode;

public class LeetCode219
{
    public bool ContainsNearbyDuplicate1(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2 || k <= 0)
        {
            return false;
        }

        Dictionary<int, int> dictionary = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.TryGetValue(nums[i], out int index))
            {
                if (Math.Abs(i - index) <= k)
                {
                    return true;
                }
            }
            dictionary[nums[i]] = i;
        }

        return false;
    }

    public bool ContainsNearbyDuplicate2(int[] nums, int k)
    {
        if (nums == null || nums.Length < 2 || k <= 0)
        {
            return false;
        }

        HashSet<int> hs = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                hs.Remove(nums[i - k - 1]);
            }
            if (hs.Contains(nums[i]))
            {
                return true;
            }
            hs.Add(nums[i]);
        }

        return false;
    }
}
