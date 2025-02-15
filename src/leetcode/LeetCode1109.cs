namespace Algorithm.LeetCode;

public class LeetCode1109
{
    public int[] CorpFlightBookings(int[][] bookings, int n)
    {
        ArgumentNullException.ThrowIfNull(bookings);
        ArgumentOutOfRangeException.ThrowIfNegative(bookings.Length);
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        int[] count = new int[n + 2];
        foreach (var item in bookings)
        {
            count[item[0]] += item[2];
            count[item[1] + 1] -= item[2];
        }

        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        int[] answer = new int[n];
        for (int i = 0; i < answer.Length; i++)
        {
            answer[i] = count[i + 1];
        }

        return answer;
    }
}
