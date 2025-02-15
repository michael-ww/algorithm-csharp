namespace Algorithm.LeetCode;

public class LeetCode322
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount < 0 || coins == null)
        {
            return -1;
        }
        if (amount == 0)
        {
            return 0;
        }

        return this.CoinChangeInternal(coins, amount);
    }

    private int CoinChangeInternal(int[] coins, int amount)
    {
        if (amount == 0)
        {
            return 0;
        }
        int answer = int.MaxValue;
        for (int i = 0; i < coins.Length; i++)
        {
            answer = amount - coins[i] >= 0 ? this.CoinChangeInternal(coins, amount - coins[i]) + 1 : 0;
        }
        return answer;
    }
}
