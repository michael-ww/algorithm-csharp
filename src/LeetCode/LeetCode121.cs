namespace Belly.Algorithm.LeetCode;

public class LeetCode121
{
    public int MaxProfit1(int[] prices)
    {
        int maxProfix = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = prices.Length - 1; j >= 0; j--)
            {
                if (i >= j)
                {
                    break;
                }
                else
                {
                    maxProfix = Math.Max(maxProfix, prices[j] - prices[i]);
                }
            }
        }

        return maxProfix;
    }

    public int MaxProfit2(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfix = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                maxProfix = Math.Max(maxProfix, prices[i] - minPrice);
            }
        }

        return maxProfix;
    }
}
