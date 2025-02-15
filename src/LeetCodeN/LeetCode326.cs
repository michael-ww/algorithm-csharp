namespace Algorithm.LeetCode;

public class LeetCode326
{
    public bool IsPowerOfThree1(int n)
    {
        while (n != 0 && n % 3 == 0)
        {
            n /= 3;
        }

        return n == 1;
    }

    public bool IsPowerOfThree2(int n)
    {
        return n > 0 && 1162261467 % n == 0;
    }
}
