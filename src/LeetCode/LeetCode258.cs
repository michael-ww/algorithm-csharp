namespace Belly.Algorithm.LeetCode;

public class LeetCode258
{
    public int AddDigits1(int num)
    {
        if (num < 10)
        {
            return num;
        }

        int answer = 0;
        while (answer > 9)
        {
            while (num > 0)
            {
                answer += num % 10;
                num /= 10;
            }
        }

        return answer;
    }

    public int AddDigits2(int num)
    {
        return (num - 1) % 9 + 1; ;
    }

    public int AddDigits3(int num)
    {
        if (num == 0)
        {
            return 0;
        }
        else if (num % 9 == 0)
        {
            return 9;
        }
        else
        {
            return num % 9;
        }
    }
}
