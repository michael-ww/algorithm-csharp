namespace Algorithm.LeetCode;

public class LeetCode50
{
    public double MyPow(double x, int n)
    {
        return n > 0 ? QuickMultiple(x, n) : 1d / QuickMultiple(x, -n);
    }

    public double QuickMultiple(double x, long n)
    {
        double answer = 1.0;
        double xContribute = x;
        while (n > 0)
        {
            if (n % 2 == 1)
            {
                answer *= xContribute;
            }
            xContribute *= xContribute;
            n /= 2;
        }
        return answer;
    }
}
