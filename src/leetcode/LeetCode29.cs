namespace Algorithm.LeetCode;

public class LeetCode29
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException(nameof(divisor));
        }

        if (dividend == int.MinValue)
        {
            if (divisor == 1)
            {
                return int.MinValue;
            }
            if (divisor == -1)
            {
                return int.MaxValue;
            }
        }

        if (divisor == int.MinValue)
        {
            return dividend == int.MaxValue ? 1 : 0;
        }

        if (dividend == 0)
        {
            return 0;
        }

        bool reversed = false;
        if (dividend > 0)
        {
            dividend = -dividend;
            reversed = !reversed;
        }
        if (divisor > 0)
        {
            divisor = -divisor;
            reversed = !reversed;
        }

        IList<int> candidates = new List<int>();
        candidates.Add(divisor);
        int index = 0;
        while (candidates[index] >= dividend - candidates[index])
        {
            candidates.Add(candidates[index] + candidates[index]);
            index++;
        }

        int answer = 0;
        for (int i = candidates.Count - 1; i >= 0; i--)
        {
            if (candidates[i] >= dividend)
            {
                answer += 1 << i;
                dividend -= candidates[i];
            }
        }

        return reversed ? -answer : answer;
    }
}
