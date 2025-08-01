namespace Belly.Algorithm.LeetCode;

public class LeetCode300
{
    public int LengthOfLIS1(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
        }

        return dp.Max();
    }

    public int LengthOfLIS2(int[] nums)
    {
        List<int> tails = [];
        foreach (var num in nums)
        {
            int left = 0, right = tails.Count - 1;
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (tails[mid] < num)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            tails[left] = num;
        }

        return tails.Count;
    }
}
