namespace Belly.Algorithm.LeetCode;

public class LeetCode866
{
    public int PrimePalindrome(int n)
    {
        while (true)
        {
            if (Utility.IsPalindrome(n) && Utility.IsPrime(n))
            {
                return n;
            }
            n++;
            if (n > 10000000 && n < 100000000)
            {
                n = 100000000;
            }
        }
    }
}
