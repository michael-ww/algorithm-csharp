namespace Belly.Algorithm.LeetCode;

public class LeetCode63
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        ArgumentNullException.ThrowIfNull(obstacleGrid);
        return this.Backtrack(obstacleGrid, 0, 0);
    }

    private int Backtrack(int[][] obstacleGrid, int i, int j)
    {
        if (i >= obstacleGrid.Length || j >= obstacleGrid[0].Length || obstacleGrid[i][j] == 1)
        {
            return 0;
        }
        if (i == obstacleGrid.Length - 1 && j == obstacleGrid[0].Length - 1)
        {
            return 1;
        }
        obstacleGrid[i][j] = 1;
        int answer = this.Backtrack(obstacleGrid, i + 1, j);
        answer += this.Backtrack(obstacleGrid, i, j + 1);
        obstacleGrid[i][j] = 0;
        return answer;
    }
}
