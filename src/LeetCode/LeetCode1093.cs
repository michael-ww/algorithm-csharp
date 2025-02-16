namespace Belly.Algorithm.LeetCode;

public class LeetCode1093
{
    public double[] SampleStats(int[] count)
    {
        ArgumentNullException.ThrowIfNull(count);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(count.Length);
        double mean = 0.0, median = 0.0;
        int minimum = 256, maximum = 0, mode = 0;
        long sum = 0;
        int maxFrequency = 0, cnt = 0, left = (count.Sum() + 1) / 2, right = (count.Sum() + 2) / 2;
        for (int i = 0; i < count.Length; i++)
        {
            sum += count[i] * i;
            if (count[i] > maxFrequency)
            {
                maxFrequency = count[i];
                mode = i;
            }
            if (count[i] > 0)
            {
                if (minimum == 256)
                {
                    minimum = i;
                }
                maximum = i;
            }
            if (cnt < right && cnt + count[i] >= right)
            {
                median += i;
            }
            if (cnt < left && cnt + count[i] >= left)
            {
                median += i;
            }
            cnt += count[i];
        }
        mean = sum / count.Sum();
        median = median / 2d;
        return new double[] { minimum, maximum, mean, median, mode };
    }
}
