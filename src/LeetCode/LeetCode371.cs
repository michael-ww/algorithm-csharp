namespace Belly.Algorithm.LeetCode;

public class LeetCode371
{
    public int Add(int a, int b)
    {
        int sum = a ^ b;
        int carry = (a & b) << 1;
        while (carry != 0)
        {
            sum ^= carry;
            carry = (carry & sum) << 1;
        }
        return sum;
    }

    public int Minus(int a, int b)
    {
        return this.Add(a, this.Negative(b));
    }

    public int Mutiple(int a, int b)
    {
        int answer = 0;
        while (b != 0)
        {
            if ((b & 1) != 0)
            {
                answer = this.Add(answer, a);
            }
            a <<= 1;
            b >>>= 1;
        }

        return answer;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        if (a == int.MinValue && b == int.MinValue)
        {
            return 1;
        }
        else if (b == int.MinValue)
        {
            return 0;
        }
        else if (a == int.MinValue)
        {
            int result = this.Divide(this.Add(a, 1), b);
            return this.Add(result, this.DivideInternel(this.Minus(a, this.Mutiple(result, b)), b));
        }
        else
        {
            return this.DivideInternel(a, b);
        }
    }

    private int DivideInternel(int a, int b)
    {
        int x = a < 0 ? this.Negative(a) : a;
        int y = b < 0 ? this.Negative(b) : b;
        int answer = 0;
        for (int i = 31; i >= 0; i--)
        {
            if ((x >> i) >= y)
            {
                answer |= (1 << i);
                x = this.Minus(x, y << i);
            }
        }

        return (a < 0) ^ (b < 0) ? this.Negative(answer) : answer;
    }

    public int Negative(int n)
    {
        return this.Add(~n, 1);
    }
}
