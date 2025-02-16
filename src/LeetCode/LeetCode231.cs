namespace Belly.Algorithm.LeetCode;

public class LeetCode231
{
    public bool IsPowerOfTwo1(int n)
    {
        return n > 0 && n == (n & (~n + 1));
    }

    public bool IsPowerOfTwo2(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
}
