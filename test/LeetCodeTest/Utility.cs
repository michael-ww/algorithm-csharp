namespace Belly.Algorithm.LeetCodeTest;

public static class Utility
{
    public static int[] GenerateArray(int length, int maxValue = int.MaxValue, bool distinct = true, bool includeNegative = false)
    {
        if (distinct && maxValue < length)
        {
            throw new InvalidOperationException();
        }
        HashSet<int> help = new();
        int[] answer = new int[length];
        for (int i = 0; i < length; i++)
        {
            int num;
            do
            {
                num = includeNegative && Random.Shared.Next(6) % 3 == 0 ? -Random.Shared.Next(maxValue) : Random.Shared.Next(maxValue);
            }
            while (distinct && help.Contains(num));
            help.Add(num);
            answer[i] = num;
        }
        return answer;
    }

    public static int[,] GenerateArray(int length1, int length2, int maxValue = int.MaxValue, bool distinct = true, bool includeNegative = false)
    {
        if (distinct && maxValue < length1 * length2)
        {
            throw new InvalidOperationException();
        }
        int[,] answer = new int[length1, length2];
        HashSet<int> help = new();
        for (int i = 0; i < length1; i++)
        {
            for (int j = 0; j < length2; j++)
            {
                int number;
                do
                {
                    number = includeNegative && Random.Shared.Next(6) % 3 == 0 ? -Random.Shared.Next(maxValue) : Random.Shared.Next(maxValue);
                }
                while (distinct && help.Contains(number));
                help.Add(number);
                answer[i, j] = number;
            }
        }
        return answer;
    }

    public static int[,,] GenerateArray(int length1, int length2, int length3, int maxValue = int.MaxValue, bool distinct = true, bool includeNegative = false)
    {
        if (distinct && maxValue < length1 * length2 * length3)
        {
            throw new InvalidOperationException();
        }
        int[,,] answer = new int[length1, length2, length3];
        HashSet<int> help = new();
        for (int i = 0; i < length1; i++)
        {
            for (int j = 0; j < length2; j++)
            {
                for (int k = 0; k < length3; k++)
                {
                    int number;
                    do
                    {
                        number = includeNegative && Random.Shared.Next(6) % 3 == 0 ? -Random.Shared.Next(maxValue) : Random.Shared.Next(maxValue);
                    }
                    while (distinct && help.Contains(number));
                    help.Add(number);
                    answer[i, j, k] = number;
                }
            }
        }

        return answer;
    }
}
