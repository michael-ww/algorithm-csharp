namespace Belly.Algorithm.LeetCode;

public class LeetCode2141
{
    public long MaxRunTime(int n, int[] batteries)
    {
        int max = 0;
        long sum = 0;
        foreach (var item in batteries)
        {
            max = Math.Max(max, item);
            sum += item;
        }

        if (sum >= max * n)
        {
            return sum / n;
        }

        int answer = 0, left = 0, right = max;
        while (left <= right)
        {
            int middle = left + ((right - left) >> 1);
            if (this.BinarySearch(batteries, n, middle))
            {
                answer = middle;
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return answer;
    }

    private bool BinarySearch(int[] batteries, int n, int time)
    {
        long sum = 0;
        foreach (var item in batteries)
        {
            if (item > time)
            {
                n--;
            }
            else
            {
                sum += item;
            }
            if (sum >= n * time)
            {
                return true;
            }
        }

        return false;
    }
}
