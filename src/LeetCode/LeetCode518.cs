namespace Belly.Algorithm.LeetCode;

public class LeetCode518
{
    public int Change1(int amount, int[] coins)
    {
        if (amount < 0 || coins == null)
        {
            return 0;
        }

        return this.ChangeInternal1(amount, coins, 0);
    }

    private int ChangeInternal1(int amount, int[] conins, int index)
    {
        if (index >= conins.Length)
        {
            return amount == 0 ? 1 : 0;
        }

        int ways = 0;
        for (int sheet = 0; conins[index] * sheet <= amount; sheet++)
        {
            ways += this.ChangeInternal1(amount - (conins[index] * sheet), conins, index + 1);
        }

        return ways;
    }

    public int Change2(int amount, int[] coins)
    {
        if (amount < 0 || coins == null)
        {
            return 0;
        }
        int[,] dp = new int[amount + 1, coins.Length + 1];
        for (int i = 0; i <= amount; i++)
        {
            for (int j = 0; j <= coins.Length; j++)
            {
                dp[i, j] = -1;
            }
        }
        return this.ChangeInternal2(amount, coins, 0, dp);
    }

    private int ChangeInternal2(int amount, int[] coins, int index, int[,] dp)
    {
        if (index >= coins.Length)
        {
            return amount == 0 ? 1 : 0;
        }

        if (dp[amount, index] != -1)
        {
            return dp[amount, index];
        }

        dp[amount, index] = 0;
        for (int sheet = 0; coins[index] * sheet <= amount; sheet++)
        {
            dp[amount, index] += index + 1 <= coins.Length ? this.ChangeInternal2(amount - (coins[index] * sheet), coins, index + 1, dp) : 0;
        }

        return dp[amount, index];
    }

    public int Change3(int amount, int[] coins)
    {
        if (amount <= 0 || coins == null)
        {
            return 0;
        }

        int[,] dp = new int[coins.Length + 1, amount + 1];
        for (int i = coins.Length; i >= 0; i--)
        {
            for (int j = amount; j >= 0; j--)
            {
                if (i == coins.Length)
                {
                    dp[i, j] = j == 0 ? 1 : 0;
                }
                else
                {
                    for (int sheet = 0; coins[i] * sheet <= j; sheet++)
                    {
                        dp[i, j] += (j - coins[i] * sheet) >= 0 ? dp[i + 1, j - coins[i] * sheet] : 0;
                    }
                }
            }
        }

        return dp[0, amount];
    }

    public int Change4(int amount, int[] coins)
    {
        if (amount < 0 || coins == null)
        {
            return 0;
        }

        int[,] dp = new int[coins.Length + 1, amount + 1];
        for (int i = coins.Length; i >= 0; i--)
        {
            for (int j = 0; j <= amount; j++)
            {
                if (i == coins.Length)
                {
                    dp[i, j] = j == 0 ? 1 : 0;
                }
                else
                {
                    dp[i, j] = dp[i + 1, j] + (j - coins[i] >= 0 ? dp[i, j - coins[i]] : 0);
                }
            }
        }

        return dp[0, amount];
    }

    public int Change5(int amount, int[] coins)
    {
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        foreach (int coin in coins)
        {
            for (int i = coin; i <= amount; i++)
            {
                dp[i] += dp[i - coin];
            }
        }

        return dp[amount];
    }
}