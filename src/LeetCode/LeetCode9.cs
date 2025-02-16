namespace Belly.Algorithm.LeetCode;

public class LeetCode9
{
    public bool IsPalindrome1(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x < 10)
        {
            return true;
        }

        string xs = x.ToString();
        string reversed = xs.Reverse().ToString();
        if (xs == reversed)
        {
            return true;
        }
        return false;
    }

    public bool IsPalindrome2(int x)
    {
        if (x < 0)
        {
            return false;
        }
        if (x < 10)
        {
            return true;
        }

        int div = 1;
        while (x / div >= 10)
        {
            div *= 10;
        }
        while (x > 0)
        {
            int left = x / div;
            int right = x % 10;
            if (left != right)
            {
                return false;
            }
            x = x % div / 10;
            div /= 100;
        }
        return true;
    }

    public bool IsPalindrome3(int x)
    {
        if (x < 0)
        {
            return false;
        }

        if (x < 10)
        {
            return true;
        }

        int reversed = 0;
        while (x > reversed)
        {
            reversed = reversed * 10 + x % 10;
            x /= 10;
        }

        return x == reversed || x == reversed / 10;
    }
}
