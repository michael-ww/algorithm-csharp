namespace Belly.Algorithm.LeetCode;

public class LeetCode204
{
    public int CountPrimes(int n)
    {
        if (n < 2)
        {
            return 0;
        }
        int answer = 0;
        for (int i = 2; i < n; i++)
        {
            answer += Utility.IsPrime(i) ? 1 : 0;
        }
        return answer;
    }
}
