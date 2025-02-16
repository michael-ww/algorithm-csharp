namespace Belly.Algorithm.LeetCode;

public class LeetCode906
{
    public int SuperpalindromesInRange(string left, string right)
    {
        long leftBoundry = long.Parse(left);
        long rightBoundry = long.Parse(right);
        if (leftBoundry > rightBoundry || rightBoundry <= 0)
        {
            return 0;
        }

        long limit = (long)Math.Sqrt(rightBoundry);
        long seed = 1, number = 0;
        int answer = 0;
        do
        {
            number = this.EnlargeEven(seed);
            if (this.Check(number * number, leftBoundry, rightBoundry))
            {
                answer++;
            }
            number = this.EnlargeOdd(seed);
            if (this.Check(number * number, leftBoundry, rightBoundry))
            {
                answer++;
            }
            seed++;
        }
        while (number < limit);

        return answer;
    }

    private bool Check(long number, long leftBoundry, long rightBoundry)
    {
        return number >= leftBoundry && number <= rightBoundry && this.IsPalindrome(number);
    }

    private bool IsPalindrome(long number)
    {
        long offset = 1;
        while (number / offset > 10)
        {
            offset *= 10;
        }
        while (number != 0)
        {
            if (number / offset != number % 10)
            {
                return false;
            }
            number = number % offset / 10;
            offset /= 100;
        }
        return true;
    }

    private long EnlargeEven(long seed)
    {
        long answer = seed;
        while (seed != 0)
        {
            answer = answer * 10 + seed % 10;
            seed /= 10;
        }
        return answer;
    }

    private long EnlargeOdd(long seed)
    {
        long answer = seed;
        seed /= 10;
        while (seed != 0)
        {
            answer = answer * 10 + seed % 10;
            seed /= 10;
        }

        return answer;
    }
}
