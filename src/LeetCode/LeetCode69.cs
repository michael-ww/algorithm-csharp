namespace Belly.Algorithm.LeetCode;

public class LeetCode69
{
    public int MySqrt(int x)
    {
        if (x < 0)
        {
            return int.MinValue;
        }
        if (x == 0)
        {
            return 0;
        }

        double C = x, x0 = x;
        while (true)
        {
            double xi = 0.5 * (x0 + C / x0);
            if (Math.Abs(x0 - xi) < 1e-7)
            {
                break;
            }
            x0 = xi;
        }
        return (int)x0;
    }
}
