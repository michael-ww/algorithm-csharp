namespace Belly.Algorithm.LeetCode;

public class LeetCode875
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1, high = piles.Max(), answer = 0;
        while (low <= high)
        {
            int speed = low + ((high - low) >> 1);
            int hour = this.GetTime(piles, speed);
            if (hour <= h)
            {
                answer = speed;
                high = speed - 1;
            }
            else
            {
                low = speed + 1;
            }
        }

        return answer;
    }

    private int GetTime(int[] piles, int speed)
    {
        int time = 0;
        foreach (var pile in piles)
        {
            time += (pile + speed - 1) / speed;
        }
        return time;
    }
}
