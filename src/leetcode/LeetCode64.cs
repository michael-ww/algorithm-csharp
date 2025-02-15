namespace Algorithm.LeetCode;

public class LeetCode64
{
    public int MinPathSum1(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);
        return this.Recurring(grid, grid.GetLength(0) - 1, grid.GetLength(1) - 1);
    }

    private int Recurring(int[,] grid, int i, int j)
    {
        if (i == 0 && j == 0)
        {
            return grid[0, 0];
        }
        int up = int.MaxValue;
        if (i > 0)
        {
            up = this.Recurring(grid, i - 1, j);
        }
        int left = int.MaxValue;
        if (j > 0)
        {
            left = this.Recurring(grid, i, j - 1);
        }
        return grid[i, j] + Math.Min(up, left);
    }

    public int MinPathSum2(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);
        int[,] dp = new int[grid.GetLength(0), grid.GetLength(1)];
        for (int i = 0; i < dp.GetLength(0); i++)
        {
            for (int j = 0; j < dp.GetLength(1); j++)
            {
                dp[i, j] = -1;
            }
        }
        return this.Recurring(grid, grid.GetLength(0) - 1, grid.GetLength(1) - 1, dp);
    }

    private int Recurring(int[,] grid, int i, int j, int[,] dp)
    {
        if (dp[i, j] != -1)
        {
            return dp[i, j];
        }
        if (i == 0 && j == 0)
        {
            return grid[0, 0];
        }
        int up = int.MaxValue;
        if (i > 0)
        {
            up = this.Recurring(grid, i - 1, j, dp);
        }
        int left = int.MaxValue;
        if (j > 0)
        {
            left = this.Recurring(grid, i, j - 1);
        }
        int answer = grid[i, j] + Math.Min(up, left);
        dp[i, j] = answer;
        return answer;
    }

    public int MinPathSum3(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);
        int[,] dp = new int[grid.GetLength(0), grid.GetLength(1)];
        dp[0, 0] = grid[0, 0];
        for (int i = 1; i < grid.GetLength(0); i++)
        {
            dp[i, 0] = grid[i, 0] + dp[i - 1, 0];
        }
        for (int j = 1; j < grid.GetLength(1); j++)
        {
            dp[0, j] = grid[0, j] + dp[0, j - 1];
        }
        for (int i = 1; i < grid.GetLength(0); i++)
        {
            for (int j = 1; j < grid.GetLength(1); j++)
            {
                dp[i, j] = grid[i, j] + Math.Min(dp[i - 1, j], dp[i, j - 1]);
            }
        }

        return dp[grid.GetLength(0) - 1, grid.GetLength(1) - 1];
    }

    public int MinPathSum4(int[,] grid)
    {
        ArgumentNullException.ThrowIfNull(grid);
        int[] dp = new int[grid.GetLength(1)];
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[j] = grid[0, 0];
                }
                else if (i == 0 && j != 0)
                {
                    dp[j] = grid[i, j] + dp[j - 1];
                }
                else if (i != 0 && j == 0)
                {
                    dp[j] = grid[i, j] + dp[j];
                }
                else
                {
                    dp[j] = grid[i, j] + Math.Min(dp[j - 1], dp[j]);
                }
            }
        }
        return dp[^1];
    }
}
