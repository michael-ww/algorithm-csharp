namespace Belly.Algorithm.LeetCode;

public class LeetCode367
{
    public bool IsPerfectSquare1(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int left = 0, right = num;
        while (left <= right)
        {
            int middle = left + ((right - left) >> 1);
            int square = middle * middle;
            if (square > num)
            {
                right = middle - 1;
            }
            else if (square < num)
            {
                left = middle + 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    public bool IsPerfectSquare2(int num)
    {
        if (num < 0)
        {
            return false;
        }

        int x = (int)Math.Sqrt(num);
        return x * x == num;
    }

    public bool IsPerfectSquare3(int num)
    {
        if (num < 0)
        {
            return false;
        }

        double x0 = num;
        while (true)
        {
            double x1 = (x0 + num / x0) / 2;
            if (x0 - x1 < 1e-6)
            {
                break;
            }
            x0 = x1;
        }
        int x = (int)x0;
        return x * x == num;
    }
}
