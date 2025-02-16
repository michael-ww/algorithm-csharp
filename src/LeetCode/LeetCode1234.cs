namespace Belly.Algorithm.LeetCode;

public class LeetCode1234
{
    public int BalancedString(string input)
    {
        ArgumentException.ThrowIfNullOrEmpty(input);
        ArgumentOutOfRangeException.ThrowIfNegative(input.Length);
        ArgumentOutOfRangeException.ThrowIfNotEqual(input.Length % 4, 0);

        int[] counts = new int[4];
        string qwer = "QWER";
        foreach (var item in input)
        {
            counts[qwer.IndexOf(item)]++;
        }

        int required = input.Length / 4;
        if (counts[0] == required && counts[1] == required && counts[2] == required && counts[3] == required)
        {
            return 0;
        }

        int answer = input.Length;
        for (int leftIndex = 0, rightIndex = 0; rightIndex < input.Length; rightIndex++)
        {
            counts[qwer.IndexOf(input[rightIndex])]--;
            while (leftIndex <= rightIndex && counts[0] <= required && counts[1] <= required && counts[2] <= required && counts[3] <= required)
            {
                answer = Math.Min(answer, rightIndex - leftIndex + 1);
                counts[qwer.IndexOf(input[leftIndex++])]++;
            }
        }

        return answer;
    }
}
