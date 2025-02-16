namespace Belly.Algorithm.LeetCode;

public class LeetCode119
{
    public IList<int> GetRow(int rowIndex)
    {
        IList<int> answer = new List<int>();
        if (rowIndex < 0)
        {
            return answer;
        }

        for (int i = 0; i <= rowIndex; i++)
        {
            List<int> current = new();
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    current.Add(j);
                }
                else
                {
                    current.Add(answer[j - 1] + answer[j]);
                }
            }
            answer = current;
        }

        return answer;
    }
}