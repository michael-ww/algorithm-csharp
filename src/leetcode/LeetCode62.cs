namespace Algorithm.LeetCode;

public class LeetCode62
{
    public int UniquePaths(int m, int n)
    {
        if (m < 0 || n < 0)
        {
            throw new InvalidOperationException();
        }
        return this.Backtrack(new int[m, n], 0, 0);
    }

    private int Backtrack(int[,] grid, int i, int j)
    {
        if (i >= grid.GetLength(0) || j >= grid.GetLength(1) || grid[i, j] == 1)
        {
            return 0;
        }
        if (i == grid.GetLength(0) - 1 && j == grid.GetLength(1) - 1)
        {
            return 1;
        }
        grid[i, j] = 1;
        int answer = this.Backtrack(grid, i + 1, j);
        answer += this.Backtrack(grid, i, j + 1);
        grid[i, j] = 0;
        return answer;
    }
}
