namespace Algorithm.LeetCode;

public class LeetCode300
{
    public int LengthOfLIS1(int[] nums)
    {
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);
        int answer = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }
            answer = Math.Max(answer, dp[i]);
        }

        return answer;
    }

    public int LengthOfLIS2(int[] nums)
    {
        int[] tails = new int[nums.Length];
        int answer = 0;
        foreach (var num in nums)
        {
            int i = 0, j = answer;
            while (i < j)
            {
                int m = (i + j) / 2;
                if (tails[m] < num)
                {
                    i = m + 1;
                }
                else
                {
                    j = m;
                }
            }
            tails[i] = num;
            if (answer == j)
            {
                answer++;
            }
        }

        return answer;
    }
}
