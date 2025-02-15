namespace Algorithm.LeetCode;

public class LeetCode494
{
    public int FindTargetSumWays1(int[] nums, int target)
    {
        return this.FindTargetSumWays1(nums, 0, target);
    }

    private int FindTargetSumWays1(int[] nums, int index, int target)
    {
        if (index >= nums.Length)
        {
            return target == 0 ? 1 : 0;
        }

        return this.FindTargetSumWays1(nums, index + 1, target + nums[index]) + this.FindTargetSumWays1(nums, index + 1, target - nums[index]);
    }

    public int FindTargetSumWays2(int[] nums, int target)
    {
        Dictionary<int, Dictionary<int, int>> dp = [];
        return this.FindTargetSumWays2(nums, 0, target, dp);
    }

    private int FindTargetSumWays2(int[] nums, int index, int target, Dictionary<int, Dictionary<int, int>> dp)
    {
        if (index >= nums.Length)
        {
            return target == 0 ? 1 : 0;
        }
        if (dp.TryGetValue(index, out Dictionary<int, int> value) && value.TryGetValue(target, out int vvalue))
        {
            return vvalue;
        }

        int answer = this.FindTargetSumWays2(nums, index + 1, target + nums[index], dp) + this.FindTargetSumWays2(nums, index + 1, target - nums[index], dp);
        if (!dp.ContainsKey(index))
        {
            dp.Add(index, []);
        }
        dp[index].Add(target, answer);
        return answer;
    }

    public int FindTargetSumWays3(int[] nums, int target)
    {
        int sum = nums.Sum();
        if (target > sum || target < -sum)
        {
            return 0;
        }
        int[,] dp = new int[nums.Length + 1, 2 * sum + 1];
        for (int i = nums.Length; i >= 0; i--)
        {
            for (int j = -sum; j <= sum; j++)
            {
                if (i == nums.Length)
                {
                    if (j == target + sum)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = 0;
                    }
                }
                else
                {
                    if (j + nums[i] + sum < 2 * sum + 1)
                    {
                        dp[i, j + sum] = dp[i + 1, j + nums[i] + sum];
                    }
                    if (j - nums[i] + sum < 2 * sum + 1)
                    {
                        dp[i, j + sum] += dp[i + 1, j - nums[i] + sum];
                    }
                }
            }
        }

        return dp[0, sum];
    }
}
