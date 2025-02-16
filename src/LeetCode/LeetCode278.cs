namespace Belly.Algorithm.LeetCode;

public class LeetCode278
{
    public int FirstBadVersion(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        int left = 1, right = n;
        while (left < right)
        {
            int middle = left + (right - left) / 2;
            if (this.IsBadVersion(middle))
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return left;
    }

    private bool IsBadVersion(int n)
    {
        return Random.Shared.Next(9) % 3 == 0;
    }
}