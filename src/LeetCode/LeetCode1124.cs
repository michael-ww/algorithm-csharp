namespace Belly.Algorithm.LeetCode;

public class LeetCode1124
{
    public int LongestWPI(int[] hours)
    {
        if (hours == null || hours.Length <= 0)
        {
            return 0;
        }

        Dictionary<int, int> dictionary = new();
        int answer = 0, sum = 0;
        for (int i = 0; i < hours.Length; i++)
        {
            sum += hours[i] > 8 ? 1 : -1;
            if (sum > 0)
            {
                answer = i + 1;
            }
            else
            {
                if (dictionary.ContainsKey(sum - 1))
                {
                    answer = Math.Max(answer, i - dictionary[sum - 1]);
                }
            }
            dictionary.TryAdd(sum, i);
        }

        return answer;
    }
}
