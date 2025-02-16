namespace Belly.Algorithm.LeetCode;

public class LeetCode2064
{
    public int MinimizedMaximum(int n, int[] quantities)
    {
        if (n < quantities.Length)
        {
            return 0;
        }
        int low = 1, high = 0;
        foreach (var quantity in quantities)
        {
            high = Math.Max(high, quantity);
        }

        int answer = 0;
        while (low <= high)
        {
            int quantity = low + (high - low) >> 1;
            if (this.GetCount(quantities, quantity) > n)
            {
                low = quantity + 1;
            }
            else
            {
                answer = quantity;
                high = quantity - 1;
            }
        }

        return answer;
    }

    private int GetCount(int[] quantities, int quantity)
    {
        int count = 0;
        foreach (var item in quantities)
        {
            count += (item + quantity - 1) / quantity;
        }

        return count;
    }
}
