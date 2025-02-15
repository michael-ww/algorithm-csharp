namespace Algorithm.LeetCode;

public class LeetCode263
{
    public bool IsUgly(int n)
    {
        if (n <= 0)
        {
            return false;
        }

        int[] factors = [2, 3, 5];
        foreach (var item in factors)
        {
            while (n % item == 0)
            {
                n /= item;
            }
        }

        return n == 1;
    }
}
