namespace Algorithm.LeetCode;

public class LeetCode7
{
    public int Reverse(int x)
    {
        int answer = 0;
        while (x != 0)
        {
            if (answer > int.MaxValue / 10 || answer < int.MinValue / 10)
            {
                return 0;
            }
            answer = answer * 10 + x % 10;
            x /= 10;
        }
        return answer;
    }
}
