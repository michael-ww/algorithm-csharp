namespace Algorithm.LeetCode;

public class LeetCode983
{
    private readonly int[] durations = { 1, 7, 30 };

    public int MincostTickets1(int[] days, int[] costs)
    {
        ArgumentNullException.ThrowIfNull(days);
        ArgumentNullException.ThrowIfNull(costs);

        return this.MincostTickets(days, costs, 0);
    }

    private int MincostTickets(int[] days, int[] costs, int today)
    {
        if (today >= days.Length)
        {
            return 0;
        }

        int answer = int.MaxValue;
        for (int i = 0, nextDay = today; i < durations.Length; i++)
        {
            while (nextDay < days.Length && days[today] + durations[i] > days[nextDay])
            {
                nextDay++;
            }

            answer = Math.Min(answer, costs[i] + this.MincostTickets(days, costs, nextDay));
        }

        return answer;
    }

    public int MincostTickets2(int[] days, int[] costs)
    {
        ArgumentNullException.ThrowIfNull(days);
        ArgumentNullException.ThrowIfNull(costs);
        int[] dp = new int[days.Length];
        Array.Fill(dp, int.MaxValue);
        return this.MincostTickets(days, costs, 0, dp);
    }

    private int MincostTickets(int[] days, int[] costs, int today, int[] dp)
    {
        if (today >= days.Length)
        {
            return 0;
        }

        if (dp[today] != int.MaxValue)
        {
            return dp[today];
        }

        int answer = int.MaxValue;
        for (int i = 0, nextDay = today; i < durations.Length; i++)
        {
            while (nextDay < days.Length && days[today] + durations[i] > days[nextDay])
            {
                nextDay++;
            }
            answer = Math.Min(answer, costs[i] + this.MincostTickets(days, costs, nextDay, dp));
        }
        dp[today] = answer;
        return answer;
    }

    public int MincostTickets3(int[] days, int[] costs)
    {
        ArgumentNullException.ThrowIfNull(days);
        ArgumentNullException.ThrowIfNull(costs);
        int[] dp = new int[days.Length + 1];
        Array.Fill(dp, int.MaxValue);
        dp[^1] = 0;
        for (int i = dp.Length - 1; i >= 0; i--)
        {
            for (int j = 0, k = i; j < durations.Length; j++)
            {
                while (k < days.Length && days[i] + durations[j] > days[k])
                {
                    k++;
                }
                dp[i] = Math.Min(dp[i], costs[j] + dp[k]);
            }
        }
        return dp[0];
    }
}