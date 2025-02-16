namespace Belly.Algorithm.LeetCode;

public class LeetCode560
{

    // Time Complexity: O(n^2)
    // Space Complexity: O(1)
    public int SubarraySum1(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);

        int count = 0;
        for (int start = 0; start < nums.Length; start++)
        {
            int sum = 0;
            for (int end = start; end >= 0; end--)
            {
                sum += nums[end];
                if (sum == k)
                {
                    count++;
                }
            }
        }

        return count;
    }

    // Tims Complexity: O(n)
    // Space Complexity: O(n)
    public int SubarraySum2(int[] nums, int k)
    {
        ArgumentNullException.ThrowIfNull(nums);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(nums.Length);

        Dictionary<int, int> dictionary = new();
        dictionary.Add(0, 1);
        int count = 0, sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (dictionary.ContainsKey(sum - k))
            {
                count += dictionary[sum - k];
            }
            if (dictionary.TryGetValue(sum - k, out int value))
            {
                dictionary[sum - k] = value + 1;
            }
            else
            {
                dictionary.Add(sum - k, 1);
            }
        }

        return count;
    }
}
