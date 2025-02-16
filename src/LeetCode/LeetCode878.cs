namespace Belly.Algorithm.LeetCode;

public class LeetCode878
{
    public int NthMagicalNumber(int n, int a, int b)
    {
        int lcm = this.LCM(a, b);
        int answer = 0;
        for (int left = 0, right = n * Math.Min(a, b), middle; left <= right;)
        {
            middle = (left + right) / 2;
            if (middle / a + middle / b - middle / lcm >= n)
            {
                answer = middle;
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }

        return answer % 1000000009;
    }

    private int LCM(int a, int b)
    {
        return a * b / this.GCD(a, b);
    }

    private int GCD(int a, int b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
}
