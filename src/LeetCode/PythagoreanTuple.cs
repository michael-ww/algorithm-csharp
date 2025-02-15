namespace Algorithm.LeetCode;

public class PythagoreanTuple
{
    public IList<IList<int>> GetPythagoreanTuple(int n, int m)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        for (int i = n; i < m; i++)
        {
            for (int j = i + 1; j < m; j++)
            {
                int k = (int)Math.Sqrt(i * i + j * j);
                if (k < m)
                {
                    if (Utility.GreatestCommonDivisor(i, j) == 1 && Utility.GreatestCommonDivisor(j, k) == 1 && Utility.GreatestCommonDivisor(i, k) == 1)
                    {
                        answer.Add(new List<int>() { i, j, k });
                    }
                }
                else
                {
                    break;
                }
            }
        }

        return answer;
    }

    private bool IsCoprime(int x, int y)
    {
        return Utility.GreatestCommonDivisor(x, y) == 1;
    }
}
