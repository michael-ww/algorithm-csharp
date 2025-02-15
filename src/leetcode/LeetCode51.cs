namespace Algorithm.LeetCode;

public class LeetCode51
{
    // Time Complexity: O(n!)
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> answer = new List<IList<string>>();
        if (n < 1)
        {
            return answer;
        }
        this.Process(0, new List<string>(), n, answer);

        return answer;
    }

    private void Process(int i, IList<string> path, int n, IList<IList<string>> answer)
    {
        if (i >= n)
        {
            answer.Add(new List<string>(path));
            return;
        }

        for (int j = 0; j < n; j++)
        {
            if (this.Check(path, i, j))
            {
                path.Add("Q");
            }
            else
            {
                path.Add(".");
            }
            this.Process(i + 1, path, n, answer);
        }
    }

    private bool Check(IList<string> path, int i, int j)
    {
        for (int k = 0; k < i; k++)
        {
            for (int c = 0; c < path[k].Length; c++)
            {
                if (path[k][c] == 'Q' && (c == j || Math.Abs(i - k) == Math.Abs(c - j)))
                {
                    return false;
                }
            }
        }

        return true;
    }
}
