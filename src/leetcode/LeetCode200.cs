namespace Algorithm.LeetCode;

public class LeetCode200
{
    // Time Complexity : O(N*M)
    public int CountIslands(char[][] grid)
    {
        if (grid == null || grid.Length <= 0 || grid[0] == null || grid[0].Length <= 0)
        {
            return 0;
        }

        int answer = 0;
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    answer++;
                    this.Infect(grid, i, j);
                }
            }
        }

        return answer;
    }

    public void Infect(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1')
        {
            return;
        }
        grid[i][j] = 'i';
        this.Infect(grid, i, j - 1);
        this.Infect(grid, i, j + 1);
        this.Infect(grid, i - 1, j);
        this.Infect(grid, i + 1, j);
    }
}
