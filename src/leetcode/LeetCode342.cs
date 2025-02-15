namespace Algorithm.LeetCode;

public class LeetCode342
{
    public bool IsPowerOfFour1(int n)
    {
        return n > 0 && (n & (n - 1)) == 0 && (n & 0xaaaaaaaa) == 0;
    }

    public bool IsPowerOfFour2(int n)
    {
        return n > 0 && (n & (n - 1)) == 0 && n % 3 == 1;
    }
}
