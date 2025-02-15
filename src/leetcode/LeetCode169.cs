namespace Algorithm.LeetCode;

public class LeetCode169
{
    public int MajorityElement1(int[] nums)
    {
        SortedDictionary<int, int> sd = new(Comparer<int>.Create((int x, int y) => y - x));
        for (int i = 0; i < nums.Length; i++)
        {
            if (sd.TryGetValue(nums[i], out int value))
            {
                sd[nums[i]] += 1;
            }
            else
            {
                sd.Add(nums[i], 1);
            }
        }
        return sd.Keys.First();
    }

    public int MajorityElement2(int[] nums)
    {
        if (nums == null || nums.Length <= 0)
        {
            throw new ArgumentException(nameof(nums));
        }

        int count = 0, candidate = int.MaxValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
                count++;
            }
            else
            {
                count += nums[i] == candidate ? 1 : -1;
            }
        }

        return candidate;
    }
}