namespace Belly.Algorithm.LeetCode;

public class LeetCode118
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> answer = new List<IList<int>>();
        if (numRows <= 0)
        {
            return answer;
        }

        for (int i = 0; i < numRows; i++)
        {
            IList<int> row = new List<int>();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(j);
                }
                else
                {
                    row.Add(answer[i - 1][j - 1] + answer[i - 1][j]);
                }
            }

            answer.Add(row);
        }

        return answer;
    }
}
