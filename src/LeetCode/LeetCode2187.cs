namespace Algorithm.LeetCode;

public class LeetCode2187
{
    public long MinimumTime(int[] time, int totalTrips)
    {
        int low = 1, high = totalTrips * time.Max(), answer = 0;
        while (low <= high)
        {
            int middle = low + (high - low) >> 1;
            if (this.GetTime(time, middle) > totalTrips)
            {
                answer = middle;
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }
        }
        return answer;
    }

    private int GetTime(int[] time, int tm)
    {
        int count = 0;
        foreach (var item in time)
        {
            count += tm / item;
        }
        return count;
    }
}
